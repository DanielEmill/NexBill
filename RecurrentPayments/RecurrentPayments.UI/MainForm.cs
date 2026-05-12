namespace RecurrentPayments.UI;

public partial class MainForm : Form
{
    public MainForm()
    {
        InitializeComponent();
        this.Text = "Sistema de Pagos Recurrentes";
        this.Width = 1100;
        this.Height = 680;
        this.StartPosition = FormStartPosition.CenterScreen;
        this.BackColor = System.Drawing.Color.FromArgb(245, 245, 245);

        var clientsView = new Views.ClientsView();
        tabClients.Controls.Add(clientsView);

        var contractsView = new Views.ContractsView();
        tabContracts.Controls.Add(contractsView);
    }
}