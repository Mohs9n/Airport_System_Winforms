using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;

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
            string filename = FileNameTF.Text;
            if (filename == "")
            {
                MessageBox.Show("File name Must NOT be empyt!");
                return;
            }
            filename = $"{filename}.bin";
            try
            {
                using (FileStream fs = new FileStream(filename, FileMode.OpenOrCreate))
                {
                   #pragma warning disable SYSLIB0011
                    BinaryFormatter bf = new();
                    bf.Serialize(fs, Program.data);
                    #pragma warning restore SYSLIB0011
                }
               // string jsonString = JsonSerializer.Serialize(Program.data);
                //File.WriteAllText(filename, jsonString);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            CreateFileLocation(filename);
        }

        private void CreateFileLocation(string newFile)
        {
            string filename = "aport.json";
            try
            {
                string jsonString = JsonSerializer.Serialize(newFile);
                File.WriteAllText(filename, jsonString);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DeleteFile_Click(object sender, EventArgs e)
        {
            string currentPath = Directory.GetCurrentDirectory();

            string filename = FileNameTF.Text;
            if (filename == "")
            {
                MessageBox.Show("File name Must NOT be empyt!");
            }

            string fullPath = Path.Combine(currentPath, filename);

            if (File.Exists(fullPath))
            {
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
