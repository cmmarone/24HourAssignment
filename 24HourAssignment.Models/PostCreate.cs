using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24HourAssignment.Models
{
    public class PostCreate
    {
        [Required]
        public string PostTitle { get; set; }

        [Required]
        public string Text { get; set; }

    }
}
