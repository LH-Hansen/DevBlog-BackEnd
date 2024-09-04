using DevBlog_Backend.Repository.Entities;

namespace DevBlog_Backend.Repository.Interface
{
    public interface IUserRepository
    {
        bool CreateUser(User newUser);
        bool DeleteUser(Guid id);
        User GetUserById(Guid id);
        List<User> GetUserList();
        bool ValidateLogin(string username, string password);
        bool UpdateEmail(Guid id, string newEmail);
        bool UpdatePassword(Guid id, string newPassword);
    }
}