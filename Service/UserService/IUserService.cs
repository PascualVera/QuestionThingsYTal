namespace QuestionAPP.Service.UserService
{
    public interface IUserService
    {
        public User addUser(User newUser);
        public List<User> getUsers();

        public User getUser(String email);
    }

}
