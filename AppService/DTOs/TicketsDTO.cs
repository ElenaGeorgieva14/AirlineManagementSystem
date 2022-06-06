using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppService.DTOs
{
    public class TicketsDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public FlightsDTO Flight { get; set; }
        public string DocumentNumber { get; set; }
        public string Nationality { get; set; }
        public string SeatNumber { get; set; }
        public string Class { get; set; }
        public string Luggage { get; set; }
        public double Price { get; set; }
    }
}
