namespace RecurrentPayments.UI.Views;

partial class ClientsView
{
    private System.ComponentModel.IContainer components = null;

    protected override void Dispose(bool disposing)
    {
        if (disposing && components != null) components.Dispose();
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        lblTitle = new Label();
        btnNew = new Button();
        btnEdit = new Button();
        btnDelete = new Button();
        dgvClients = new DataGridView();
        SuspendLayout();

        lblTitle.Text = "Clientes";
        lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
        lblTitle.Location = new System.Drawing.Point(16, 16);
        lblTitle.AutoSize = true;

        btnNew.Text = "＋ Nuevo";
        btnNew.Location = new System.Drawing.Point(16, 60);
        btnNew.Size = new System.Drawing.Size(100, 34);
        btnNew.BackColor = System.Drawing.Color.FromArgb(25, 118, 210);
        btnNew.ForeColor = System.Drawing.Color.White;
        btnNew.FlatStyle = FlatStyle.Flat;
        btnNew.FlatAppearance.BorderSize = 0;
        btnNew.Click += BtnNew_Click;

        btnEdit.Text = "✎ Editar";
        btnEdit.Location = new System.Drawing.Point(124, 60);
        btnEdit.Size = new System.Drawing.Size(100, 34);
        btnEdit.FlatStyle = FlatStyle.Flat;
        btnEdit.Click += BtnEdit_Click;

        btnDelete.Text = "✕ Eliminar";
        btnDelete.Location = new System.Drawing.Point(232, 60);
        btnDelete.Size = new System.Drawing.Size(110, 34);
        btnDelete.FlatStyle = FlatStyle.Flat;
        btnDelete.ForeColor = System.Drawing.Color.FromArgb(211, 47, 47);
        btnDelete.Click += BtnDelete_Click;

        dgvClients.Location = new System.Drawing.Point(0, 110);
        dgvClients.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        dgvClients.Height = 480;
        dgvClients.ReadOnly = true;
        dgvClients.AllowUserToAddRows = false;
        dgvClients.AllowUserToDeleteRows = false;
        dgvClients.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dgvClients.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dgvClients.BorderStyle = BorderStyle.None;
        dgvClients.RowHeadersVisible = false;
        dgvClients.BackgroundColor = System.Drawing.Color.White;
        dgvClients.Font = new System.Drawing.Font("Segoe UI", 10F);
        dgvClients.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);

        this.Controls.Add(lblTitle);
        this.Controls.Add(btnNew);
        this.Controls.Add(btnEdit);
        this.Controls.Add(btnDelete);
        this.Controls.Add(dgvClients);
        this.Dock = DockStyle.Fill;
        ResumeLayout(false);
    }

    private Label lblTitle;
    private Button btnNew;
    private Button btnEdit;
    private Button btnDelete;
    private DataGridView dgvClients;
}