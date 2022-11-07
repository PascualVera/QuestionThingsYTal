using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using QuestionAPP.Service.UserService;

namespace QuestionAPP.Controllers
{
    [ApiController]
    [Route("user/[controller]")]
    public class UserController : Controller
    {
        
        private  IUserService service
        { get; set; }

        public UserController( IUserService service)
        {
            this.service = service;
        }





        //METHODS
        [HttpGet]
        [Route( "/all")]
        public List<User> getUsers()
        {
            return service.getUsers();
        }




        [HttpPost]
        [Route("/add")]
        public User addUser(User newUser)
        {
            
            return service.addUser(newUser);
            
        }
      
    }
}