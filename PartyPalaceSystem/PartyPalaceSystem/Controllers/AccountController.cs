using Dapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using PartyPalaceSystem.Models;
using PartyPalaceSystem.Repository;
using System.Data;

namespace PartyPalaceSystem.Controllers
{
    public class AccountController : Controller
    {
       
            private readonly IConfiguration _configuration;
            private readonly string _connectionString;
            public AccountController(IConfiguration configuration)
            {
                _configuration = configuration;
            _connectionString = _configuration.GetConnectionString("DbString");
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

       

            [HttpPost]
       
        public ActionResult SignIn(SignInModel user)
        {
            UserRepository userRepository = new UserRepository();

            var isUserAuthenticate = userRepository.AuthenticateUser(user);
            if(isUserAuthenticate==true)
            {
                return RedirectToAction("Index", "Home");
                
            }
            else
            {
                return View("Error");
            }
        }

        /* public ActionResult SignIn(SignInModel signInModel)
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
        } */
    }
}
