using Airport_System.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Airport_System.Controls
{
    public partial class UserRegister : UserControl
    {
        public UserRegister()
        {
            InitializeComponent();
        }

        private void Register_Click(object sender, EventArgs e)
        {
            if (userEmailRTF.Text == ""
                || userPassRTF.Text == ""
                || userNameRTF.Text == ""
                || userPhoneRTF.Text == "")
            {
                MessageBox.Show("Data Fields must not be empty");
                return;
            }
            var email = userEmailRTF.Text;
            var user = Program.data.MainAirport.Users.Any(x => x.Email == email);
            if (user)
            {
                MessageBox.Show("This user already exists");
                return;
            }
            Random rng = new Random();
        newId:
            var newId = rng.Next();
            var chechId = Program.data.MainAirport.Users.Any(u => u.Id == newId);
            if (chechId)
                goto newId;

            var newUser = new User
            {
                Id = rng.Next(),
                Email = email,
                Name = userNameRTF.Text,
                Password = userPhoneRTF.Text,
                PhoneNumber = userPhoneRTF.Text,
            };
            Program.data.MainAirport.Users.Add(newUser);

            Main.LoggedInUser = newUser;
            Main.userName.Text = newUser.Name;
            Main.SaveData();
            Main.SwitchScreen(new BookFlight());
        }
    }
}
