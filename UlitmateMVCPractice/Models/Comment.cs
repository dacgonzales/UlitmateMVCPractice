using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace UlitmateMVCPractice.Models
{
    public class Comment
    {
        public int CommentId { get; set; }
        [Required(ErrorMessage="Comment is required")]
        public string Content { get; set; }
        public DateTime CommentPostedDate { get; set; }
        public int EventId { get; set; }
        public virtual Event Event { get; set; }

    }
}