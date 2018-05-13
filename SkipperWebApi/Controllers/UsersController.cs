using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace SkipperWebApi.Controllers
{
    public class UsersController : Controller
    {
        [HttpGet]
        public IEnumerable<string> Index()
        {
            return new string[] { "user1", "user2" };
        }
    }
}