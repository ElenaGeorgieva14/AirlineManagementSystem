using AppService.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfServiceLibrary1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ITicket" in both code and config file together.
    [ServiceContract]
    public interface ITicket
    {
        [OperationContract]
        List<TicketsDTO> GetTickets();

        [OperationContract]
        List<TicketsDTO> GetTicketsByDocumentNumber(string documentNumber);

        [OperationContract]
        TicketsDTO GetTicketById(int id);
        [OperationContract]
        string PostTicket(TicketsDTO ticketsDTO);

        [OperationContract]
        string DeleteTicket(int id);

        [OperationContract]
        string UpdateTicket(TicketsDTO ticketsDTO);

    }
}

