﻿using DevBlog_Backend.Repository.DTO;
using DevBlog_Backend.Repository.Entities;
using DevBlog_Backend.Repository.Interface;
using DevBlog_Backend.Service.Interface;

namespace DevBlog_Backend.Service.Service
{
    internal class UserService : IUserService
    {
        public readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        { _userRepository = userRepository; }

        public bool CreateUser(string username, string password, string email)
        {
            if (email.Contains("@"))
            {
                User newUser = new(username, password, email);
                if (_userRepository.CreateUser(newUser))
                    return true;
            }
            return false;
        }

        public bool DeleteUser(Guid id)
        {
            if (_userRepository.GetUserById(id) != null)
            {
                _userRepository.DeleteUser(id);
                return true;
            }
            return false;
        }

        public UserInfoDTO GetUserById(Guid id)
        { return CreateUserInfoDTO(_userRepository.GetUserById(id)); }

        public List<UserInfoDTO> GetUserList()
        { return CreateUserInfoDTOList(_userRepository.GetUserList()); }

        public void UpdateEmail(Guid id, string email)
        { _userRepository.UpdateEmail(id, email); }

        public void UpdatePassword(Guid id, string newPassword)
        { _userRepository.UpdatePassword(id, newPassword); }

        public bool ValidateLogin(string username, string password)
        { return _userRepository.ValidateLogin(username, password); }

        //DTO
        private UserInfoDTO CreateUserInfoDTO(User user)
        {
            return new UserInfoDTO()
            {
                Id = user.Id,
                UserName = user.Username,
                Email = user.Email
            };
        }

        private List<UserInfoDTO> CreateUserInfoDTOList(List<User> userList)
        {
            List<UserInfoDTO> userInforDTOList = new();

            foreach (User user in userList)
            {
                userInforDTOList.Add(CreateUserInfoDTO(user));
            }
            return userInforDTOList;
        }
    }
}
