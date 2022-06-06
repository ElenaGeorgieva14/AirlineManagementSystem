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
    public class FlightController : Controller
    {
        // GET: Flight
        [Authorize]
        public ActionResult Index(int? page)
        {
            List<FlightVM> flightVM = new List<FlightVM>();
            using (FlightService.FlightClient service = new FlightService.FlightClient())
            {
                foreach (var flight in service.GetFlights())
                {
                    flightVM.Add(new FlightVM(flight));
                }
            }
            return View(flightVM.ToList().ToPagedList(page ?? 1,3));
        }
        [Authorize]
        public ActionResult CreateFlight()
        {
            return View();
        }

        [HttpPost]
        [Authorize]
        [ValidateAntiForgeryToken]

        public ActionResult CreateFlight(FlightVM flightVM)
        {
            try
            {
                using (FlightService.FlightClient service = new FlightService.FlightClient())
                {
                    UserDTO pilotDTO;
                    using (UserService.UserClient userService = new UserService.UserClient())
                    {
                        pilotDTO = userService.GetUserById(flightVM.PilotId);

                    }



                    FlightsDTO flightsDTO = new FlightsDTO
                    {
                        FlightNumber = flightVM.FlightNumber,
                        BoardingTime = flightVM.BoardingTime,
                        NumberOfSeats = flightVM.NumberOfSeats,
                        From = flightVM.From,
                        To = flightVM.To,
                        Gate = flightVM.Gate,
                        TicketPrice = flightVM.TicketPrice,
                        Pilot = pilotDTO,


                    };
                    service.PostFlight(flightsDTO);
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
            using (TicketService.TicketClient ticketService = new TicketService.TicketClient())
            {
                foreach (var ticket in ticketService.GetTickets())
                {
                    if (ticket.Flight.Id == id)
                    {
                        ticketService.DeleteTicket(ticket.Id);
                    }
                }
            }
            using (FlightService.FlightClient service = new FlightService.FlightClient())
            {
                service.DeleteFlight(id);
            }
            return RedirectToAction("Index");
        }
        [Authorize]
        public ActionResult Edit(int id)
        {
            FlightVM flightVM = new FlightVM();
            using (FlightService.FlightClient service = new FlightService.FlightClient())
            {
                var flightDTO = service.GetFlightsById(id);
                flightVM = new FlightVM(flightDTO);
            }
            return View(flightVM);
        }

        [HttpPost]
        [Authorize]
        [ValidateAntiForgeryToken]

        public ActionResult Edit(FlightVM flightVM)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    using (FlightService.FlightClient service = new FlightService.FlightClient())
                    {
                        UserDTO pilotDTO = new UserDTO();
                        using (UserService.UserClient userService = new UserService.UserClient())
                        {
                            pilotDTO = userService.GetUserById(flightVM.PilotId);

                        }



                        FlightsDTO flightsDTO = new FlightsDTO
                        {
                            Id = flightVM.Id,
                            FlightNumber = flightVM.FlightNumber,
                            BoardingTime = flightVM.BoardingTime,
                            NumberOfSeats = flightVM.NumberOfSeats,
                            From = flightVM.From,
                            To = flightVM.To,
                            Gate = flightVM.Gate,
                            TicketPrice = flightVM.TicketPrice,
                            Pilot = pilotDTO,


                        };
                        service.UpdateFlight(flightsDTO);
                    }
                    return RedirectToAction("Index");
                }
                return View();
            }
            catch
            {
                return View();
            }
        }
        [Authorize]
        public ActionResult SearchFlights(string destination,int? page)
        {
            List<FlightVM> flightVM = new List<FlightVM>();
            using (FlightService.FlightClient service = new FlightService.FlightClient())
            {
                foreach (var flight in service.GetFlightsByDestination(destination))
                {
                    flightVM.Add(new FlightVM(flight));
                }
            }
            return View(flightVM.ToList().ToPagedList(page ?? 1, 5));
        }
    }
}