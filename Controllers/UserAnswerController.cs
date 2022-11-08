using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using QuestionAPP.Service.UserAnswerService;

namespace QuestionAPP.Controllers
{
   
    [Route("api/[controller]")]
    [ApiController]
    public class UserAnswerController : ControllerBase

        
    {
        private IUserAnswerService service { get; set; }

        public UserAnswerController(IUserAnswerService service)
        {
            this.service = service; 
        }

        [EnableCors]
        [HttpPost]
        [Route("/user-answers")]
        public List<UserAnswer> setAnswer(List<UserAnswer> answers)
        {
            return service.setAnswer(answers);  
        }
    }


}
