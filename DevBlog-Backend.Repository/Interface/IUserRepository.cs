﻿using DevBlog_Backend.Repository.Enteties;

namespace DevBlog_Backend.Repository.Interface
{
    public interface IUserRepository
    {
        bool CreateUser(string username, string password, string email);
        bool DeleteUser(uint id);
        User GetUserById(uint id);
        List<User> GetUserList();
        void UpdateEmail(uint id, string newEmail);
        void UpdatePassword(uint id, string newPassword);
    }
}