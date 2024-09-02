namespace DevBlog_Backend.Repository.Enteties
{
    public class Comment
    {
        public uint Id { get; set; }
        public User Author { get; set; }
        public string Content { get; set; }
        public DateTime TimeStamp { get; set; }

        public Comment(uint id, User author, string content)
        {
            Id = id;
            Author = author;
            Content = content;
            TimeStamp = DateTime.Now;
        }
    }
}
