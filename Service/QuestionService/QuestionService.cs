using QuestionAPP.Data;

namespace QuestionAPP.Service.QuestionService
{
    public class QuestionService : IQuestionService
    {

        public DataContext context { get; set; }
        
       

        public QuestionService(DataContext context)
        {
                this.context = context; 
        }


        public Question addQuestion(Question newQuestion)
        {
            context.Questions.Add(newQuestion);
            foreach (Answer answer in newQuestion.Answer)
            {
                context.Answers.Add(answer);
                

            }
            
            context.SaveChanges();  
            return newQuestion;
        }

        public List<Question> GetAllQuestions()
        {
            return context.Questions.ToList();
        }

        public Question GetById(int id)
        {
             Question newQuestion = context.Questions.First(x => x.Id == id);

             return newQuestion;
        }
    }



}
