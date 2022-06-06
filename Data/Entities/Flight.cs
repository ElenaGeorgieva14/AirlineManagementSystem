using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    public class Flight:BaseEntity
    {
        [Required]
        public string FlightNumber { get; set; }
        [Required]
        public DateTime? BoardingTime { get; set; }


        [Required]
        public int NumberOfSeats { get; set; }
        [Required]
        public string From { get; set; }
        [Required]
        public string To { get; set; }
        public int Gate { get; set; }
        [Required]
        public double TicketPrice { get; set; }
        public int PilotId { get; set; }
        public virtual Users Pilot { get; set; }

    }
}
