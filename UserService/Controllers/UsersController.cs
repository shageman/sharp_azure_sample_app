using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.UI.WebControls;
using UserService.Models;

namespace UserService.Controllers
{
    public class UsersController : ApiController
    {
        private readonly IUserService _userService;

        public UsersController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public List<User> Index()
        {
            return _userService.GetUsers();

        }

        [HttpPost]
        public void Create(User user)
       { 
            _userService.CreateUser(user);
        }
    }
}
