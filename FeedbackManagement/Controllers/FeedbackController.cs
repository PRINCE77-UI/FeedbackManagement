using System.Collections.Generic;
using System.Web.Mvc;
using FeedbackManagemant.Models;

namespace FeedbackManagemant.Controllers
{
    public class FeedbackController : Controller
    {
        static List<Feedback> feedbackList = new List<Feedback>();
        static int nextId = 1;

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GiveFeedback()
        {
            return View(new Feedback());
        }

        [HttpPost]
        public ActionResult GiveFeedback(Feedback f)
        {
            if (ModelState.IsValid)
            {
                f.Id = nextId;
                nextId++;
                feedbackList.Add(f);
                return RedirectToAction("ViewFeedback");
            }
            return View(f);
        }
        public ActionResult ViewFeedback()
        {
            return View(feedbackList);
        }
    }
}