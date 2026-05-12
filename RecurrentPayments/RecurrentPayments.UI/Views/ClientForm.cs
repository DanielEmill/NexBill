using Microsoft.Extensions.DependencyInjection;
using RecurrentPayments.Application.DTOs;
using RecurrentPayments.Application.Services;
using System.Xml.Linq;

namespace RecurrentPayments.UI.Views;

public partial class ClientForm : Form
{
    private readonly ClientService _service;
    private readonly ClientDto? _editing;

    public ClientForm(ClientDto? client = null)
    {
        InitializeComponent();
        _service = Program.ServiceProvider.GetRequiredService<ClientService>();
        _editing = client;

        if (_editing != null)
        {
            this.Text = "Editar Cliente";
            txtName.Text = _editing.Name;
            txtPhone.Text = _editing.Phone;
            txtEmail.Text = _editing.Email;
        }
        else this.Text = "Nuevo Cliente";
    }

    private async void BtnSave_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(txtName.Text))
        {
            MessageBox.Show("El nombre es requerido.", "Validación",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        var dto = new ClientDto
        {
            Id = _editing?.Id ?? 0,
            Name = txtName.Text,
            Phone = txtPhone.Text,
            Email = txtEmail.Text
        };

        if (_editing == null) await _service.CreateAsync(dto);
        else await _service.UpdateAsync(dto);

        this.DialogResult = DialogResult.OK;
        this.Close();
    }

    private void BtnCancel_Click(object sender, EventArgs e)
    {
        this.DialogResult = DialogResult.Cancel;
        this.Close();
    }
}