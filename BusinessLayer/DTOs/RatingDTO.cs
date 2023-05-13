using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.DTOs
{
    public class RatingDTO
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int Value { get; set; }
    }
}
