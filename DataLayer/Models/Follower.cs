using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Models
{
    public class Follower
    {
        [Key]
        public int FId { get; set; }

        [Required]
        public DateTime DateFollowed { get; set; }
        public string FollowedUserName{ get; set; }

        [ForeignKey("User")]
        public int? FollowerUserId { get; set; }
        public virtual User User { get; set; }

    }
}
