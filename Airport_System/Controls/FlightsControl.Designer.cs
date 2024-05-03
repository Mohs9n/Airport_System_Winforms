namespace Airport_System.Controls
{
    partial class FlightsControl
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
            InsertFlight = new Button();
            SearchFlight = new Button();
            UpdateFlight = new Button();
            FlightNumberTF = new TextBox();
            DepartmentTime = new DateTimePicker();
            ArrivalTime = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label5 = new Label();
            label6 = new Label();
            AirplanesCB = new ComboBox();
            DestinationAirportCB = new ComboBox();
            SuspendLayout();
            // 
            // InsertFlight
            // 
            InsertFlight.Location = new Point(665, 66);
            InsertFlight.Name = "InsertFlight";
            InsertFlight.Size = new Size(75, 23);
            InsertFlight.TabIndex = 0;
            InsertFlight.Text = "Insert";
            InsertFlight.UseVisualStyleBackColor = true;
            InsertFlight.Click += InsertFlight_Click;
            // 
            // SearchFlight
            // 
            SearchFlight.Location = new Point(665, 114);
            SearchFlight.Name = "SearchFlight";
            SearchFlight.Size = new Size(75, 23);
            SearchFlight.TabIndex = 1;
            SearchFlight.Text = "Search";
            SearchFlight.UseVisualStyleBackColor = true;
            SearchFlight.Click += SearchFlight_Click;
            // 
            // UpdateFlight
            // 
            UpdateFlight.Location = new Point(665, 162);
            UpdateFlight.Name = "UpdateFlight";
            UpdateFlight.Size = new Size(75, 23);
            UpdateFlight.TabIndex = 2;
            UpdateFlight.Text = "Update";
            UpdateFlight.UseVisualStyleBackColor = true;
            UpdateFlight.Click += UpdateFlight_Click;
            // 
            // FlightNumberTF
            // 
            FlightNumberTF.Location = new Point(213, 66);
            FlightNumberTF.Name = "FlightNumberTF";
            FlightNumberTF.Size = new Size(100, 23);
            FlightNumberTF.TabIndex = 3;
            // 
            // DepartmentTime
            // 
            DepartmentTime.CustomFormat = "dd/MM/yyyy, HH:mm";
            DepartmentTime.Format = DateTimePickerFormat.Custom;
            DepartmentTime.Location = new Point(213, 210);
            DepartmentTime.Name = "DepartmentTime";
            DepartmentTime.Size = new Size(200, 23);
            DepartmentTime.TabIndex = 6;
            // 
            // ArrivalTime
            // 
            ArrivalTime.CustomFormat = "dd/MM/yyyy, HH:mm";
            ArrivalTime.Format = DateTimePickerFormat.Custom;
            ArrivalTime.Location = new Point(213, 250);
            ArrivalTime.Name = "ArrivalTime";
            ArrivalTime.Size = new Size(200, 23);
            ArrivalTime.TabIndex = 7;
            ArrivalTime.ValueChanged += dateTimePicker2_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(104, 70);
            label1.Name = "label1";
            label1.Size = new Size(84, 15);
            label1.TabIndex = 9;
            label1.Text = "Flight Number";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(104, 118);
            label2.Name = "label2";
            label2.Size = new Size(107, 15);
            label2.TabIndex = 10;
            label2.Text = "Destination Airport";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(104, 166);
            label3.Name = "label3";
            label3.Size = new Size(49, 15);
            label3.TabIndex = 11;
            label3.Text = "Plane Id";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(104, 216);
            label5.Name = "label5";
            label5.Size = new Size(99, 15);
            label5.TabIndex = 13;
            label5.Text = "Department Time";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(104, 258);
            label6.Name = "label6";
            label6.Size = new Size(70, 15);
            label6.TabIndex = 14;
            label6.Text = "Arrival Time";
            label6.Click += label6_Click;
            // 
            // AirplanesCB
            // 
            AirplanesCB.DropDownStyle = ComboBoxStyle.DropDownList;
            AirplanesCB.FormattingEnabled = true;
            AirplanesCB.Location = new Point(213, 163);
            AirplanesCB.Name = "AirplanesCB";
            AirplanesCB.Size = new Size(121, 23);
            AirplanesCB.TabIndex = 15;
            // 
            // DestinationAirportCB
            // 
            DestinationAirportCB.DropDownStyle = ComboBoxStyle.DropDownList;
            DestinationAirportCB.FormattingEnabled = true;
            DestinationAirportCB.Location = new Point(213, 115);
            DestinationAirportCB.Name = "DestinationAirportCB";
            DestinationAirportCB.Size = new Size(121, 23);
            DestinationAirportCB.TabIndex = 16;
            // 
            // FlightsControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(DestinationAirportCB);
            Controls.Add(AirplanesCB);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(ArrivalTime);
            Controls.Add(DepartmentTime);
            Controls.Add(FlightNumberTF);
            Controls.Add(UpdateFlight);
            Controls.Add(SearchFlight);
            Controls.Add(InsertFlight);
            Name = "FlightsControl";
            Size = new Size(800, 423);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button InsertFlight;
        private Button SearchFlight;
        private Button UpdateFlight;
        private TextBox FlightNumberTF;
        private DateTimePicker DepartmentTime;
        private DateTimePicker ArrivalTime;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label5;
        private Label label6;
        private ComboBox AirplanesCB;
        private ComboBox DestinationAirportCB;
    }
}
