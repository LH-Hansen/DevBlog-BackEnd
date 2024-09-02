using DevBlog_Backend.Repository.Enteties;
using DevBlog_Backend.Repository.Interface;

namespace DevBlog_Backend.Repository.Repository
{
    internal class UserRepository : IUserRepository
    {
        private List<User> _userList = new();

        private uint _accountsCreated = 0;

        public void CreateUser(string username, string password, string email)
        {
            User newUser = new(_accountsCreated, username, email, password);

            _userList.Add(newUser);
            _accountsCreated++;
        }

        public List<User> GetUserList() { return _userList; }

        public User GetUserById(uint id)
        {
            return (User)_userList.Where(u => u.Id.Equals(id));
        }
        public void UpdateEmail(uint id, string newEmail)
        {
            _userList.FirstOrDefault(u => u.Id.Equals(id)).Email = newEmail;
        }

        public void UpdatePassword(uint id, string newPassword)
        {
            _userList.FirstOrDefault(u => u.Id.Equals(id)).Password = newPassword;
        }

        public void DeleteUser(uint id)
        {
            if (UserExist(id))
                _userList.Remove(_userList.FirstOrDefault(u => u.Id.Equals(id)));
        }

        private bool UserExist(uint id)
        {
            foreach (User user in _userList)
            {
                if (user.Id == id) return true;
            }

            return false;
        }
    }
}
