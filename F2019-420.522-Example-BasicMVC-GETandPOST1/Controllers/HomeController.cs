using System;
using System.Web.Mvc;

namespace F2019_420._522_Example_BasicMVC_GETandPOST1.Controllers
{
    public class HomeController : Controller
    {
        // GET
        /// <summary>
        /// This simply displays the empty form.
        /// </summary>
        /// <returns>The view.</returns>
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        
        // POST
        /// <summary>
        /// This method is called when the form POSTS the data back to us.
        /// </summary>
        /// <param name="firstName"></param>
        /// <returns>Lucky charms.</returns>
        [HttpPost]
        public ActionResult Index(String firstName)
        {
            // ViewData["FirstName"] = firstName;
            // or

            ViewBag.FirstName = firstName;

            return View();
        }
    }
}