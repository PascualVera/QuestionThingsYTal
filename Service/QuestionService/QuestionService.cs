using QuestionAPP.Data;
using QuestionAPP.Migrations;

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
            List<Question> questionsDb = context.Questions.ToList();

            foreach (Question question in questionsDb)
            {
                List<Answer> answersDb = context.Answers.ToList();
                List<Answer> questionAnswer = answersDb.FindAll(answer => answer == question.Answer); ;

            }
            return context.Questions.ToList();
        }

        public Question GetById(int id)
        {
             Question newQuestion = context.Questions.First(x => x.Id == id);

             return newQuestion;
        }

        public List<UserAnswer> getAllAnswerInQuestion(int id)
        {
            Question question = GetById(id);

            List<UserAnswer> userAnswerDb = context.UserAnswers.ToList();

            return userAnswerDb.Where(answer => answer.QuestionId == question.Id).ToList();
            



        }

       
    }



}   
