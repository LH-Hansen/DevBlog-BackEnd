using DevBlog_Backend.Repository.Enteties;
using DevBlog_Backend.Repository.Interface;

namespace DevBlog_Backend.Repository.Repository
{
    internal class UserRepository : IUserRepository
    {
        private List<User> _userList = new();

        public void CreateUser(User newUser)
        {
            _userList.Add(newUser);
        }

        public List<User> GetUserList()
        { return _userList; }

        public User GetUserById(Guid id)
        {
            return _userList.FirstOrDefault(u => u.Id.Equals(id));
        }
        public void UpdateEmail(Guid id, string newEmail)
        {
            _userList.FirstOrDefault(u => u.Id.Equals(id)).Email = newEmail;
        }

        public void UpdatePassword(Guid id, string newPassword)
        {
            _userList.FirstOrDefault(u => u.Id.Equals(id)).Password = newPassword;
        }

        public void DeleteUser(Guid id)
        {
            if (UserExist(id))
                _userList.Remove(_userList.FirstOrDefault(u => u.Id.Equals(id)));
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
