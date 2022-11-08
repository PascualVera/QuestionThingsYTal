using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
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
        public async Task<ServiceResponse<List<User>>> getUsers()
        {
            return await service.getUsers();
        }

        [HttpPost]
        [Route("/add")]
        public async Task<ServiceResponse<User>> addUser(User newUser)
        {
            
            return await service.addUser(newUser);
            
        }
        [HttpPost]
        [Route("/login")]

        public async Task<ServiceResponse<User>> login(User user)
        {
            return await service.getUser(user);
        }

    }
}