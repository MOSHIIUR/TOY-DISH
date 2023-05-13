using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.DTOs
{
    public class TransactionDTO
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public float Price { get; set; }
        [Required]
        public DateTime Time { get; set; }
    }
}
