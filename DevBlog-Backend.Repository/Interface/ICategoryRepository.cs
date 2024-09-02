using DevBlog_Backend.Repository.Enteties;

namespace DevBlog_Backend.Repository.Interface
{
    public interface ICategoryRepository
    {
        bool CreateCategory(Category newCategory);
        bool DeleteCategory(Guid id);
        bool CheckIfCategoryNameExists(string name);
    }
}