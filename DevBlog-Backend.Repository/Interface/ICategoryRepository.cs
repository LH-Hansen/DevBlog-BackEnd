using DevBlog_Backend.Repository.Entities;

namespace DevBlog_Backend.Repository.Interface
{
    public interface ICategoryRepository
    {
        bool CreateCategory(Category newCategory);
        void DeleteCategory(Guid id);
        Category GetCategory(Guid id);
    }
}