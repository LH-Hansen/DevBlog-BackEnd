﻿namespace DevBlog_Backend.Repository.Enteties
{
    public class Category
    {
        public Guid Id { get; init; }
        public string Name { get; set; }

        public Category(string name)
        {
            Id = new();
            Name = name;
        }
    }
}
