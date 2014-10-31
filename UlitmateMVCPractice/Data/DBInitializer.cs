using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using UlitmateMVCPractice.Models;

namespace UlitmateMVCPractice.Data
{
    public class DBInitializer:DropCreateDatabaseAlways<PostContext>
    {
        protected override void Seed(PostContext context)
        {
            var events = new List<Event>
            {
                new Event {Eventname = "Trick or treat", EventVenue="QC", EventDate = DateTime.Now.AddDays(12), PostedDate=DateTime.Now},
                 new Event {Eventname = "Year end party!", EventVenue="Manila", EventDate = DateTime.Now.AddDays(29), PostedDate=DateTime.Now}
            };

            events.ForEach(e => context.Events.Add(e));
            context.SaveChanges();
        }
    }
}