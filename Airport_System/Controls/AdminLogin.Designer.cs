namespace Airport_System.Controls
{
    partial class AdminLogin
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            adminLoginButton = new Button();
            adminEmail = new TextBox();
            adminPassword = new TextBox();
            label1 = new Label();
            label2 = new Label();
            fileSystemWatcher1 = new FileSystemWatcher();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).BeginInit();
            SuspendLayout();
            // 
            // adminLoginButton
            // 
            adminLoginButton.Location = new Point(360, 241);
            adminLoginButton.Name = "adminLoginButton";
            adminLoginButton.Size = new Size(75, 23);
            adminLoginButton.TabIndex = 0;
            adminLoginButton.Text = "Login";
            adminLoginButton.UseVisualStyleBackColor = true;
            adminLoginButton.Click += adminLoginButton_Click;
            // 
            // adminEmail
            // 
            adminEmail.Location = new Point(327, 132);
            adminEmail.Name = "adminEmail";
            adminEmail.Size = new Size(154, 23);
            adminEmail.TabIndex = 1;
            // 
            // adminPassword
            // 
            adminPassword.Location = new Point(327, 178);
            adminPassword.Name = "adminPassword";
            adminPassword.Size = new Size(154, 23);
            adminPassword.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(255, 135);
            label1.Name = "label1";
            label1.Size = new Size(36, 15);
            label1.TabIndex = 3;
            label1.Text = "Email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(253, 181);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 4;
            label2.Text = "Password";
            // 
            // fileSystemWatcher1
            // 
            fileSystemWatcher1.EnableRaisingEvents = true;
            fileSystemWatcher1.SynchronizingObject = this;
            // 
            // AdminLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(adminPassword);
            Controls.Add(adminEmail);
            Controls.Add(adminLoginButton);
            Name = "AdminLogin";
            Size = new Size(800, 423);
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button adminLoginButton;
        private TextBox adminEmail;
        private TextBox adminPassword;
        private Label label1;
        private Label label2;
        private FileSystemWatcher fileSystemWatcher1;
    }
}
