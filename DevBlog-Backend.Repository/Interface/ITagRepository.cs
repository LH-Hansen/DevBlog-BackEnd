using DevBlog_Backend.Repository.Entities;

namespace DevBlog_Backend.Repository.Interface
{
    public interface ITagRepository
    {
        bool CreateTag(Tag newTag);
        bool DeleteTag(Guid id);
    }
}