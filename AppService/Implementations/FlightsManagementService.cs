using AppService.DTOs;
using Data.Entities;
using PagedList;
using Repository.Implementations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppService.Implementations
{
    public class FlightsManagementService
    {
        public List<FlightsDTO> Get()
        {
            List<FlightsDTO> flightsDTOs = new List<FlightsDTO>();

            using (UnitOfWork unitOfWork = new UnitOfWork())
            {
                foreach (var item in unitOfWork.FlightRepository.Get())
                {
                    flightsDTOs.Add(new FlightsDTO
                    {
                        Id = item.Id,
                        FlightNumber = item.FlightNumber,
                        BoardingTime = item.BoardingTime,
                        NumberOfSeats = item.NumberOfSeats,
                        From = item.From,
                        To = item.To,
                        Gate = item.Gate,
                        TicketPrice = item.TicketPrice,
                        Pilot = new UserDTO
                        {
                            Id = item.Pilot.Id,
                            Name = item.Pilot.Name,
                            Username = item.Pilot.Username,
                            Phone = item.Pilot.Phone,
                            Email = item.Pilot.Email

                        }
                    });
                }

            }
            return flightsDTOs;
        }

        public List<FlightsDTO> GetByDestination(string destination)
        {
            List<FlightsDTO> flightsDTO = new List<FlightsDTO>();

            using (UnitOfWork unitOfWork = new UnitOfWork())
            {
                foreach (var item in unitOfWork.FlightRepository.Get(filter: item => item.To == destination))
                {
                    flightsDTO.Add(new FlightsDTO
                    {
                        Id = item.Id,
                        FlightNumber = item.FlightNumber,
                        BoardingTime = item.BoardingTime,
                        NumberOfSeats = item.NumberOfSeats,
                        From = item.From,
                        To = item.To,
                        Gate = item.Gate,
                        TicketPrice = item.TicketPrice,
                        Pilot = new UserDTO
                        {
                            Id = item.Pilot.Id,
                            Name = item.Pilot.Name,
                            Username = item.Pilot.Username,
                            Phone = item.Pilot.Phone,
                            Email = item.Pilot.Email

                        }

                    });
                }

            }
            return flightsDTO;
        }

        public FlightsDTO GetByID(int id)
        {
            FlightsDTO flightsDTO = new FlightsDTO();
            using (UnitOfWork unitOfWork = new UnitOfWork())
            {
                Flight item = unitOfWork.FlightRepository.GetByID(id);
                {
                    if (item != null)
                    {
                        flightsDTO = new FlightsDTO
                        {
                            Id = item.Id,
                            FlightNumber = item.FlightNumber,
                            BoardingTime = item.BoardingTime,
                            NumberOfSeats = item.NumberOfSeats,
                            From = item.From,
                            To = item.To,
                            Gate = item.Gate,
                            TicketPrice = item.TicketPrice,
                            Pilot = new UserDTO
                            {
                                Id = item.Pilot.Id,
                                Name = item.Pilot.Name,
                                Username = item.Pilot.Username,
                                Phone = item.Pilot.Phone,
                                Email = item.Pilot.Email

                            }
                        };
                    }
                }
            }
            return flightsDTO;
        }
        public bool Save(FlightsDTO flightsDTO)
        {


            Flight item = new Flight
            {
                FlightNumber = flightsDTO.FlightNumber,
                BoardingTime = flightsDTO.BoardingTime,
                NumberOfSeats = flightsDTO.NumberOfSeats,
                From = flightsDTO.From,
                To = flightsDTO.To,
                Gate = flightsDTO.Gate,
                TicketPrice = flightsDTO.TicketPrice,
                PilotId = flightsDTO.Pilot.Id,


            };
            try
            {
                using (UnitOfWork unitOfWork = new UnitOfWork())
                {
                    unitOfWork.FlightRepository.Insert(item);
                    unitOfWork.Save();
                }
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Edit(FlightsDTO flightsDTO)
        {


            Flight item = new Flight
            {
                Id = flightsDTO.Id,
                FlightNumber = flightsDTO.FlightNumber,
                BoardingTime = flightsDTO.BoardingTime,
                NumberOfSeats = flightsDTO.NumberOfSeats,
                From = flightsDTO.From,
                To = flightsDTO.To,
                Gate = flightsDTO.Gate,
                TicketPrice = flightsDTO.TicketPrice,
                PilotId = flightsDTO.Pilot.Id,


            };
            try
            {
                using (UnitOfWork unitOfWork = new UnitOfWork())
                {
                    unitOfWork.FlightRepository.Update(item);
                    unitOfWork.Save();
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool Delete(int id)
        {
            try
            {
                using (UnitOfWork unitOfWork = new UnitOfWork())
                {
                    Flight item = unitOfWork.FlightRepository.GetByID(id);
                    unitOfWork.FlightRepository.Delete(item);
                    unitOfWork.Save();
                }
                return true;
            }
            catch
            {
                return false;
            }
        }

    }
}
