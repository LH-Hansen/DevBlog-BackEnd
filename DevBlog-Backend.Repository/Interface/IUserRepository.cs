using DevBlog_Backend.Repository.Entities;

namespace DevBlog_Backend.Repository.Interface
{
    public interface IUserRepository
    {
        bool CreateUser(User newUser);
        void DeleteUser(Guid id);
        User GetUserById(Guid id);
        List<User> GetUserList();
        bool ValidateLogin(string username, string password);
        void UpdateEmail(Guid id, string newEmail);
        void UpdatePassword(Guid id, string newPassword);
    }
}