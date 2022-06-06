using AppService.DTOs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC_project.ViewModels
{
    public class FlightVM
    {
        public int Id { get; set; }

        [DisplayName("Flight number ")]
        [Required]
        public string FlightNumber { get; set; }

        [DisplayName("Boarding time ")]
        [Required]
        public DateTime? BoardingTime { get; set; }


        [DisplayName("Number of seats ")]
        [Required]
        public int NumberOfSeats { get; set; }

        [DisplayName("From ")]
        [Required]
        public string From { get; set; }

        [DisplayName("To ")]
        [Required]
        public string To { get; set; }

        [DisplayName("Gate ")]
        public int Gate { get; set; }

        [DisplayName("Ticket price ")]
        [Required]
        public double TicketPrice { get; set; }

        [DisplayName("Pilot ")]
        [Required]
        public int PilotId { get; set; }
        public UserVM Pilot { get; set; }



        public FlightVM() { }

        public FlightVM(FlightsDTO flightsDTO)
        {
            Id = flightsDTO.Id;
            FlightNumber = flightsDTO.FlightNumber;
            BoardingTime = flightsDTO.BoardingTime;
            NumberOfSeats = flightsDTO.NumberOfSeats;
            From = flightsDTO.From;
            To = flightsDTO.To;
            Gate = flightsDTO.Gate;
            TicketPrice = flightsDTO.TicketPrice;
            PilotId = flightsDTO.Pilot.Id;
            Pilot = new UserVM
            {
                Id = flightsDTO.Pilot.Id,
                Name = flightsDTO.Pilot.Name,
                Phone = flightsDTO.Pilot.Phone
            };

        }
    }
}