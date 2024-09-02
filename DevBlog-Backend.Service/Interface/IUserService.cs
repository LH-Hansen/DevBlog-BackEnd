using DevBlog_Backend.Repository.Enteties;

namespace DevBlog_Backend.Service.Interface
{
    public interface IUserService
    {
        bool CreateUser(string username, string password, string email);
        bool DeleteUser(Guid id);
        User GetUserById(Guid id);
        List<User> GetUserList();
        void UpdateEmail(Guid id, string email);
        void UpdatePassword(Guid id, string newPassword);
    }
}