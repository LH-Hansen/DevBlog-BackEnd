namespace DevBlog_Backend.Repository.Enteties
{
    public class User
    {
        public uint Id { get; set; }
        public bool IsAdmin { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public User(uint id, string username, string email, string password)
        {
            Id = id;
            IsAdmin = false;
            Username = username;
            Email = email;
            Password = password;
        }
    }
}
