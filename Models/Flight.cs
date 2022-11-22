using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Airplane_Ticket_Manager.Models
{
    public class Flight
    {
        [Required]
        public string FromDestination { get; set; }

        [Required]
        public string ToDestination { get; set; }

        [Required]
        public DateTime DepartureDate { get; set; }

        [Required]
        public DateTime ArrivalDate { get; set; }

        [Required]
        public string AirplaneType { get; set; }

        [Key]
        public int AirplaneID { get; set; }

        [Required]
        public string PilotName { get; set; }

        [Required]
        public int PassengerCapacity { get; set; }

        [Required]
        public int BusinessClassCapacity { get; set; }

        public List<Reservation> Reservations { get; set; }


        public Flight()
        {

        }

        public Flight(string fromDestination, string toDestination,
            DateTime departureDate, DateTime arrivalDate, string airplaneType,
            int airplaneID, string pilotName, int passengerCapacity, int businessClassCapacity)
        {
            FromDestination = fromDestination;
            ToDestination = toDestination;
            DepartureDate = departureDate;
            ArrivalDate = arrivalDate;
            AirplaneType = airplaneType;
            AirplaneID = airplaneID;
            PilotName = pilotName;
            PassengerCapacity = passengerCapacity;
            BusinessClassCapacity = businessClassCapacity;
        }
    }
}
