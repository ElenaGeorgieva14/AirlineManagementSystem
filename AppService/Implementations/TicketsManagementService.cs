using AppService.DTOs;
using Data.Entities;
using Repository.Implementations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppService.Implementations
{
    public class TicketsManagementService
    {
        public List<TicketsDTO> Get()
        {
            List<TicketsDTO> ticketsDTO = new List<TicketsDTO>();

            using (UnitOfWork unitOfWork = new UnitOfWork())
            {
                foreach (var item in unitOfWork.TicketRepository.Get())
                {
                    ticketsDTO.Add(new TicketsDTO
                    {
                        Id = item.Id,
                        Name = item.Name,
                        Flight = new FlightsDTO
                        {
                            Id = item.Flight.Id,
                            FlightNumber = item.Flight.FlightNumber,
                            BoardingTime = item.Flight.BoardingTime,
                            Gate = item.Flight.Gate
                        },
                        DocumentNumber = item.DocumentNumber,
                        Nationality = item.Nationality,
                        SeatNumber = item.SeatNumber,
                        Class = item.Class,
                        Luggage = item.Luggage,
                        Price = item.Price

                    });
                }

            }
            return ticketsDTO;
        }

        public List<TicketsDTO> GetByDocumentNumber(string documentNumber)
        {
            List<TicketsDTO> ticketsDTO = new List<TicketsDTO>();

            using (UnitOfWork unitOfWork = new UnitOfWork())
            {
                foreach (var item in unitOfWork.TicketRepository.Get(filter: item => item.DocumentNumber == documentNumber))
                {
                    ticketsDTO.Add(new TicketsDTO
                    {
                        Id = item.Id,
                        Name = item.Name,
                        Flight = new FlightsDTO
                        {
                            Id = item.Flight.Id,
                            FlightNumber = item.Flight.FlightNumber,
                            BoardingTime = item.Flight.BoardingTime,
                            Gate = item.Flight.Gate
                        },
                        DocumentNumber = item.DocumentNumber,
                        Nationality = item.Nationality,
                        SeatNumber = item.SeatNumber,
                        Class = item.Class,
                        Luggage = item.Luggage,
                        Price = item.Price

                    });
                }

            }
            return ticketsDTO;
        }

        public TicketsDTO GetByID(int id)
        {
            TicketsDTO ticketsDTO = new TicketsDTO();
            using (UnitOfWork unitOfWork = new UnitOfWork())
            {
                Ticket item = unitOfWork.TicketRepository.GetByID(id);
                {
                    if (item != null)
                    {
                        ticketsDTO = new TicketsDTO
                        {
                            Id = item.Id,
                            Name = item.Name,
                            Flight = new FlightsDTO
                            {
                                Id = item.Flight.Id,
                                FlightNumber = item.Flight.FlightNumber,
                                BoardingTime = item.Flight.BoardingTime,
                                Gate = item.Flight.Gate
                            },
                            DocumentNumber = item.DocumentNumber,
                            Nationality = item.Nationality,
                            SeatNumber = item.SeatNumber,
                            Class = item.Class,
                            Luggage = item.Luggage,
                            Price = item.Price

                        };
                    }
                }

            }
            return ticketsDTO;
        }
        public bool Save(TicketsDTO ticketsDTO)
        {

            Ticket item = new Ticket
            {
                Name = ticketsDTO.Name,
                FlightId = ticketsDTO.Flight.Id,
                DocumentNumber = ticketsDTO.DocumentNumber,
                Nationality = ticketsDTO.Nationality,
                SeatNumber = ticketsDTO.SeatNumber,
                Class = ticketsDTO.Class,
                Luggage = ticketsDTO.Luggage,
                Price = ticketsDTO.Price


            };
            try
            {
                using (UnitOfWork unitOfWork = new UnitOfWork())
                {
                    unitOfWork.TicketRepository.Insert(item);
                    unitOfWork.Save();
                }
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Edit(TicketsDTO ticketsDTO)
        {


            Ticket item = new Ticket
            {
                Id = ticketsDTO.Id,
                Name = ticketsDTO.Name,
                FlightId = ticketsDTO.Flight.Id,
                DocumentNumber = ticketsDTO.DocumentNumber,
                Nationality = ticketsDTO.Nationality,
                SeatNumber = ticketsDTO.SeatNumber,
                Class = ticketsDTO.Class,
                Luggage = ticketsDTO.Luggage,
                Price = ticketsDTO.Price


            };
            try
            {
                using (UnitOfWork unitOfWork = new UnitOfWork())
                {
                    unitOfWork.TicketRepository.Update(item);
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
                    Ticket item = unitOfWork.TicketRepository.GetByID(id);
                    unitOfWork.TicketRepository.Delete(item);
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