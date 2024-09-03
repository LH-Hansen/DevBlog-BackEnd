namespace DevBlog_Backend.Repository.Enteties
{
    public class Comment
    {
        public Guid Id { get; init; }
        public User Author { get; set; }
        public string Content { get; set; }
        public DateTime TimeStamp { get; set; }

        public Comment(User author, string content)
        {
            Id = new();
            Author = author;
            Content = content;
            TimeStamp = DateTime.Now;
        }
    }
}
