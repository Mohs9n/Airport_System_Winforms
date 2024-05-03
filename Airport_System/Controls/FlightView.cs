using Airport_System.Entities;

namespace Airport_System.Controls
{
    public partial class FlightView : UserControl
    {
        private readonly Flight _flight;
        public FlightView(Flight flight)
        {
            _flight = flight;
            InitializeComponent();
            var FromAP = Program.data.MainAirport;
            var ToAP = Program.data.Airports.Find(a => a.AirportCode == _flight.ToCode);
            FlightNumlbl.Text = _flight.FlightNumber.ToString();
            Fromlbl.Text = $"{FromAP!.Country.Name},{FromAP!.City.Name} {FromAP.Name}";
            Tolbl.Text = $"{ToAP!.Country.Name},{ToAP!.City.Name} {ToAP.Name}";
            Departmentlbl.Text = _flight.DepartmentTime.ToString();
            Arrivinglbl.Text = _flight.ArrivalTime.ToString();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Tolbl_Click(object sender, EventArgs e)
        {

        }

        private void FlightView_Load(object sender, EventArgs e)
        {

        }
    }
}