using DevBlog_Backend.Repository.Enteties;
using DevBlog_Backend.Repository.Interface;

namespace DevBlog_Backend.Service.Service
{
    internal class CategoryService
    {
        public readonly ICategoryRepository _categoryRepository;

        public CategoryService(ICategoryRepository categoryRepository)
        { _categoryRepository = categoryRepository; }

        public bool CreateCategory(string name)
        {
            Category newCategory = new(name);

            return _categoryRepository.CreateCategory(newCategory);
        }

        public bool DeleteCategory(Guid id)
        {
            return _categoryRepository.DeleteCategory(id);
        }
    }
}
