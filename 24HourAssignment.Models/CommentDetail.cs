using _24HourAssignment.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24HourAssignment.Models
{
    public class CommentDetail
    {
        public string CommentText { get; set; }

        public virtual List<Reply> Replies { get; set; }

        public int? PostId { get; set; }

        public Post Post { get; set; }
    }
}
