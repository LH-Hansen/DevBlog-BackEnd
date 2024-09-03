using DevBlog_Backend.Repository.Enteties;

namespace DevBlog_Backend.Repository.Entities
{
    public class Post
    {
        public Guid Id { get; init; }
        public string Head { get; set; }
        public string Body { get; set; }
        public User Author { get; init; }
        public List<Tag> Tags { get; set; }
        public Category Category { get; set; }
        public List<Comment> Comments { get; set; }
        public DateTime Timestamp { get; init; }

        public Post(string head, string body, User author, Category category)
        {
            Id = Guid.NewGuid();
            Head = head;
            Body = body;
            Author = author;
            Tags = new List<Tag>();
            Category = category;
            Comments = new List<Comment>();
            Timestamp = DateTime.Now;
        }
    }
}
