
using System.Threading.Tasks;
namespace QuestionAPP.Service.UserService

{
    public interface IUserService
    {
        public Task<ServiceResponse<User>> addUser(User newUser);
        public Task<ServiceResponse<List<User>>> getUsers();

        public Task<ServiceResponse<User>> getUser(User user);
    }

}
