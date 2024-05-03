namespace Airport_System.Controls
{
    partial class LoginChoose
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
            GoToAdminLogin = new Button();
            GoToUserLogin = new Button();
            SuspendLayout();
            // 
            // GoToAdminLogin
            // 
            GoToAdminLogin.Location = new Point(342, 153);
            GoToAdminLogin.Name = "GoToAdminLogin";
            GoToAdminLogin.Size = new Size(172, 23);
            GoToAdminLogin.TabIndex = 0;
            GoToAdminLogin.Text = "Login As Adminstrator";
            GoToAdminLogin.UseVisualStyleBackColor = true;
            GoToAdminLogin.Click += GoToAdminLogin_Click;
            // 
            // GoToUserLogin
            // 
            GoToUserLogin.Location = new Point(342, 209);
            GoToUserLogin.Name = "GoToUserLogin";
            GoToUserLogin.Size = new Size(172, 23);
            GoToUserLogin.TabIndex = 1;
            GoToUserLogin.Text = "Login As User";
            GoToUserLogin.UseVisualStyleBackColor = true;
            GoToUserLogin.Click += GoToUserLogin_Click;
            // 
            // LoginChoose
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(GoToUserLogin);
            Controls.Add(GoToAdminLogin);
            Name = "LoginChoose";
            Size = new Size(800, 423);
            ResumeLayout(false);
        }

        #endregion

        private Button GoToAdminLogin;
        private Button GoToUserLogin;
    }
}
