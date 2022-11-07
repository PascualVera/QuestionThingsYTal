namespace QuestionAPP.Models
{
    public class UserAnswer
    {
        public int Id { get; set; }     
        public int UserId { get; set; }
        public int QuestionId { get; set; }  
        
        public string Answer { get; set; }  
    }
}
