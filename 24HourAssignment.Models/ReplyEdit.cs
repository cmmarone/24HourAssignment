using _24HourAssignment.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24HourAssignment.Models
{
    public class ReplyEdit
    {
     
        public int ReplyId { get; set; }

        
        public int CommentId { get; set; }

        public  Comment Comment { get; set; }

        
        public string ReplyText { get; set; }

      
        public Guid AuthorId { get; set; }

    }
}
