using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace QuestionAPP.Models
{
    public class ServiceResponse<T>
    {
        public ServiceResponse()
        {

        }
        public T Data { get; set; }
        public int Status { get; set; }  
        
    }
}
