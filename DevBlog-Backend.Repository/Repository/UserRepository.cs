using DevBlog_Backend.Repository.Entities;
using DevBlog_Backend.Repository.Interface;

namespace DevBlog_Backend.Repository.Repository
{
    internal class UserRepository : IUserRepository
    {
        private List<User> _userList = new();

        public bool CreateUser(User newUser)
        {
            if (!UserEmailExists(newUser.Email) && UsernameExist(newUser.Username))
            {
                _userList.Add(newUser);
                return true;
            }
            return false;
        }

        public List<User> GetUserList()
        { return _userList; }

        public User GetUserById(Guid id)
        { return _userList.FirstOrDefault(u => u.Id.Equals(id)); }
        
        public bool UpdateEmail(Guid id, string newEmail)
        {
            if (UserExist(id))
            {
                _userList.FirstOrDefault(u => u.Id.Equals(id)).Email = newEmail;
                return true;
            }
            return false;
        }

        public bool UpdatePassword(Guid id, string newPassword)
        {
            if (UserExist(id))
            {
                _userList.FirstOrDefault(u => u.Id.Equals(id)).Password = newPassword;
                return true;
            }
            return false;
        }

        public bool DeleteUser(Guid id)
        {
            if (UserExist(id))
            {
                _userList.Remove(_userList.FirstOrDefault(u => u.Id.Equals(id)));
                return true;
            }
            return false;
        }

        private bool UsernameExist(string username)
        {
            foreach (User user in _userList)
            {
                if (user.Username.Equals(username)) return true;
            }
            return false;
        }

        public bool ValidateLogin(string username, string password)
        {
            foreach (User user in _userList)
            {
                if (user.Username.Equals(username) && user.Password.Equals(password))
                    return true;
            }
            return false;
        }

        private bool UserEmailExists(string email)
        {
            foreach (User user in _userList)
            {
                if (user.Email.Equals(email)) return true;
            }
            return false;
        }

        private bool UserExist(Guid id)
        {
            foreach (User user in _userList)
            {
                if (user.Id == id) return true;
            }
            return false;
        }
    }
}
