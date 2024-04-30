using Airport_System.Entities;

namespace Airport_System.Controls
{
    public partial class FlightsControl : UserControl
    {
        public FlightsControl()
        {
            InitializeComponent();
            foreach (var plane in Program.data.MainAirport.Airplanes)
            {
                AirplanesCB.Items.Add(plane.Id);
            }
            //DepartmentTime.Format = DateTimePickerFormat.Time;
            //ArrivalTime.Format = DateTimePickerFormat.Time;
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void InsertFlight_Click(object sender, EventArgs e)
        {
            if (FlightNumberTF.Text!="" && AirplanesCB.Text != ""
                && DestinationAirportTF.Text != "")
            {
                MessageBox.Show($"FN: {FlightNumberTF.Text}\nAP: {AirplanesCB.Text}");
                var flight = new Flight
                {
                    FlightNumber = int.Parse(FlightNumberTF.Text),
                    From = Program.data.MainAirport,
                    To = Program.data.Airports.Find(a => a.AirportCode == DestinationAirportTF.Text)!,
                    Plane = Program.data.MainAirport.Airplanes.Find(p => p.Id == int.Parse(AirplanesCB.Text))!,
                    ArrivalTime = ArrivalTime.Value.Date,
                    DepartmentTime = DepartmentTime.Value.Date,

                };
                Program.data.MainAirport.Flights.Add(flight);
                Program.data.Airports.Find(a => a.AirportCode == DestinationAirportTF.Text)!.Flights.Add(flight);
                MessageBox.Show($"{Program.data.MainAirport.Flights.Count}");
            }
        }

        private void UpdateFlight_Click(object sender, EventArgs e)
        {

        }
    }
}
