using RecurrentPayments.Application.DTOs;
using RecurrentPayments.Application.Services;
using Microsoft.Extensions.DependencyInjection;

namespace RecurrentPayments.UI.Views;

public partial class ContractsView : UserControl
{
    private readonly ContractService _service;
    private List<ContractDto> _contracts = new();

    public ContractsView()
    {
        InitializeComponent();
        _service = Program.ServiceProvider.GetRequiredService<ContractService>();
        this.Load += async (s, e) => await LoadAsync();
    }

    private async Task LoadAsync()
    {
        _contracts = await _service.GetAllAsync();
        RefreshGrid();
    }

    private void RefreshGrid()
    {
        dgvContracts.DataSource = null;
        dgvContracts.DataSource = _contracts;

        if (dgvContracts.Columns.Count == 0) return;

        dgvContracts.Columns["Id"].Visible = false;
        dgvContracts.Columns["ClientId"].Visible = false;
        dgvContracts.Columns["Frequency"].Visible = false;
        dgvContracts.Columns["Status"].Visible = false;
        dgvContracts.Columns["ClientName"].HeaderText = "Cliente";
        dgvContracts.Columns["Amount"].HeaderText = "Monto";
        dgvContracts.Columns["Amount"].DefaultCellStyle.Format = "C2";
        dgvContracts.Columns["FrequencyDisplay"].HeaderText = "Frecuencia";
        dgvContracts.Columns["NextBillingDate"].HeaderText = "Próxima Factura";
        dgvContracts.Columns["StatusDisplay"].HeaderText = "Estado";
        dgvContracts.Columns["CreatedAt"].HeaderText = "Creado";
        dgvContracts.Columns["CreatedAt"].DefaultCellStyle.Format = "dd/MM/yyyy";
    }

    private void BtnNew_Click(object sender, EventArgs e)
    {
        using var form = new ContractForm();
        if (form.ShowDialog() == DialogResult.OK)
            _ = LoadAsync();
    }

    private async void BtnEdit_Click(object sender, EventArgs e)
    {
        if (dgvContracts.CurrentRow?.DataBoundItem is not ContractDto selected) return;
        using var form = new ContractForm(selected);
        if (form.ShowDialog() == DialogResult.OK)
            await LoadAsync();
    }

    private async void BtnDelete_Click(object sender, EventArgs e)
    {
        if (dgvContracts.CurrentRow?.DataBoundItem is not ContractDto selected) return;

        var confirm = MessageBox.Show(
            $"¿Eliminar contrato de {selected.ClientName}?", "Confirmar",
            MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

        if (confirm == DialogResult.Yes)
        {
            await _service.DeleteAsync(selected.Id);
            await LoadAsync();
        }
    }
}