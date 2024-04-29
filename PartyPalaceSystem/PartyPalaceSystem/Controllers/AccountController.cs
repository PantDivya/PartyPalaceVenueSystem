using Microsoft.AspNetCore.Mvc;
using PartyPalaceSystem.Models;

namespace PartyPalaceSystem.Controllers
{
    public class AccountController : Controller
    {
       
            private readonly IConfiguration _configuration;
            public AccountController(IConfiguration configuration)
            {
                _configuration = configuration;
            }
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

            [HttpPost]
            public ActionResult SignIn(SignInModel signInModel)
            {
                var UserName = _configuration["UserCredential:username"];
                var Password = _configuration["UserCredential:password"];
                if (signInModel.username == UserName && signInModel.password == Password)
                {
                    return Ok("windows.alert('SignIn successfull')");
                }
                else
                {
                return Ok("alert('wrong username and password')");
                   }
            } 
        
        
    }
}
