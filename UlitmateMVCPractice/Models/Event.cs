using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace UlitmateMVCPractice.Models
{
    public class Event
    {
        public int EventId { get; set; }
        [Display (Name="Event title")]
        public string Eventname { get; set; }
        [Display(Name = "Event date")]
        public DateTime EventDate { get; set; }
        [Display(Name = "Event venue")]
        public string EventVenue { get; set; }
        [Display(Name = "Event additional details")]
        public string EventOtherDetails { get; set; }
        public DateTime PostedDate { get; set; }


        public Event()
        {
            CommentList = new List<Comment>();
        }

        #region  Navigation Property
        public virtual List<Comment> CommentList { get; set; }
        #endregion
    }
}