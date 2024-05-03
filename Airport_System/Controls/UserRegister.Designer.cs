namespace Airport_System.Controls
{
    partial class UserRegister
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
            userEmailRTF = new TextBox();
            userPassRTF = new TextBox();
            userNameRTF = new TextBox();
            userPhoneRTF = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            Register = new Button();
            label5 = new Label();
            SuspendLayout();
            // 
            // userEmailRTF
            // 
            userEmailRTF.Location = new Point(340, 100);
            userEmailRTF.Name = "userEmailRTF";
            userEmailRTF.Size = new Size(145, 23);
            userEmailRTF.TabIndex = 0;
            // 
            // userPassRTF
            // 
            userPassRTF.Location = new Point(340, 143);
            userPassRTF.Name = "userPassRTF";
            userPassRTF.Size = new Size(145, 23);
            userPassRTF.TabIndex = 1;
            // 
            // userNameRTF
            // 
            userNameRTF.Location = new Point(340, 191);
            userNameRTF.Name = "userNameRTF";
            userNameRTF.Size = new Size(145, 23);
            userNameRTF.TabIndex = 2;
            // 
            // userPhoneRTF
            // 
            userPhoneRTF.Location = new Point(340, 242);
            userPhoneRTF.Name = "userPhoneRTF";
            userPhoneRTF.Size = new Size(145, 23);
            userPhoneRTF.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(268, 103);
            label1.Name = "label1";
            label1.Size = new Size(36, 15);
            label1.TabIndex = 4;
            label1.Text = "Email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(268, 146);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 5;
            label2.Text = "Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(268, 194);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 6;
            label3.Text = "Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(268, 245);
            label4.Name = "label4";
            label4.Size = new Size(41, 15);
            label4.TabIndex = 7;
            label4.Text = "Phone";
            // 
            // Register
            // 
            Register.Location = new Point(366, 291);
            Register.Name = "Register";
            Register.Size = new Size(75, 23);
            Register.TabIndex = 8;
            Register.Text = "Register";
            Register.UseVisualStyleBackColor = true;
            Register.Click += Register_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(353, 53);
            label5.Name = "label5";
            label5.Size = new Size(109, 15);
            label5.TabIndex = 9;
            label5.Text = "Register a new User";
            // 
            // UserRegister
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label5);
            Controls.Add(Register);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(userPhoneRTF);
            Controls.Add(userNameRTF);
            Controls.Add(userPassRTF);
            Controls.Add(userEmailRTF);
            Name = "UserRegister";
            Size = new Size(800, 423);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox userEmailRTF;
        private TextBox userPassRTF;
        private TextBox userNameRTF;
        private TextBox userPhoneRTF;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button Register;
        private Label label5;
    }
}
