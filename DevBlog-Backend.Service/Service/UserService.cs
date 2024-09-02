using DevBlog_Backend.Repository.Enteties;
using DevBlog_Backend.Repository.Interface;
using DevBlog_Backend.Service.Interface;

namespace DevBlog_Backend.Service.Service
{
    internal class UserService : IUserService
    {
        public readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        { _userRepository = userRepository; }

        public bool CreateUser(string username, string password, string email)
        {
            if (email.Contains("@"))
            {
                User newUser = new(username, password, email);
                _userRepository.CreateUser(newUser);
                return true;
            }
            return false;
        }

        public bool DeleteUser(Guid id)
        {
            if (_userRepository.GetUserById(id) != null)
            {
                _userRepository.DeleteUser(id);

                return true;
            }
            return false;
        }

        public User GetUserById(Guid id)
        {
            return _userRepository.GetUserById(id);
        }

        public List<User> GetUserList()
        { return _userRepository.GetUserList(); }

        public void UpdateEmail(Guid id, string email)
        {
            _userRepository.UpdateEmail(id, email);
        }

        public void UpdatePassword(Guid id, string newPassword)
        {
            _userRepository.UpdatePassword(id, newPassword);
        }
    }
}
