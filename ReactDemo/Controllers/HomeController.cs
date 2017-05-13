using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ReactDemo.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ReactDemo.Controllers
{
    public class HomeController : Controller
	{
		private static readonly IList<CommentModel> _comments;

        /// <summary>
        /// Hard coded initial comments set
        /// </summary>
		static HomeController()
		{
			_comments = new List<CommentModel>
			{
				new CommentModel
				{
					Id = 1,
					Author = "Daniel Lo Nigro",
					Text = "Hello ReactJS.NET World!"
				},
				new CommentModel
				{
					Id = 2,
					Author = "Pete Hunt",
					Text = "This is one comment"
				},
				new CommentModel
				{
					Id = 3,
					Author = "Jordan Walke",
					Text = "This is *another* comment"
				},
			};
		}

        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// Fetch the comments data 
        /// </summary>
        /// <returns>The comments as a JSON dataset</returns>
		[Route("comments")]
		[ResponseCache(Location = ResponseCacheLocation.None, NoStore = true)]
		public ActionResult Comments()
		{
			return Json(_comments);
		}

        /// <summary>
        /// Submits a new comment
        /// </summary>
        /// <returns>Success message</returns>
        /// <param name="comment">The comment to be submitted</param>
		[Route("comments/new")]
		[HttpPost]
		public ActionResult AddComment(CommentModel comment)
		{
			// Create a fake ID for this comment
			comment.Id = _comments.Count + 1;
			_comments.Add(comment);
			return Content("Success :)");
		}
    }
}
