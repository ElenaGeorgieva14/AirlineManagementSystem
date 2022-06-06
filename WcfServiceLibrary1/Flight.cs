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
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Flight" in both code and config file together.
    public class Flight : IFlight
    {
        private FlightsManagementService flightsService = new FlightsManagementService();

        public string DeleteFlight(int id)
        {
            if (!flightsService.Delete(id))
            {
                return "Flight is not deleted!";
            }
            else
            {
                return "Flight is deleted";
            }
        }

        public List<FlightsDTO> GetFlights()
        {
            return flightsService.Get();
        }

        public List<FlightsDTO> GetFlightsByDestination(string destination)
        {
            return flightsService.GetByDestination(destination);
        }

        public FlightsDTO GetFlightsById(int id)
        {
            return flightsService.GetByID(id);
        }

        public string PostFlight(FlightsDTO flightsDTO)
        {
            if (!flightsService.Save(flightsDTO))
            {
                return "Flight is not saved!";
            }
            else
            {
                return "Flight is saved";
            }
        }

        public string UpdateFlight(FlightsDTO flightsDTO)
        {
            if (!flightsService.Edit(flightsDTO))
            {
                return "Flight is not updated!";
            }
            else
            {
                return "Flight is updated";
            }
        }
    }
}

