namespace DevBlog_Backend.Service.Interface
{
    internal interface ICategoryService
    {
        bool CreateCategory(string name);
        bool DeleteCategory(Guid id);
    }
}