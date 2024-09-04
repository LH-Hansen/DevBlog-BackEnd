using DevBlog_Backend.Repository.Entities;
using DevBlog_Backend.Repository.Interface;
using DevBlog_Backend.Service.Interface;

namespace DevBlog_Backend.Service.Service
{
    internal class CategoryService : ICategoryService
    {
        public readonly ICategoryRepository _categoryRepository;

        public CategoryService(ICategoryRepository categoryRepository)
        { _categoryRepository = categoryRepository; }

        public bool CreateCategory(string name)
        {
            Category newCategory = new(name);

            return _categoryRepository.CreateCategory(newCategory);
        }

        public void DeleteCategory(Guid id) => _categoryRepository.DeleteCategory(id);

        public Category GetCategoryById(Guid id) => _categoryRepository.GetCategory(id);
    }
}
