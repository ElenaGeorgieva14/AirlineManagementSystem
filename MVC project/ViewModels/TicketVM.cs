using AppService.DTOs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC_project.ViewModels
{
    public class TicketVM
    {
        public int Id { get; set; }

        [DisplayName("Name ")]
        [Required]
        public string Name { get; set; }


        [DisplayName("Choose flight ")]
        [Required]
        public int FlightId { get; set; }
        public FlightVM Flight { get; set; }

        [DisplayName("Passport/ID card number ")]
        [Required]
        public string DocumentNumber { get; set; }

        [DisplayName("Nationality ")]
        [Required]
        public string Nationality { get; set; }


        [DisplayName("Seat number ")]
        [Required]
        public string SeatNumber { get; set; }

        [DisplayName("Class ")]
        [Required]
        public string Class { get; set; }

        [DisplayName("Luggage ")]
        [Required]
        public string Luggage { get; set; }

        [DisplayName("Price ")]
        [Required]
        public double Price { get; set; }
       
        public TicketVM() { }

        public TicketVM(TicketsDTO ticketsDTO)
        {
            Id = ticketsDTO.Id;
            Name = ticketsDTO.Name;
            FlightId = ticketsDTO.Id;
            Flight = new FlightVM
            {
                Id = ticketsDTO.Flight.Id,
                FlightNumber = ticketsDTO.Flight.FlightNumber,
                BoardingTime = ticketsDTO.Flight.BoardingTime
            };
            DocumentNumber = ticketsDTO.DocumentNumber;
            Nationality = ticketsDTO.Nationality;
            SeatNumber = ticketsDTO.SeatNumber;
            Class = ticketsDTO.Class;
            Luggage = ticketsDTO.Luggage;
            Price = ticketsDTO.Price;
        }
    }
}