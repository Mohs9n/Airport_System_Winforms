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
            SwitchScreen(new AdminHome());
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SwitchScreen(new AdminHome());
        }

        private void flightsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (LoggedInUser == null)
            {
                MessageBox.Show("You must login first to access this panel");
            }
            SwitchScreen(new FlightsControl());
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Main.SwitchScreen(new LoginChoose());
        }
    }
}
