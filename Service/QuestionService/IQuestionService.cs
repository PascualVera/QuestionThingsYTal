namespace QuestionAPP.Service.QuestionService
{
    public interface IQuestionService
    {
        public List<Question> GetAllQuestions();    

        public Question GetById(int id);
        public Question addQuestion(Question newQuestion);


    }
}
