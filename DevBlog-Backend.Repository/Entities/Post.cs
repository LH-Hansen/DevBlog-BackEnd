using DevBlog_Backend.Repository.Enteties;

namespace DevBlog_Backend.Repository.Entities
{
    public class Post
    {
        public Guid Id { get; init; }
        public string Title { get; set; }
        public string Content { get; set; }
        public User Author { get; init; }
        public List<Tag> Tag { get; set; }
        public Category Category { get; set; }
        public List<Comment> Comments { get; set; }
        public DateTime Timestamp { get; init; }

        public Post(string title, string content, User author, Category category)
        {
            Id = Guid.NewGuid();
            Title = title;
            Content = content;
            Author = author;
            Tag = new List<Tag>();
            Category = category;
            Comments = new List<Comment>();
            Timestamp = DateTime.Now;
        }
    }
}
