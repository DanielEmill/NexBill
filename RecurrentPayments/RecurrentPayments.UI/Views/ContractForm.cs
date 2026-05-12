using Microsoft.Extensions.DependencyInjection;
using RecurrentPayments.Application.DTOs;
using RecurrentPayments.Application.Services;
using RecurrentPayments.Domain.Enums;
using System.Net;

namespace RecurrentPayments.UI.Views;

public partial class ContractForm : Form
{
    private readonly ContractService _contractService;
    private readonly ClientService _clientService;
    private readonly ContractDto? _editing;

    public ContractForm(ContractDto? contract = null)
    {
        InitializeComponent();
        _contractService = Program.ServiceProvider.GetRequiredService<ContractService>();
        _clientService = Program.ServiceProvider.GetRequiredService<ClientService>();
        _editing = contract;

        this.Load += async (s, e) => await InitFormAsync();
    }

    private async Task InitFormAsync()
    {
        var clients = await _clientService.GetAllAsync();
        cmbClient.DataSource = clients;
        cmbClient.DisplayMember = "Name";
        cmbClient.ValueMember = "Id";

        cmbFrequency.DataSource = new[]
        {
            new { Value = BillingFrequency.Weekly,   Text = "Semanal"   },
            new { Value = BillingFrequency.Biweekly, Text = "Quincenal" },
            new { Value = BillingFrequency.Monthly,  Text = "Mensual"   }
        };
        cmbFrequency.DisplayMember = "Text";
        cmbFrequency.ValueMember = "Value";

        if (_editing != null)
        {
            this.Text = "Editar Contrato";
            cmbClient.SelectedValue = _editing.ClientId;
            txtAmount.Text = _editing.Amount.ToString();
            cmbFrequency.SelectedValue = _editing.Frequency;
            dtpNextBilling.Value = _editing.NextBillingDate.ToDateTime(TimeOnly.MinValue);
        }
        else
        {
            this.Text = "Nuevo Contrato";
            dtpNextBilling.Value = DateTime.Today;
        }
    }

    private async void BtnSave_Click(object sender, EventArgs e)
    {
        if (cmbClient.SelectedValue is null)
        {
            MessageBox.Show("Selecciona un cliente.", "Validación",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        if (!decimal.TryParse(txtAmount.Text, out decimal amount) || amount <= 0)
        {
            MessageBox.Show("Ingresa un monto válido.", "Validación",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        var dto = new ContractDto
        {
            Id = _editing?.Id ?? 0,
            ClientId = (int)cmbClient.SelectedValue,
            Amount = amount,
            Frequency = (BillingFrequency)cmbFrequency.SelectedValue!,
            NextBillingDate = DateOnly.FromDateTime(dtpNextBilling.Value),
            Status = _editing?.Status ?? ContractStatus.Active
        };

        if (_editing == null) await _contractService.CreateAsync(dto);
        else await _contractService.UpdateAsync(dto);

        this.DialogResult = DialogResult.OK;
        this.Close();
    }

    private void BtnCancel_Click(object sender, EventArgs e)
    {
        this.DialogResult = DialogResult.Cancel;
        this.Close();
    }
}