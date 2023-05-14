using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Models
{
    public class Game
    {
        [Key]
        public int GameId { get; set; }

        [Required]
        public string GameTitle { get; set; }

        [Required]
        public string GameDescription { get; set; }

        [Required]
        public int GamePrice { get; set; }

        [Required]
        public string GamePlatform { get; set; }

        [Required]
        public string GameDownloadLink { get; set; }

        [Required]
        public DateTime PostAt { get; set; }

        [ForeignKey("User")]
        public int? PostedBy { get; set; }
        public virtual User User { get; set; }

        [ForeignKey("Category")]
        public int? CategoryId { get; set; }
        public virtual Category Category { get; set; }

        public virtual ICollection<Comment> Games { get; set; }

        public Game()
        {
            Games = new List<Comment>();
        }
    }
}
