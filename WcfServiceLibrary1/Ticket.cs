using AppService.DTOs;
using AppService.Implementations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfServiceLibrary1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Ticket" in both code and config file together.
    public class Ticket : ITicket
    {
        private TicketsManagementService ticketsService = new TicketsManagementService();
        public string DeleteTicket(int id)
        {
            if (!ticketsService.Delete(id))
            {
                Console.Writeline("Ticket is not deleted");
                return "Ticket is not deleted!";
            }
            else
            {
                Console.Writeline("Ticket is deleted");
                return "Ticket is deleted";
            }
        }


        public TicketsDTO GetTicketById(int id)
        {
            return ticketsService.GetByID(id);
        }

        public List<TicketsDTO> GetTickets()
        {
            return ticketsService.Get();
        }

        public List<TicketsDTO> GetTicketsByDocumentNumber(string documentNumber)
        {
            return ticketsService.GetByDocumentNumber(documentNumber);
        }

        public string PostTicket(TicketsDTO ticketsDTO)
        {
            if (!ticketsService.Save(ticketsDTO))
            {
                return "Ticket is not saved!";
            }
            else
            {
                return "Ticket is saved";
            }
        }

        public string UpdateTicket(TicketsDTO ticketsDTO)
        {
            if (!ticketsService.Edit(ticketsDTO))
            {
                return "Ticket is not updated!";
            }
            else
            {
                return "Ticket is updated";
            }
        }
    }
}
