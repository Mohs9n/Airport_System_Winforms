namespace Airport_System
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            helloToolStripMenuItem = new ToolStripMenuItem();
            createToolStripMenuItem = new ToolStripMenuItem();
            deleteToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1 = new MenuStrip();
            flightsToolStripMenuItem = new ToolStripMenuItem();
            loginToolStripMenuItem = new ToolStripMenuItem();
            mainPanel = new Panel();
            userName = new Label();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // helloToolStripMenuItem
            // 
            helloToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { createToolStripMenuItem, deleteToolStripMenuItem });
            helloToolStripMenuItem.Name = "helloToolStripMenuItem";
            helloToolStripMenuItem.Size = new Size(37, 20);
            helloToolStripMenuItem.Text = "File";
            // 
            // createToolStripMenuItem
            // 
            createToolStripMenuItem.Name = "createToolStripMenuItem";
            createToolStripMenuItem.Size = new Size(108, 22);
            createToolStripMenuItem.Text = "Create";
            createToolStripMenuItem.Click += createToolStripMenuItem_Click;
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.Size = new Size(108, 22);
            deleteToolStripMenuItem.Text = "Delete";
            deleteToolStripMenuItem.Click += deleteToolStripMenuItem_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Dock = DockStyle.None;
            menuStrip1.Items.AddRange(new ToolStripItem[] { helloToolStripMenuItem, flightsToolStripMenuItem, loginToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(148, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // flightsToolStripMenuItem
            // 
            flightsToolStripMenuItem.Name = "flightsToolStripMenuItem";
            flightsToolStripMenuItem.Size = new Size(54, 20);
            flightsToolStripMenuItem.Text = "Flights";
            flightsToolStripMenuItem.Click += flightsToolStripMenuItem_Click;
            // 
            // loginToolStripMenuItem
            // 
            loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            loginToolStripMenuItem.Size = new Size(49, 20);
            loginToolStripMenuItem.Text = "Login";
            loginToolStripMenuItem.Click += loginToolStripMenuItem_Click;
            // 
            // mainPanel
            // 
            mainPanel.Location = new Point(0, 27);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(800, 423);
            mainPanel.TabIndex = 1;
            // 
            // userName
            // 
            userName.AutoSize = true;
            userName.Location = new Point(650, 9);
            userName.Name = "userName";
            userName.Size = new Size(0, 15);
            userName.TabIndex = 2;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(userName);
            Controls.Add(mainPanel);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Main";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStripMenuItem helloToolStripMenuItem;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem createToolStripMenuItem;
        private ToolStripMenuItem deleteToolStripMenuItem;
        private ToolStripMenuItem flightsToolStripMenuItem;
        private ToolStripMenuItem loginToolStripMenuItem;
        private static Panel mainPanel;
        public static Label userName;
    }
}
