using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.DTOs
{
    public class GameDTO
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
    }
}
