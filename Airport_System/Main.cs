using Airport_System.Controls;
using Airport_System.Entities;
using System.Text.Json;
using System.Windows.Forms.Design;

namespace Airport_System
{
    public partial class Main : Form
    {
        public static User? LoggedInUser { get; set; }
        public static string CurrentFileName = string.Empty;
        public Main()
        {
            InitializeComponent();
            mainPanel.Controls.Add(new LoginChoose());
            //SwitchScreen(new FlightsControl());
            if (File.Exists("aport.json"))
            {
                string jsonString = File.ReadAllText("aport.json");
                string filename = JsonSerializer.Deserialize<string>(jsonString)!;
                CurrentFileName = filename;

                if (File.Exists(filename))
                {
                    string dataJsonString = File.ReadAllText(filename);
                    Program.data = JsonSerializer.Deserialize<Data>(dataJsonString)!;
                }
            }
        }

        public static void SaveData()
        {
            if (CurrentFileName == "")
            {
                MessageBox.Show("File name Must NOT be empyt!");
                return;
            }
            try
            {
                string jsonString = JsonSerializer.Serialize(Program.data);
                File.WriteAllText(CurrentFileName, jsonString);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static void SwitchScreen(UserControl targetControl)
        {
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(targetControl);
            targetControl.Visible = true;
        }

        private void createToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (LoggedInUser == null ||
                LoggedInUser!.Email != Program.data.MainAirport.Adminstrator.Email)
            {
                MessageBox.Show("You must login as admin to access this panel");
                return;
            }
            SwitchScreen(new AdminHome());
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (LoggedInUser == null ||
                LoggedInUser != Program.data.MainAirport.Adminstrator)
            {
                MessageBox.Show("You must login as admin to access this panel");
                return;
            }
            SwitchScreen(new AdminHome());
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Main.SwitchScreen(new LoginChoose());
        }

        private void scheduleFlightsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (LoggedInUser == null ||
                LoggedInUser != Program.data.MainAirport.Adminstrator)
            {
                MessageBox.Show("You must login as admin to access this panel");
                return;
            }
            SwitchScreen(new FlightsControl());
        }

        private void bookFlightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (LoggedInUser == null ||
                Program.data.MainAirport.Users.Any(u => u.Email == LoggedInUser.Email))
            {
                MessageBox.Show("You must login as a user to access this panel");
                return;
            }
            SwitchScreen(new BookFlight());
        }
    }
}
