using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using QuestionAPP.Service.QuestionService;

namespace QuestionAPP.Controllers
{
    [EnableCors]
    [Route("api/[controller]")]
    [ApiController]
    public class QuestionController : ControllerBase
    {
        private  IQuestionService service { get; }
        

        public QuestionController(IQuestionService service)
        {
            this.service = service; 
        }

        [HttpGet]
        [Route("/question/all")]
        public List<Question> GetQuestions()
        {
            return  service.GetAllQuestions();
        }
        [HttpPost]
        [Route("/question/add")]
        public Question addQuestions(Question newQuestion)
        {
            return service.addQuestion(newQuestion);
        }

        [HttpGet]
        [Route("/question/answers")]
        public List<UserAnswer> GetAnswers(int id)
        {
            return service.getAllAnswerInQuestion(id);
        }
    }
}
