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
    public partial class LoginChoose : UserControl
    {
        public LoginChoose()
        {
            InitializeComponent();
        }

        private void GoToAdminLogin_Click(object sender, EventArgs e)
        {
            Main.SwitchScreen(new AdminLogin());
        }

        private void GoToUserLogin_Click(object sender, EventArgs e)
        {
            Main.SwitchScreen(new UserLogin());
        }
    }
}
