namespace DevBlog_Backend.Repository.Entities
{
    public class Tag
    {
        public Guid Id { get; init; }
        public string Name { get; set; }

        public Tag(string name)
        {
            Id = new();
            Name = name;
        }
    }
}
