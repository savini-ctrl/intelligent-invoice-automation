namespace ContosoLegacyFinance;

public partial class LoginForm : Form
{
    public LoginForm()
    {
        InitializeComponent();
    }

    private void btnLogin_Click(object sender, EventArgs e)
    {
        string username = txtUsername.Text.Trim();
        string password = txtPassword.Text;
        // Validate the username and password

        if (username == "admin" && password == "Password123")
        {
            lblStatus.Text = "Login successful.";
        }
        else
        {
            lblStatus.Text = "ERROR: Invalid username or password.";
        }
    }
}

