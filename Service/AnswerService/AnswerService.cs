using QuestionAPP.Data;

namespace QuestionAPP.Service.AnswerService
{
    public class AnswerService : IAnswerService
    {
        public DataContext context { get; set; }
        public AnswerService(DataContext context)

        {
            this.context = context; 
        }

        
        public void addAnswer(Answer newAnswer)
        {
            context.Answers.Add(newAnswer);
            context.SaveChanges();
        }

        public List<Answer> getAnswers()
        {
           return context.Answers.ToList();
        }
    }
}
