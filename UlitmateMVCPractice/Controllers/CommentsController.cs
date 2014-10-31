using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using UlitmateMVCPractice.Data;
using UlitmateMVCPractice.Models;

namespace UlitmateMVCPractice.Controllers
{
    public class CommentsController : Controller
    {
        private PostContext db = new PostContext();
        [ChildActionOnly]
        public ActionResult Create(int? id)
        {
            Event _event = db.Events.Find(id);
            Comment @comment = new Comment { Event = _event, EventId = _event.EventId , CommentPostedDate = DateTime.Now};
            return View(@comment);
        }

        [HttpPost]
        public ActionResult Create([Bind(Include = "CommentId, Content, EventId, CommentPostedDate")] Comment @comment)
        {
             Event _event = db.Events.Find(@comment.EventId);
            if (ModelState.IsValid)
            {
                db.Comments.Add(@comment);
                db.SaveChanges();

               
                Comment newComment = new Comment { Event = _event, EventId = _event.EventId, CommentPostedDate = DateTime.Now };
                
                ModelState.Clear();

                return View(newComment);

            }
            else
            {
                
                //ModelState.AddModelError("", "Ex: This login failed");
                @comment.Event = _event;
                return View(@comment);
            }

            
            
        }
    }
}
