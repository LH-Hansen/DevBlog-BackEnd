using DevBlog_Backend.Repository.Enteties;

namespace DevBlog_Backend.Repository.Interface
{
    public interface IUserRepository
    {
        void CreateUser(User newUser);
        void DeleteUser(Guid id);
        User GetUserById(Guid id);
        List<User> GetUserList();
        void UpdateEmail(Guid id, string newEmail);
        void UpdatePassword(Guid id, string newPassword);
    }
}