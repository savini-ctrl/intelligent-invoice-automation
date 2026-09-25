namespace ContosoLegacyFinance;

partial class LoginForm
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        lblTitle = new Label();
        lblUsername = new Label();
        lblPassword = new Label();
        txtUsername = new TextBox();
        txtPassword = new TextBox();
        btnLogin = new Button();
        lblStatus = new Label();
        SuspendLayout();
        // 
        // lblTitle
        // 
        lblTitle.AutoSize = true;
        lblTitle.Location = new Point(115, 77);
        lblTitle.Name = "lblTitle";
        lblTitle.Size = new Size(198, 20);
        lblTitle.TabIndex = 0;
        lblTitle.Text = "CONTOSO FINANCE SYSTEM";
        // 
        // lblUsername
        // 
        lblUsername.AutoSize = true;
        lblUsername.Location = new Point(59, 153);
        lblUsername.Name = "lblUsername";
        lblUsername.Size = new Size(75, 20);
        lblUsername.TabIndex = 1;
        lblUsername.Text = "Username";
        // 
        // lblPassword
        // 
        lblPassword.AutoSize = true;
        lblPassword.Location = new Point(60, 182);
        lblPassword.Name = "lblPassword";
        lblPassword.Size = new Size(70, 20);
        lblPassword.TabIndex = 2;
        lblPassword.Text = "Password";
        // 
        // txtUsername
        // 
        txtUsername.Location = new Point(172, 155);
        txtUsername.Name = "txtUsername";
        txtUsername.Size = new Size(125, 27);
        txtUsername.TabIndex = 4;
        // 
        // txtPassword
        // 
        txtPassword.Location = new Point(174, 190);
        txtPassword.Name = "txtPassword";
        txtPassword.Size = new Size(125, 27);
        txtPassword.TabIndex = 5;
        txtPassword.UseSystemPasswordChar = true;
        // 
        // btnLogin
        // 
        btnLogin.Location = new Point(159, 255);
        btnLogin.Name = "btnLogin";
        btnLogin.Size = new Size(94, 29);
        btnLogin.TabIndex = 6;
        btnLogin.Text = "Login";
        btnLogin.UseVisualStyleBackColor = true;
        btnLogin.Click += this.btnLogin_Click;
        // 
        // lblStatus
        // 
        lblStatus.Location = new Point(60, 296);
        lblStatus.MaximumSize = new Size(350, 40);
        lblStatus.Name = "lblStatus";
        lblStatus.Size = new Size(350, 40);
        lblStatus.TabIndex = 7;
        // 
        // LoginForm
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(482, 353);
        Controls.Add(lblStatus);
        Controls.Add(btnLogin);
        Controls.Add(txtPassword);
        Controls.Add(txtUsername);
        Controls.Add(lblPassword);
        Controls.Add(lblUsername);
        Controls.Add(lblTitle);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        MaximizeBox = false;
        Name = "LoginForm";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Contoso Finance System - Login";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label lblTitle;
    private Label lblUsername;
    private Label lblPassword;
    private TextBox txtUsername;
    private TextBox txtPassword;
    private Button btnLogin;
    private Label lblStatus;
}
