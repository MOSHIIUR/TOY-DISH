using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }

        [Required]
        public string UserType { get; set; }

        public ICollection<Game> Games { get; set; }
        public ICollection<Transaction> Transactions { get; set; }
        public ICollection<Follower> Followers { get; set; }

        public User()
        {
            Games = new List<Game>();
            Transactions = new List<Transaction>();
            Followers = new List<Follower>();
        }




    }
}
