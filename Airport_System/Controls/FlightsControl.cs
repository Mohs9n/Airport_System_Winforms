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
            foreach (var airport in Program.data.Airports)
            {
                DestinationAirportCB.Items.Add(airport.AirportCode);
            }
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void InsertFlight_Click(object sender, EventArgs e)
        {
            if (FlightNumberTF.Text != "" && AirplanesCB.Text != ""
                && DestinationAirportCB.Text != "")
            {
                MessageBox.Show($"FN: {FlightNumberTF.Text}\nAP: {AirplanesCB.Text}");
                var flight = new Flight
                {
                    FlightNumber = int.Parse(FlightNumberTF.Text),
                    FromCode = Program.data.MainAirport.AirportCode,
                    ToCode = Program.data.Airports.Find(a => a.AirportCode == DestinationAirportCB.Text)!.AirportCode,
                    Plane = Program.data.MainAirport.Airplanes.Find(p => p.Id == int.Parse(AirplanesCB.Text))!,
                    ArrivalTime = ArrivalTime.Value,
                    DepartmentTime = DepartmentTime.Value,

                };
                Program.data.MainAirport.Flights.Add(flight);
                Program.data.Airports.Find(a => a.AirportCode == DestinationAirportCB.Text)!.Flights.Add(flight);
                Main.SaveData();
                MessageBox.Show($"{Program.data.MainAirport.Flights.Count}");
            }
        }

        private void UpdateFlight_Click(object sender, EventArgs e)
        {
            if (
                FlightNumberTF.Text != "" && AirplanesCB.Text != ""
                && DestinationAirportCB.Text != ""
            )
            {
                var flight = Program.data.MainAirport.Flights.Find(f => int.Parse(FlightNumberTF.Text) == f.FlightNumber);
                if (flight != null)
                {
                    flight.FlightNumber = int.Parse(FlightNumberTF.Text);
                    flight.FromCode = Program.data.MainAirport.AirportCode;
                    flight.ToCode = Program.data.Airports.Find(a => a.AirportCode == DestinationAirportCB.Text)!.AirportCode;
                    flight.Plane = Program.data.MainAirport.Airplanes.Find(p => p.Id == int.Parse(AirplanesCB.Text))!;
                    flight.ArrivalTime = ArrivalTime.Value;
                    flight.DepartmentTime = DepartmentTime.Value;
                    Main.SaveData();
                }
                else
                {
                    MessageBox.Show("Flight number does not exist");
                }
            }
        }

        private void SearchFlight_Click(object sender, EventArgs e)
        {
            var flight = Program.data.MainAirport.Flights.Find(f => int.Parse(FlightNumberTF.Text) == f.FlightNumber);
            if (flight != null)
            {
                DestinationAirportCB.Text = flight.ToCode;
                AirplanesCB.Text = flight.Plane.Id.ToString();
                DepartmentTime.Value = flight.DepartmentTime;
                ArrivalTime.Value = flight.ArrivalTime;
            }
            else
            {
                MessageBox.Show("Flight number does not exist");
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}