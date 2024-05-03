using Airport_System.Entities;

namespace Airport_System.Controls
{
    public partial class BookFlight : UserControl
    {
        public BookFlight()
        {
            InitializeComponent();
            myflowLayoutPanel.AutoScroll = true;
            myflowLayoutPanel.FlowDirection = FlowDirection.TopDown;
            myflowLayoutPanel.WrapContents = false; // Vertical rather than horizontal scrolling
            foreach (var flight in Program.data.MainAirport.Flights)
            {
                myflowLayoutPanel.Controls.Add(new FlightView(flight));
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var flightNum = flightNumtf.Text.Trim();
            if (flightNum=="")
            {
                MessageBox.Show("Id must be set");
                return;
            }
            var flight = Program.data.MainAirport.Flights
                .Find(f => f.FlightNumber == int.Parse(flightNum));
            if (flight == null)
            {
                MessageBox.Show("No Flight with that id");
                return;
            }
            if (Main.LoggedInUser == null)
            {
                MessageBox.Show("You need to be logged in to book a flight");
            }
            var ticket = new Ticket
            {
                FlightNumber = int.Parse(flightNum),
                Expired = false,
                TicketNumber = new Random().Next(),
                UserId = Main.LoggedInUser!.Id,
            };
            Program.data.MainAirport.Users
                .Find(u => u.Id == Main.LoggedInUser.Id)?
                .Tickets.Add(ticket);
            //Main.LoggedInUser.Tickets.Add(ticket);
            Main.SaveData();
        }
    }
}
