using QuestionAPP.Data;
using QuestionAPP.Migrations;

namespace QuestionAPP.Service.UserAnswerService
{
    public class UserAnswerService : IUserAnswerService
    {
        public DataContext context { get; set; }

        public UserAnswerService(DataContext context)
        {
            this.context = context; 
        }


        public List<UserAnswer> setAnswer(List<UserAnswer> answers)
        {
            foreach (UserAnswer answer in answers)
            {
                context.UserAnswers.Add(answer);
            }
            
            context.SaveChanges();
            return answers;
        }
    }
}
