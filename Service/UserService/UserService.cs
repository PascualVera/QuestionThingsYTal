using Microsoft.EntityFrameworkCore;
using QuestionAPP.Data;
using System.Threading.Tasks;
namespace QuestionAPP.Service.UserService
{
    public class UserService : IUserService
    {
        private readonly DataContext context;
        public UserService(DataContext context)
        {
            this.context = context;
        }


        public async Task<ServiceResponse<List<User>>> getUsers()
        {
           
            List<User> dbUsers = await context.Users.ToListAsync();
            ServiceResponse<List<User>> res = new ServiceResponse<List<User>>();
            res.Data = dbUsers;
            res.Status = 200;
            return res;
        }

        public async Task<ServiceResponse<User>> addUser(User newUser)
        {
            
            context.Add(newUser);
            await context.SaveChangesAsync();

            ServiceResponse<User> res = new ServiceResponse<User>();

            res.Data = newUser;
            res.Status = 200;
            return res;
        }

        public async Task<ServiceResponse<User>> getUser(User user)
        {
            User loggedUser = context.Users.FirstOrDefault(u => u.email == user.email);
            ServiceResponse<User> res = new ServiceResponse<User>();
            if (loggedUser != null)
            {
                res.Data = loggedUser;
                res.Status = 200;
            }
            else
            {
                res.Data = null;
                res.Status = 404;
            }
           
            return res;
        }
    }
}
