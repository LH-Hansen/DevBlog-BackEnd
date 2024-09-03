namespace DevBlog_Backend.Repository.Entities
{
    public class Comment
    {
        public Guid Id { get; init; }
        public User Author { get; set; }
        public string Body { get; set; }
        public DateTime TimeStamp { get; set; }

        public Comment(User author, string body)
        {
            Id = new();
            Author = author;
            Body = body;
            TimeStamp = DateTime.Now;
        }
    }
}
