namespace Airport_System.Controls
{
    partial class AdminHome
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
            CreateFile = new Button();
            FileNameTF = new TextBox();
            DeleteFile = new Button();
            label1 = new Label();
            FileErrorLabel = new Label();
            SuspendLayout();
            // 
            // CreateFile
            // 
            CreateFile.Location = new Point(336, 302);
            CreateFile.Margin = new Padding(3, 4, 3, 4);
            CreateFile.Name = "CreateFile";
            CreateFile.Size = new Size(86, 31);
            CreateFile.TabIndex = 0;
            CreateFile.Text = "Create";
            CreateFile.UseVisualStyleBackColor = true;
            CreateFile.Click += CreateFile_Click;
            // 
            // FileNameTF
            // 
            FileNameTF.Location = new Point(336, 215);
            FileNameTF.Margin = new Padding(3, 4, 3, 4);
            FileNameTF.Name = "FileNameTF";
            FileNameTF.Size = new Size(241, 27);
            FileNameTF.TabIndex = 1;
            // 
            // DeleteFile
            // 
            DeleteFile.Location = new Point(492, 302);
            DeleteFile.Margin = new Padding(3, 4, 3, 4);
            DeleteFile.Name = "DeleteFile";
            DeleteFile.Size = new Size(86, 31);
            DeleteFile.TabIndex = 2;
            DeleteFile.Text = "Delete";
            DeleteFile.UseVisualStyleBackColor = true;
            DeleteFile.Click += DeleteFile_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(248, 219);
            label1.Name = "label1";
            label1.Size = new Size(76, 20);
            label1.TabIndex = 3;
            label1.Text = "File Name";
            // 
            // FileErrorLabel
            // 
            FileErrorLabel.AutoSize = true;
            FileErrorLabel.Location = new Point(635, 219);
            FileErrorLabel.Name = "FileErrorLabel";
            FileErrorLabel.Size = new Size(0, 20);
            FileErrorLabel.TabIndex = 4;
            // 
            // AdminHome
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(FileErrorLabel);
            Controls.Add(label1);
            Controls.Add(DeleteFile);
            Controls.Add(FileNameTF);
            Controls.Add(CreateFile);
            Margin = new Padding(3, 4, 3, 4);
            Name = "AdminHome";
            Size = new Size(914, 564);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button CreateFile;
        private TextBox FileNameTF;
        private Button DeleteFile;
        private Label label1;
        private Label FileErrorLabel;
    }
}
