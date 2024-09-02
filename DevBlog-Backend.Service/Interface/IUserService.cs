using DevBlog_Backend.Repository.Enteties;

namespace DevBlog_Backend.Service.Interface
{
    public interface IUserService
    {
        bool CreateUser(string username, string password, string email);
        bool DeleteUser(uint id);
        User GetUserById(uint id);
        List<User> GetUserList();
        void UpdateEmail(uint id, string email);
        void UpdatePassword(uint id, string newPassword);
    }
}