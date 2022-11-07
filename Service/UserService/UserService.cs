using QuestionAPP.Data;

namespace QuestionAPP.Service.UserService
{
    public class UserService : IUserService
    {
        private readonly DataContext context;
        public UserService(DataContext context)
        {
            this.context = context;
        }


        public  List<User>  getUsers()
        {
            List<User> dbUsers =  context.Users.ToList();
            return dbUsers;
        }

        public User addUser(User newUser)
        {
            Console.WriteLine(newUser);
            context.Add(newUser);
            context.SaveChanges();
            return newUser;
        }

        public User getUser(string email)
        {
            User user = context.Users.First(user => user.email == email);
            return user;
        }
    }
}
