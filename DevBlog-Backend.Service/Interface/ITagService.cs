namespace DevBlog_Backend.Service.Interface
{
    public interface ITagService
    {
        bool CreateTag(string name);
        bool DeleteTag(Guid id);
    }
}