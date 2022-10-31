using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Airplane_Ticket_Manager.Models
{
    public class User
    {
        [Required]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string FamilyName { get; set; }

        [Key]
        public int EGN { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        public int PhoneNumber { get; set; }

        [Required]
        public string Role { get; set; }

        public List<Reservation> Reservations { get; set; }

        private User()
        {

        }

        public User(string username, string password,
            string email, string firstName, string familyName,
            int eGN, string address, int phoneNumber, string role)
        {
            Username = username;
            Password = password;
            Email = email;
            FirstName = firstName;
            FamilyName = familyName;
            EGN = eGN;
            Address = address;
            PhoneNumber = phoneNumber;
            Role = role;
        }
    }
}
