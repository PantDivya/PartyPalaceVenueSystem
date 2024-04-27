using Microsoft.AspNetCore.Mvc;

namespace PartyPalaceSystem.Controllers
{
    public class AccountController : Controller
    {
        // GET: AccountController
        public ActionResult SignIn()
        {
            return View("SignIn");
        }

       public ActionResult Signup()
        {
            return View("SignUp");
        }

        //Post: AccountController
        public ActionResult authentication(string username, string password)
        {
            if(username != null && password != null)
            {

            }
            return RedirectToAction();
        }
       
        
    }
}
