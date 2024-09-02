using DevBlog_Backend.Repository.Enteties;
using DevBlog_Backend.Repository.Interface;
using DevBlog_Backend.Service.Interface;

namespace DevBlog_Backend.Service.Service
{
    public class UserService : IUserService
    {
        public readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        { _userRepository = userRepository; }

        public bool CreateUser(string username, string password, string email)
        {
            if (email.Contains("@"))
            {
                _userRepository.CreateUser(username, password, email);
                return true;
            }

            return false;
        }

        public bool DeleteUser(uint id)
        {
            if (_userRepository.GetUserById(id) != null)
            {
                _userRepository.DeleteUser(id);

                return true;
            }

            return false;
        }

        public User GetUserById(uint id)
        {
            return _userRepository.GetUserById(id);
        }

        public List<User> GetUserList()
        { return _userRepository.GetUserList(); }

        public void UpdateEmail(uint id, string email)
        {
            _userRepository.UpdateEmail(id, email);
        }

        public void UpdatePassword(uint id, string newPassword)
        {
            _userRepository.UpdatePassword(id, newPassword);
        }
    }
}
