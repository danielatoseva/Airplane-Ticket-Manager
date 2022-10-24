using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Airplane_Ticket_Manager.Models
{
    public class User
    {
        public string Username { get; set; }

        public string Password { get; set; }

        public string Email { get; set; }

        public string FirstName { get; set; }

        public string FamilyName { get; set; }

        public int EGN { get; set; }

        public string Address { get; set; }

        public int PhoneNumber { get; set; }

        public string Role { get; set; }

        public List<Reservation> Reservations { get; set; }
    }
}
