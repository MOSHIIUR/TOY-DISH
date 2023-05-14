using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Models
{
    public class Comment
    {
        [Key]
        public int CommentId { get; set; }

        [Required]
        public string CommentText { get; set; }

        [Required]
        public DateTime CommentAt { get; set; }


        [ForeignKey("User")]
        public int? CommentedBy { get; set; }
        public virtual User User { get; set; }

        [ForeignKey("Game")]
        public int? GameId { get; set; }
        public virtual Game Game { get; set; }
    }
}
