﻿using DevBlog_Backend.Repository.Enteties;

namespace DevBlog_Backend.Service.Interface
{
    public interface ICategoryService
    {
        bool CreateCategory(string name);
        void DeleteCategory(Guid id);
        Category GetCategoryById(Guid id);
    }
}