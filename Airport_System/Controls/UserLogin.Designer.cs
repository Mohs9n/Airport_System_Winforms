namespace Airport_System.Controls
{
    partial class UserLogin
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
            userEmailTF = new TextBox();
            userPassTF = new TextBox();
            label1 = new Label();
            label2 = new Label();
            Login = new Button();
            linkLabel1 = new LinkLabel();
            SuspendLayout();
            // 
            // userEmailTF
            // 
            userEmailTF.Location = new Point(324, 122);
            userEmailTF.Name = "userEmailTF";
            userEmailTF.Size = new Size(165, 23);
            userEmailTF.TabIndex = 0;
            // 
            // userPassTF
            // 
            userPassTF.Location = new Point(324, 177);
            userPassTF.Name = "userPassTF";
            userPassTF.Size = new Size(165, 23);
            userPassTF.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(261, 125);
            label1.Name = "label1";
            label1.Size = new Size(36, 15);
            label1.TabIndex = 2;
            label1.Text = "Email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(261, 180);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 3;
            label2.Text = "Password";
            label2.Click += label2_Click;
            // 
            // Login
            // 
            Login.Location = new Point(366, 231);
            Login.Name = "Login";
            Login.Size = new Size(75, 23);
            Login.TabIndex = 4;
            Login.Text = "Login";
            Login.UseVisualStyleBackColor = true;
            Login.Click += Login_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(342, 270);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(129, 15);
            linkLabel1.TabIndex = 6;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Register a new account";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // UserLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(linkLabel1);
            Controls.Add(Login);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(userPassTF);
            Controls.Add(userEmailTF);
            Name = "UserLogin";
            Size = new Size(800, 423);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox userEmailTF;
        private TextBox userPassTF;
        private Label label1;
        private Label label2;
        private Button Login;
        private LinkLabel linkLabel1;
    }
}
