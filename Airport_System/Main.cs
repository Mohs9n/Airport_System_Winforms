using Airport_System.Controls;

namespace Airport_System
{
    public partial class Main : Form
    {
        LoginChoose loginChoose = new();
        public Main()
        {
            InitializeComponent();
            mainPanel.Controls.Add(loginChoose);
            SwitchScreen(new FlightsControl());
        }


        public static void SwitchScreen(UserControl targetControl)
        {
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(targetControl);
            targetControl.Visible = true;
        }
    }
}
