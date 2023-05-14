using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Models
{
    public class Transaction
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public float Price { get; set; }
        [Required]
        public DateTime Time { get; set; }

        [ForeignKey("User")]
        public int? BouhgtBy { get; set; }
        public virtual User User { get; set; }

        [ForeignKey("Game")]
        public int? GameId { get; set; }
        public virtual Game Game { get; set; }

    }
}
