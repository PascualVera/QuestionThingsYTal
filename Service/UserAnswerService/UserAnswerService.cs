using QuestionAPP.Data;

namespace QuestionAPP.Service.UserAnswerService
{
    public class UserAnswerService : IUserAnswerService
    {
        public DataContext context { get; set; }

        public UserAnswerService(DataContext context)
        {
            this.context = context; 
        }


        public UserAnswer setAnswer(UserAnswer answer)
        {
            context.UserAnswers.Add(answer);    
            context.SaveChanges();
            return answer;
        }
    }
}
