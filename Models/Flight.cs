using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Airplane_Ticket_Manager.Models
{
    public class Flight
    {
        public string FromDestination { get; set; }

        public string ToDestination { get; set; }

        public DateTime DepartureDate { get; set; }

        public DateTime ArrivalDate { get; set; }

        public string AirplaneType { get; set; }

        public int AirplaneID { get; set; }

        public string PilotName { get; set; }

        public int PassengerCapacity { get; set; }

        public int BusinessClassCapacity { get; set; }

        public List<Reservation> Reservations { get; set; }

    }
}
