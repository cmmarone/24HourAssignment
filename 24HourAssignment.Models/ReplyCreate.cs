using _24HourAssignment.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24HourAssignment.Models
{
    public class ReplyCreate
    {
        [Required]
        public string ReplyText { get; set; }


        public int? CommentId { get; set; }

        public Comment Comment { get; set; }
    }
}
