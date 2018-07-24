using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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
        [Required]
        [StringLength(30)]
        public string Username { get; set; }
        [Required]
        [StringLength(30)]
        public string Password { get; set; }
        [StringLength(30)]
        public string FirstName { get; set; }
        [Required]
        [StringLength(30)]
        public string LastName { get; set; }
        [Required]
        [StringLength(50)]
        public string Email { get; set; }
        [Column(TypeName = "date")]
        public DateTime? RegistrationDate { get; set; }

        [InverseProperty("DungeonMaster")]
        public ICollection<Campaign> Campaign { get; set; }
        [InverseProperty("User")]
        public ICollection<Character> Character { get; set; }
    }
}
