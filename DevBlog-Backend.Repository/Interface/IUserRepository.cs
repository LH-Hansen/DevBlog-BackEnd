using DevBlog_Backend.Repository.Enteties;

namespace DevBlog_Backend.Repository.Interface
{
    public interface IUserRepository
    {
        void CreateUser(uint id, string username, string password, string email);
        void DeleteUser(uint id);
        User GetUserById(uint id);
        List<User> GetUserList();
        void UpdateEmail(uint id, string newEmail);
        void UpdatePassword(uint id, string newPassword);
    }
}