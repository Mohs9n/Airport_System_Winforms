namespace Airport_System.Controls
{
    public partial class AdminLogin : UserControl
    {
        public AdminLogin()
        {
            InitializeComponent();
        }

        private void adminLoginButton_Click(object sender, EventArgs e)
        {
            var email = adminEmail.Text;
            var password = adminPassword.Text;
            if (
                email == Program.data.MainAirport.Adminstrator.Email && 
                 password == Program.data.MainAirport.Adminstrator.Password)
            {
                Main.LoggedInUser = Program.data.MainAirport.Adminstrator;
                Main.userName.Text = "Admin";
                Main.SwitchScreen(new AdminHome());
            }
            else
            {
                MessageBox.Show($"Wrong details: {email}, {password}");
            }
        }
    }
}
