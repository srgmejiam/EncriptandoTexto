namespace EncriptandoTexto;

public partial class Principal : Form
{
    private TextBox txtTexto = new();
    private Label lbltxtTexto = new();
    private Button btnEncriptar = new();
    private Button btnDesencriptar = new();
    public Principal()
    {
        SuspendLayout();
        Text = "Principal";
        ClientSize = new Size(400, 300);
        MaximizeBox = false;
        StartPosition = FormStartPosition.CenterScreen;
        FormBorderStyle = FormBorderStyle.FixedToolWindow;

        //Controles
        lbltxtTexto.Name = "lbltxtTexto";
        lbltxtTexto.Text = "Texto";
        lbltxtTexto.Location = new Point(10, 10);
        lbltxtTexto.ForeColor = Color.Blue;
        Controls.Add(lbltxtTexto);

        txtTexto.Location = new Point(10, 35);
        txtTexto.Size = new Size(350, 30);
        txtTexto.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        txtTexto.Name = "txtTexto";
        Controls.Add(txtTexto);

        btnEncriptar.Text = "Encriptar";
        btnEncriptar.Name = "btnEncriptar";
        btnEncriptar.Location = new Point(10, 65);
        btnEncriptar.Size = new Size(110, 40);
        btnEncriptar.Click += Click_btnEncriptar;
        Controls.Add(btnEncriptar);

        btnDesencriptar.Text = "Desencriptar";
        btnDesencriptar.Name = "btnDesencriptar";
        btnDesencriptar.Location = new Point(120, 65);
        btnDesencriptar.Size = new Size(110, 40);
        btnDesencriptar.Click += Click_btnDesencriptar;
        Controls.Add(btnDesencriptar);

        ResumeLayout(false);
        PerformLayout();
    }
    private void Click_btnEncriptar(object? sender, EventArgs e)
    {
        string textToEncrypt = txtTexto.Text;
        string encryptedText = Encripty.Encrypt(txtTexto.Text);
        txtTexto.Text = encryptedText;
    }
    private void Click_btnDesencriptar(object? sender, EventArgs e)
    {
       string encryptedText = txtTexto.Text;
            string decryptedText = Encripty.Decrypt(encryptedText);
            txtTexto.Text = decryptedText;
    }
}

