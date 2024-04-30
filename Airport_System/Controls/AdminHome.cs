namespace Airport_System.Controls
{
    public partial class AdminHome : UserControl
    {
        public AdminHome()
        {
            InitializeComponent();
        }

        private void CreateFile_Click(object sender, EventArgs e)
        {
            // Get the current path
            string currentPath = Directory.GetCurrentDirectory();

            // Define the filename
            string filename = FileNameTF.Text;

            // Create the full path
            string fullPath = Path.Combine(currentPath, filename);

            // Check if the file exists
            if (!File.Exists(fullPath))
            {
                // Create the file
                try
                {
                    File.Create(fullPath).Close();
                    FileErrorLabel.Text = "File Created";
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error creating file: " + ex.Message);
                    FileErrorLabel.Text = ex.Message;
                }
            }
            else
            {
                FileErrorLabel.Text = "File Exists";
            }
        }

        private void DeleteFile_Click(object sender, EventArgs e)
        {
            // Get the current path
            string currentPath = Directory.GetCurrentDirectory();

            // Define the filename
            string filename = FileNameTF.Text;

            // Create the full path
            string fullPath = Path.Combine(currentPath, filename);

            // Check if the file exists
            if (File.Exists(fullPath))
            {
                // Create the file
                try
                {
                    File.Delete(fullPath);
                    FileErrorLabel.Text = "File deleted";
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error Deleting file: " + ex.Message);
                    FileErrorLabel.Text = ex.Message;
                }
            }
            else
            {
                FileErrorLabel.Text = "File Does not Exist";
            }
        }
    }
}
