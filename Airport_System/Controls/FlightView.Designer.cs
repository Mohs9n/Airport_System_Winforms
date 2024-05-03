namespace Airport_System.Controls
{
    partial class FlightView
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            Fromlbl = new Label();
            Tolbl = new Label();
            Departmentlbl = new Label();
            Arrivinglbl = new Label();
            label5 = new Label();
            FlightNumlbl = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 36);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 0;
            label1.Text = "From:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 63);
            label2.Name = "label2";
            label2.Size = new Size(22, 15);
            label2.TabIndex = 1;
            label2.Text = "To:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(13, 92);
            label3.Name = "label3";
            label3.Size = new Size(62, 15);
            label3.TabIndex = 2;
            label3.Text = "Departing:";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(13, 119);
            label4.Name = "label4";
            label4.Size = new Size(52, 15);
            label4.TabIndex = 3;
            label4.Text = "Arriving:";
            // 
            // Fromlbl
            // 
            Fromlbl.AutoSize = true;
            Fromlbl.Location = new Point(103, 36);
            Fromlbl.Name = "Fromlbl";
            Fromlbl.Size = new Size(19, 15);
            Fromlbl.TabIndex = 4;
            Fromlbl.Text = "kk";
            // 
            // Tolbl
            // 
            Tolbl.AutoSize = true;
            Tolbl.Location = new Point(105, 63);
            Tolbl.Name = "Tolbl";
            Tolbl.Size = new Size(19, 15);
            Tolbl.TabIndex = 5;
            Tolbl.Text = "ee";
            Tolbl.Click += Tolbl_Click;
            // 
            // Departmentlbl
            // 
            Departmentlbl.AutoSize = true;
            Departmentlbl.Location = new Point(103, 92);
            Departmentlbl.Name = "Departmentlbl";
            Departmentlbl.Size = new Size(21, 15);
            Departmentlbl.TabIndex = 6;
            Departmentlbl.Text = "bb";
            // 
            // Arrivinglbl
            // 
            Arrivinglbl.AutoSize = true;
            Arrivinglbl.Location = new Point(103, 119);
            Arrivinglbl.Name = "Arrivinglbl";
            Arrivinglbl.Size = new Size(19, 15);
            Arrivinglbl.TabIndex = 7;
            Arrivinglbl.Text = "aa";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(13, 9);
            label5.Name = "label5";
            label5.Size = new Size(84, 15);
            label5.TabIndex = 8;
            label5.Text = "FlightNumber:";
            // 
            // FlightNumlbl
            // 
            FlightNumlbl.AutoSize = true;
            FlightNumlbl.Location = new Point(105, 9);
            FlightNumlbl.Name = "FlightNumlbl";
            FlightNumlbl.Size = new Size(21, 15);
            FlightNumlbl.TabIndex = 9;
            FlightNumlbl.Text = "uu";
            // 
            // FlightView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(FlightNumlbl);
            Controls.Add(label5);
            Controls.Add(Arrivinglbl);
            Controls.Add(Departmentlbl);
            Controls.Add(Tolbl);
            Controls.Add(Fromlbl);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FlightView";
            Size = new Size(300, 150);
            Load += FlightView_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label Fromlbl;
        private Label Tolbl;
        private Label Departmentlbl;
        private Label Arrivinglbl;
        private Label label5;
        private Label FlightNumlbl;
    }
}
