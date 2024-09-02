using DevBlog_Backend.Repository.Enteties;
using DevBlog_Backend.Repository.Interface;

namespace DevBlog_Backend.Repository.Repository
{
    public class UserRepository : IUserRepository
    {
        private List<User> _users = new();

        private uint _accountsCreated = 0;

        public void CreateUser(string username, string password, string email)
        {
            User newUser = new(_accountsCreated, username, email, password);

            _users.Add(newUser);
            _accountsCreated++;
        }

        public List<User> GetUserList() { return _users; }

        public User GetUserById(uint id)
        {
            return (User)_users.Where(x => x.Id.Equals(id));
        }
        public void UpdateEmail(uint id, string newEmail)
        {
            _users.FirstOrDefault(x => x.Id.Equals(id)).Email = newEmail;
        }

        public void UpdatePassword(uint id, string newPassword)
        {
            _users.FirstOrDefault(x => x.Id.Equals(id)).Password = newPassword;
        }

        public void DeleteUser(uint id)
        {
            if (UserExist(id))
                _users.Remove(_users.FirstOrDefault(x => x.Id.Equals(id)));
        }

        private bool UserExist(uint id)
        {
            foreach (User user in _users)
            {
                if (user.Id == id) return true;
            }

            return false;
        }
    }
}
