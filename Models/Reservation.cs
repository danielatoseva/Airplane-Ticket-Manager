using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Airplane_Ticket_Manager.Models
{
    public class Reservation
    {
        [Required]
        public string FirstName { get; set; }

        [Required]
        public string SecondName { get; set; }

        [Required]
        public string FamilyName { get; set; }

        [Key]
        public int EGN { get; set; }

        [Required]
        public int PhoneNumber { get; set; }

        [Required]
        public string Nationality { get; set; }

        [Required]
        public string TicketType { get; set; }

        [ForeignKey("UserID")]
        public string UserID { get; set; }

        public User User { get; set; }

        [ForeignKey("FlightKey")]
        public string FlightID { get; set; }

        public Flight Flight { get; set; }

        private Reservation()
        {

        }

        public Reservation(string firstName, string secondName, string familyName,
            int eGN, int phoneNumber, string nationality, string ticketType, User user, Flight flight)
        {
            FirstName = firstName;
            SecondName = secondName;
            FamilyName = familyName;
            EGN = eGN;
            PhoneNumber = phoneNumber;
            Nationality = nationality;
            TicketType = ticketType;
            User = user;
            Flight = flight;
        }
    }
}
