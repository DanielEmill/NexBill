namespace RecurrentPayments.UI;

partial class MainForm
{
    private System.ComponentModel.IContainer components = null;

    protected override void Dispose(bool disposing)
    {
        if (disposing && components != null) components.Dispose();
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        tabControl = new TabControl();
        tabDashboard = new TabPage();
        tabClients = new TabPage();
        tabContracts = new TabPage();
        tabInvoices = new TabPage();
        tabPayments = new TabPage();
        SuspendLayout();

        tabControl.Controls.Add(tabDashboard);
        tabControl.Controls.Add(tabClients);
        tabControl.Controls.Add(tabContracts);
        tabControl.Controls.Add(tabInvoices);
        tabControl.Controls.Add(tabPayments);
        tabControl.Dock = DockStyle.Fill;
        tabControl.Font = new System.Drawing.Font("Segoe UI", 10F);

        tabDashboard.Text = "  Dashboard  ";
        tabClients.Text = "  Clientes  ";
        tabContracts.Text = "  Contratos  ";
        tabInvoices.Text = "  Facturas  ";
        tabPayments.Text = "  Pagos  ";

        this.Controls.Add(tabControl);
        ResumeLayout(false);
    }

    private TabControl tabControl;
    private TabPage tabDashboard;
    private TabPage tabClients;
    private TabPage tabContracts;
    private TabPage tabInvoices;
    private TabPage tabPayments;
}