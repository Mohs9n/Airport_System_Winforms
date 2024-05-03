namespace Airport_System.Controls
{
    partial class BookFlight
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
            myflowLayoutPanel = new FlowLayoutPanel();
            bookFlightbt = new Button();
            flightNumtf = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // myflowLayoutPanel
            // 
            myflowLayoutPanel.Location = new Point(201, 3);
            myflowLayoutPanel.Name = "myflowLayoutPanel";
            myflowLayoutPanel.Size = new Size(400, 300);
            myflowLayoutPanel.TabIndex = 0;
            // 
            // bookFlightbt
            // 
            bookFlightbt.Location = new Point(342, 350);
            bookFlightbt.Name = "bookFlightbt";
            bookFlightbt.Size = new Size(75, 23);
            bookFlightbt.TabIndex = 1;
            bookFlightbt.Text = "Book Flight";
            bookFlightbt.UseVisualStyleBackColor = true;
            bookFlightbt.Click += button1_Click;
            // 
            // flightNumtf
            // 
            flightNumtf.Location = new Point(331, 321);
            flightNumtf.Name = "flightNumtf";
            flightNumtf.Size = new Size(100, 23);
            flightNumtf.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(241, 324);
            label1.Name = "label1";
            label1.Size = new Size(84, 15);
            label1.TabIndex = 3;
            label1.Text = "Flight Number";
            // 
            // BookFlight
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label1);
            Controls.Add(flightNumtf);
            Controls.Add(bookFlightbt);
            Controls.Add(myflowLayoutPanel);
            Name = "BookFlight";
            Size = new Size(800, 423);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel myflowLayoutPanel;
        private Button bookFlightbt;
        private TextBox flightNumtf;
        private Label label1;
    }
}
