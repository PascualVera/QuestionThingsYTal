namespace QuestionAPP.Service.AnswerService
{
    public interface IAnswerService
    {
        public void addAnswer(Answer newAnswer);
        public List<Answer> getAnswers();

    }
}
