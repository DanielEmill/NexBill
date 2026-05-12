namespace RecurrentPayments.UI.Views;

partial class ContractForm
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
        lblClient = new Label();
        cmbClient = new ComboBox();
        lblAmount = new Label();
        txtAmount = new TextBox();
        lblFrequency = new Label();
        cmbFrequency = new ComboBox();
        lblNextBilling = new Label();
        dtpNextBilling = new DateTimePicker();
        btnSave = new Button();
        btnCancel = new Button();
        SuspendLayout();

        lblTitle.Text = "Contrato";
        lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
        lblTitle.Location = new System.Drawing.Point(20, 20);
        lblTitle.AutoSize = true;

        lblClient.Text = "Cliente *";
        lblClient.Location = new System.Drawing.Point(20, 70);
        lblClient.AutoSize = true;

        cmbClient.Location = new System.Drawing.Point(20, 90);
        cmbClient.Width = 360;
        cmbClient.DropDownStyle = ComboBoxStyle.DropDownList;

        lblAmount.Text = "Monto *";
        lblAmount.Location = new System.Drawing.Point(20, 130);
        lblAmount.AutoSize = true;

        txtAmount.Location = new System.Drawing.Point(20, 150);
        txtAmount.Width = 360;

        lblFrequency.Text = "Frecuencia *";
        lblFrequency.Location = new System.Drawing.Point(20, 190);
        lblFrequency.AutoSize = true;

        cmbFrequency.Location = new System.Drawing.Point(20, 210);
        cmbFrequency.Width = 360;
        cmbFrequency.DropDownStyle = ComboBoxStyle.DropDownList;

        lblNextBilling.Text = "Próxima fecha de factura *";
        lblNextBilling.Location = new System.Drawing.Point(20, 250);
        lblNextBilling.AutoSize = true;

        dtpNextBilling.Location = new System.Drawing.Point(20, 270);
        dtpNextBilling.Width = 360;
        dtpNextBilling.Format = DateTimePickerFormat.Short;

        btnSave.Text = "Guardar";
        btnSave.Location = new System.Drawing.Point(20, 320);
        btnSave.Size = new System.Drawing.Size(110, 36);
        btnSave.BackColor = System.Drawing.Color.FromArgb(25, 118, 210);
        btnSave.ForeColor = System.Drawing.Color.White;
        btnSave.FlatStyle = FlatStyle.Flat;
        btnSave.FlatAppearance.BorderSize = 0;
        btnSave.Click += BtnSave_Click;

        btnCancel.Text = "Cancelar";
        btnCancel.Location = new System.Drawing.Point(140, 320);
        btnCancel.Size = new System.Drawing.Size(110, 36);
        btnCancel.FlatStyle = FlatStyle.Flat;
        btnCancel.Click += BtnCancel_Click;

        this.Controls.Add(lblTitle);
        this.Controls.Add(lblClient);
        this.Controls.Add(cmbClient);
        this.Controls.Add(lblAmount);
        this.Controls.Add(txtAmount);
        this.Controls.Add(lblFrequency);
        this.Controls.Add(cmbFrequency);
        this.Controls.Add(lblNextBilling);
        this.Controls.Add(dtpNextBilling);
        this.Controls.Add(btnSave);
        this.Controls.Add(btnCancel);
        this.Size = new System.Drawing.Size(420, 410);
        this.StartPosition = FormStartPosition.CenterParent;
        this.MaximizeBox = false;
        this.MinimizeBox = false;
        this.BackColor = System.Drawing.Color.FromArgb(245, 245, 245);
        ResumeLayout(false);
    }

    private Label lblTitle, lblClient, lblAmount, lblFrequency, lblNextBilling;
    private ComboBox cmbClient, cmbFrequency;
    private TextBox txtAmount;
    private DateTimePicker dtpNextBilling;
    private Button btnSave, btnCancel;
}