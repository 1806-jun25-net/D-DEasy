using System;
using System.Collections.Generic;

namespace DandDEasy_WEB.Models
{
    public partial class User
    {
        public User()
        {
            Campaign = new HashSet<Campaign>();
            Character = new HashSet<Character>();
        }

        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public DateTime? RegistrationDate { get; set; }

        public ICollection<Campaign> Campaign { get; set; }
        public ICollection<Character> Character { get; set; }
    }
}
