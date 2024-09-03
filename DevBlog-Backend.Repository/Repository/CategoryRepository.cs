using DevBlog_Backend.Repository.Entities;
using DevBlog_Backend.Repository.Interface;

namespace DevBlog_Backend.Repository.Repository
{
    internal class CategoryRepository : ICategoryRepository
    {
        public List<Category> _categoryList = new();

        public bool CreateCategory(Category newCategory)
        {
            if (!CheckIfCategoryNameExists(newCategory.Name))
            {
                _categoryList.Add(newCategory);
                return true;
            }
            return false;
        }

        public void DeleteCategory(Guid id)
        { _categoryList.Remove(_categoryList.FirstOrDefault(c => c.Id.Equals(id))); }

        public Category GetCategory(Guid id)
        { return _categoryList.FirstOrDefault(c => c.Id.Equals(id)); }

        private bool CheckIfCategoryNameExists(string name)
        {
            foreach (Category category in _categoryList)
            {
                if (category.Name == name)
                    return true;
            }
            return false;
        }
    }
}
