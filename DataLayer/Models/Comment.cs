﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
    }
}
