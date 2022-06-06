using AppService.DTOs;
using MVC_project.ViewModels;
using PagedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_project.Controllers
{
    public class TicketController : Controller
    {
        // GET: Ticket
        [Authorize]
        public ActionResult Index(int? page)
        {
            List<TicketVM> ticketVM = new List<TicketVM>();
            using (TicketService.TicketClient service = new TicketService.TicketClient())
            {
                foreach (var ticket in service.GetTickets())
                {
                    ticketVM.Add(new TicketVM(ticket));
                }
            }
            return View(ticketVM.ToList().ToPagedList(page ?? 1, 3));
        }
        [Authorize]
        public ActionResult CreateTicket()
        {
            return View();
        }

        [HttpPost]
        [Authorize]
        [ValidateAntiForgeryToken]

        public ActionResult CreateTicket(TicketVM ticketVM)
        {
            try
            {
                using (TicketService.TicketClient service = new TicketService.TicketClient())
                {
                    FlightsDTO flightsDTO;
                    using (FlightService.FlightClient flightService = new FlightService.FlightClient())
                    {
                        flightsDTO = flightService.GetFlightsById(ticketVM.FlightId);
                        flightsDTO.NumberOfSeats -= 1;
                        flightService.UpdateFlight(flightsDTO);
                    }



                    TicketsDTO ticketsDTO = new TicketsDTO
                    {
                        Name = ticketVM.Name,
                        Flight = flightsDTO,
                        DocumentNumber = ticketVM.DocumentNumber,
                        Nationality = ticketVM.Nationality,
                        SeatNumber = ticketVM.SeatNumber,
                        Class = ticketVM.Class,
                        Luggage = ticketVM.Luggage,
                        Price = ticketVM.Price

                    };
                    service.PostTicket(ticketsDTO);
                }
                return RedirectToAction("Index");
            }
            catch
            {
                return View();

            }
        }

        [Authorize]
        public ActionResult Delete(int id)
        {
            using (TicketService.TicketClient service = new TicketService.TicketClient())
            {
                service.DeleteTicket(id);
            }
            return RedirectToAction("Index");
        }

        [Authorize]
        public ActionResult Edit(int id)
        {
            TicketVM ticketVM = new TicketVM();
            using (TicketService.TicketClient service = new TicketService.TicketClient())
            {
                var ticketsDTO = service.GetTicketById(id);
                ticketVM = new TicketVM(ticketsDTO);
            }
            return View(ticketVM);
        }

        [HttpPost]
        [Authorize]
        [ValidateAntiForgeryToken]

        public ActionResult Edit(TicketVM ticketVM)
        {
            try
            {


                using (TicketService.TicketClient ticketService = new TicketService.TicketClient())
                {


                    FlightsDTO flightsDTO = new FlightsDTO();
                    using (FlightService.FlightClient flightService = new FlightService.FlightClient())
                    {
                        flightsDTO = flightService.GetFlightsById(ticketVM.Flight.Id);
                    }

                    TicketsDTO ticketsDTO = new TicketsDTO
                    {
                        Id = ticketVM.Id,
                        Name = ticketVM.Name,
                        Flight = flightsDTO,
                        DocumentNumber = ticketVM.DocumentNumber,
                        Nationality = ticketVM.Nationality,
                        SeatNumber = ticketVM.SeatNumber,
                        Class = ticketVM.Class,
                        Luggage = ticketVM.Luggage,
                        Price = ticketVM.Price
                    };
                    ticketService.UpdateTicket(ticketsDTO);

                }
                return RedirectToAction("Index");
            }

            catch
            {
                return View();
            }
        }
        [Authorize]
        public ActionResult SearchTickets(string documentNumber, int? page)
        {
            List<TicketVM> ticketVM = new List<TicketVM>();
            using (TicketService.TicketClient service = new TicketService.TicketClient())
            {
                foreach (var ticket in service.GetTicketsByDocumentNumber(documentNumber))
                {
                    ticketVM.Add(new TicketVM(ticket));
                }
            }
            return View(ticketVM.ToList().ToPagedList(page ?? 1, 3));
        }
    }
}
