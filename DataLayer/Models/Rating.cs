using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Models
{
    public class Rating
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int Value { get; set; }
    }
}
