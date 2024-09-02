namespace DevBlog_Backend.Service.Interface
{
    public interface ICategoryService
    {
        bool CreateCategory(string name);
        bool DeleteCategory(Guid id);
    }
}