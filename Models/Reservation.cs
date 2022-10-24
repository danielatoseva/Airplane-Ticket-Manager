using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Airplane_Ticket_Manager.Models
{
    public class Reservation
    {
        public string FirstName { get; set; }

        public string SecondName { get; set; }

        public string FamilyName { get; set; }

        public int EGN { get; set; }

        public int PhoneNumber { get; set; }

        public string Nationality { get; set; }

        public string TicketType { get; set; }

        public User User { get; set; }

        public Flight Flight { get; set; }
    }
}
