using _24HourAssignment.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24HourAssignment.Models
{
    public class PostDetail
    {
        public string PostTitle { get; set; }
        public string Text { get; set; }
        public virtual List<Comment> Comments { get; set; }




    }
}
