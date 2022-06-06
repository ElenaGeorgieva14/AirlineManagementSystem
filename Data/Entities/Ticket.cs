using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    public class Ticket:BaseEntity
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public int FlightId { get; set; }
        public virtual Flight Flight { get; set; }
        [Required]
        public string DocumentNumber { get; set; }
        [Required]
        public string Nationality { get; set; }

        public string SeatNumber { get; set; }
        [Required]
        public string Class { get; set; }
        [Required]
        public string Luggage { get; set; }
        [Required]
        public double Price { get; set; }
    }
}
