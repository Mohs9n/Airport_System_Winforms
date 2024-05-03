using System;
using System.Collections.Generic;
using System.ComponentModel;
namespace Airport_System.Controls
{
    public partial class UserLogin : UserControl
    {
        public UserLogin()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Login_Click(object sender, EventArgs e)
        {
            if (userEmailTF.Text == "" || userPassTF.Text == "")
            {
                MessageBox.Show("Data must not be empty");
            }
            var email = userEmailTF.Text;
            var user = Program.data.MainAirport.Users.Find(u => u.Email == email);
            if (user == null)
            {
                MessageBox.Show("User does not exist");
                return;
            }
            if (user.Password != userPassTF.Text)
            {
                MessageBox.Show("Wrong password");
                return;
            }
            Main.LoggedInUser = user;
            Main.userName.Text = user.Name;
            Main.SwitchScreen(new BookFlight());
        }


        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Main.SwitchScreen(new UserRegister());
        }
    }
}
