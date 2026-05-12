using RecurrentPayments.Application.DTOs;
using RecurrentPayments.Application.Services;
using Microsoft.Extensions.DependencyInjection;

namespace RecurrentPayments.UI.Views;

public partial class ClientsView : UserControl
{
    private readonly ClientService _service;
    private List<ClientDto> _clients = new();

    public ClientsView()
    {
        InitializeComponent();
        _service = Program.ServiceProvider.GetRequiredService<ClientService>();
        this.Load += async (s, e) => await LoadClientsAsync();
    }

    private async Task LoadClientsAsync()
    {
        _clients = await _service.GetAllAsync();
        RefreshGrid();
    }

    private void RefreshGrid()
    {
        dgvClients.DataSource = null;
        dgvClients.DataSource = _clients;

        if (dgvClients.Columns.Count == 0) return;

        dgvClients.Columns["Id"].Visible = false;
        dgvClients.Columns["Name"].HeaderText = "Nombre";
        dgvClients.Columns["Phone"].HeaderText = "Teléfono";
        dgvClients.Columns["Email"].HeaderText = "Email";
        dgvClients.Columns["CreatedAt"].HeaderText = "Registrado";
        dgvClients.Columns["CreatedAt"].DefaultCellStyle.Format = "dd/MM/yyyy";
    }

    private void BtnNew_Click(object sender, EventArgs e)
    {
        using var form = new ClientForm();
        if (form.ShowDialog() == DialogResult.OK)
            _ = LoadClientsAsync();
    }

    private async void BtnEdit_Click(object sender, EventArgs e)
    {
        if (dgvClients.CurrentRow?.DataBoundItem is not ClientDto selected) return;
        using var form = new ClientForm(selected);
        if (form.ShowDialog() == DialogResult.OK)
            await LoadClientsAsync();
    }

    private async void BtnDelete_Click(object sender, EventArgs e)
    {
        if (dgvClients.CurrentRow?.DataBoundItem is not ClientDto selected) return;

        var confirm = MessageBox.Show(
            $"¿Eliminar a {selected.Name}?", "Confirmar",
            MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

        if (confirm == DialogResult.Yes)
        {
            await _service.DeleteAsync(selected.Id);
            await LoadClientsAsync();
        }
    }
}