using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24HourAssignment.Data
{
    public class Post
    {
        // Post class
        //int Id
        //string Title
        //string Text
        //(virtual list of Comments)
        //Guid AuthorId
        [Key]
        public int PostId { get; set; }
        [Required]
        public string PostTitle { get; set; }

        [Required]
        public string Text { get; set; }

        public virtual List<Comment> Comments { get; set; }

        [Required]
        public Guid AuthorId { get; set; }

        
    }
}

