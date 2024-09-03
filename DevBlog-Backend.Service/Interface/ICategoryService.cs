namespace DevBlog_Backend.Service.Interface
{
    public interface ICategoryService
    {
        bool CreateCategory(string name);
        void DeleteCategory(Guid id);
        ICategoryService GetCategoryById(Guid id);
    }
}