using AppService.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfServiceLibrary1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IFlight" in both code and config file together.
    [ServiceContract]
    public interface IFlight
    {
        [OperationContract]
        List<FlightsDTO> GetFlights();

        [OperationContract]
        List<FlightsDTO> GetFlightsByDestination(string destination);

        [OperationContract]
        FlightsDTO GetFlightsById(int id);
        [OperationContract]
        string PostFlight(FlightsDTO flightsDTO);

        [OperationContract]
        string DeleteFlight(int id);

        [OperationContract]
        string UpdateFlight(FlightsDTO flightsDTO);
    }
}