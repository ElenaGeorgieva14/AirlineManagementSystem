using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppService.DTOs
{
    public class FlightsDTO
    {
        public int Id { get; set; }
        public string FlightNumber { get; set; }
        public DateTime? BoardingTime { get; set; }

        public int NumberOfSeats { get; set; }
        public string From { get; set; }
        public string To { get; set; }
        public int Gate { get; set; }
        public double TicketPrice { get; set; }
        public UserDTO Pilot { get; set; }


        public bool Validate()
        {
            return !String.IsNullOrEmpty(FlightNumber);
        }
    }
}
