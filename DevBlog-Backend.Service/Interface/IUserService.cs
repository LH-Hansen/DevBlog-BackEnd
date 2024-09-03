using DevBlog_Backend.Repository.DTO;

namespace DevBlog_Backend.Service.Interface
{
    public interface IUserService
    {
        bool CreateUser(string username, string password, string email);
        bool DeleteUser(Guid id);
        UserInfoDTO GetUserById(Guid id);
        List<UserInfoDTO> GetUserList();
        void UpdateEmail(Guid id, string email);
        void UpdatePassword(Guid id, string newPassword);
    }
}