namespace RecurrentPayments.UI.Views;

partial class ContractsView
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
        dgvContracts = new DataGridView();
        ((System.ComponentModel.ISupportInitialize)dgvContracts).BeginInit();
        SuspendLayout();
        // 
        // lblTitle
        // 
        lblTitle.AutoSize = true;
        lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
        lblTitle.Location = new Point(16, 16);
        lblTitle.Name = "lblTitle";
        lblTitle.Size = new Size(167, 45);
        lblTitle.TabIndex = 0;
        lblTitle.Text = "Contratos";
        // 
        // btnNew
        // 
        btnNew.BackColor = Color.FromArgb(25, 118, 210);
        btnNew.FlatAppearance.BorderSize = 0;
        btnNew.FlatStyle = FlatStyle.Flat;
        btnNew.ForeColor = Color.White;
        btnNew.Location = new Point(16, 60);
        btnNew.Name = "btnNew";
        btnNew.Size = new Size(100, 34);
        btnNew.TabIndex = 1;
        btnNew.Text = "＋ Nuevo";
        btnNew.UseVisualStyleBackColor = false;
        btnNew.Click += BtnNew_Click;
        // 
        // btnEdit
        // 
        btnEdit.FlatStyle = FlatStyle.Flat;
        btnEdit.Location = new Point(124, 60);
        btnEdit.Name = "btnEdit";
        btnEdit.Size = new Size(100, 34);
        btnEdit.TabIndex = 2;
        btnEdit.Text = "✎ Editar";
        btnEdit.Click += BtnEdit_Click;
        // 
        // btnDelete
        // 
        btnDelete.FlatStyle = FlatStyle.Flat;
        btnDelete.ForeColor = Color.FromArgb(211, 47, 47);
        btnDelete.Location = new Point(232, 60);
        btnDelete.Name = "btnDelete";
        btnDelete.Size = new Size(110, 34);
        btnDelete.TabIndex = 3;
        btnDelete.Text = "✕ Eliminar";
        btnDelete.Click += BtnDelete_Click;
        // 
        // dgvContracts
        // 
        dgvContracts.AllowUserToAddRows = false;
        dgvContracts.AllowUserToDeleteRows = false;
        dgvContracts.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        dgvContracts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dgvContracts.BackgroundColor = Color.White;
        dgvContracts.BorderStyle = BorderStyle.None;
        dgvContracts.ColumnHeadersHeight = 34;
        dgvContracts.Font = new Font("Segoe UI", 10F);
        dgvContracts.Location = new Point(0, 110);
        dgvContracts.Name = "dgvContracts";
        dgvContracts.ReadOnly = true;
        dgvContracts.RowHeadersVisible = false;
        dgvContracts.RowHeadersWidth = 62;
        dgvContracts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dgvContracts.Size = new Size(1566, 893);
        dgvContracts.TabIndex = 4;
        // 
        // ContractsView
        // 
        Controls.Add(lblTitle);
        Controls.Add(btnNew);
        Controls.Add(btnEdit);
        Controls.Add(btnDelete);
        Controls.Add(dgvContracts);
        Name = "ContractsView";
        Size = new Size(1326, 413);
        ((System.ComponentModel.ISupportInitialize)dgvContracts).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    private Label lblTitle;
    private Button btnNew, btnEdit, btnDelete;
    private DataGridView dgvContracts;
}