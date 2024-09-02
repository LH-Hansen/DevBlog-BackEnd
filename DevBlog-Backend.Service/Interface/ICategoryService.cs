
namespace DevBlog_Backend.Service.Service
{
    internal interface ICategoryService
    {
        bool CreateCategory(string name);
        bool DeleteCategory(Guid id);
    }
}