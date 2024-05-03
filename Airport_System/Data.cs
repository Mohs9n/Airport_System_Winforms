using Airport_System.Entities;

namespace Airport_System
{
    public class Data
    {
        public Airport MainAirport { get; set; }
        public List<Airport> Airports { get; set; } = [];
        // public required string FileName { get; set; } = string.Empty;
        public Data()
        {
            // FileName = string.Empty;
            MainAirport = InitAirport();
            CreateAirports();
        }


        private Airport InitAirport()
        {
            var airport = new Airport
            {
                AirportCode = "CAI",
                Name = "Cairo Airport",
                Country = new Country { Name = "Republic of Egypt" },
                City = new City { Name = "Cairo" },
                Adminstrator = new Adminstrator
                {
                    Id = 1,
                    Email = "e",
                    Name = "One Piece",
                    PhoneNumber = "1234567890",
                    Password = "e",
                },
            };
            airport.Airplanes.Add(new Airplane 
            { 
                Id = 1,
                Company = "Boeing",
                PlaneModel = "733",
                TopSpeed = 300,
                Capacity = 200,
            });
            airport.Airplanes.Add(new Airplane
            {
                Id = 2,
                Company = "Boeing",
                PlaneModel = "855 max",
                TopSpeed = 500,
                Capacity = 100,
            });
            return airport;
        }

        private void CreateAirports()
        {
            var airport = new Airport
            {
                AirportCode = "CAL",
                Name = "Canada AirLine",
                Country = new Country { Name = "Canada" },
                City = new City { Name = "Toronto" },
                Adminstrator = new Adminstrator
                {
                    Id = 1,
                    Email = "e",
                    Name = "One Piece",
                    PhoneNumber = "1234567890",
                    Password = "e",
                },
            };
            var airport2 = new Airport
            {
                AirportCode = "LAX",
                Name = "Los Angeles Extreme",
                Country = new Country { Name = "United States of America" },
                City = new City { Name = "California" },
                Adminstrator = new Adminstrator
                {
                    Id = 1,
                    Email = "e",
                    Name = "One Piece",
                    PhoneNumber = "1234567890",
                    Password = "e",
                },
            };
            Airports.Add(airport);
            Airports.Add(airport2);
        }
    }
}
