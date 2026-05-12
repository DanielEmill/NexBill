namespace RecurrentPayments.UI.Views;

partial class ClientForm
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
        txtName = new TextBox();
        txtPhone = new TextBox();
        txtEmail = new TextBox();
        lblName = new Label();
        lblPhone = new Label();
        lblEmail = new Label();
        btnSave = new Button();
        btnCancel = new Button();
        SuspendLayout();

        lblTitle.Text = "Cliente";
        lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
        lblTitle.Location = new System.Drawing.Point(20, 20);
        lblTitle.AutoSize = true;

        lblName.Text = "Nombre *";
        lblName.Location = new System.Drawing.Point(20, 70);
        lblName.AutoSize = true;

        txtName.Location = new System.Drawing.Point(20, 90);
        txtName.Width = 360;

        lblPhone.Text = "Teléfono";
        lblPhone.Location = new System.Drawing.Point(20, 130);
        lblPhone.AutoSize = true;

        txtPhone.Location = new System.Drawing.Point(20, 150);
        txtPhone.Width = 360;

        lblEmail.Text = "Email";
        lblEmail.Location = new System.Drawing.Point(20, 190);
        lblEmail.AutoSize = true;

        txtEmail.Location = new System.Drawing.Point(20, 210);
        txtEmail.Width = 360;

        btnSave.Text = "Guardar";
        btnSave.Location = new System.Drawing.Point(20, 270);
        btnSave.Size = new System.Drawing.Size(110, 36);
        btnSave.BackColor = System.Drawing.Color.FromArgb(25, 118, 210);
        btnSave.ForeColor = System.Drawing.Color.White;
        btnSave.FlatStyle = FlatStyle.Flat;
        btnSave.FlatAppearance.BorderSize = 0;
        btnSave.Click += BtnSave_Click;

        btnCancel.Text = "Cancelar";
        btnCancel.Location = new System.Drawing.Point(140, 270);
        btnCancel.Size = new System.Drawing.Size(110, 36);
        btnCancel.FlatStyle = FlatStyle.Flat;
        btnCancel.Click += BtnCancel_Click;

        this.Controls.Add(lblTitle);
        this.Controls.Add(lblName);
        this.Controls.Add(txtName);
        this.Controls.Add(lblPhone);
        this.Controls.Add(txtPhone);
        this.Controls.Add(lblEmail);
        this.Controls.Add(txtEmail);
        this.Controls.Add(btnSave);
        this.Controls.Add(btnCancel);
        this.Size = new System.Drawing.Size(420, 360);
        this.StartPosition = FormStartPosition.CenterParent;
        this.MaximizeBox = false;
        this.MinimizeBox = false;
        this.BackColor = System.Drawing.Color.FromArgb(245, 245, 245);
        ResumeLayout(false);
    }

    private Label lblTitle;
    private Label lblName, lblPhone, lblEmail;
    private TextBox txtName, txtPhone, txtEmail;
    private Button btnSave, btnCancel;
}