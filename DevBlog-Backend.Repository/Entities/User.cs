namespace DevBlog_Backend.Repository.Enteties
{
    public class User
    {
        public Guid Id { get; set; }
        public bool IsAdmin { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public User(string username, string email, string password)
        {
            Id = new();
            IsAdmin = false;
            Username = username;
            Email = email;
            Password = password;
        }
    }
}
