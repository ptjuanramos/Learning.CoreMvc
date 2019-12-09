using Learning.CoreMvc.Data.Models;
using Learning.CoreMvc.DataAccess.Repositories;
using Learning.CoreMvc.DataAccess.Repositories.Interfaces;
using System.Collections.Generic;

namespace Learning.CoreMvc.Business
{
    public class UserManager
    {
        private readonly IUserRepository userRepository;

        public UserManager(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }

        public IEnumerable<User> GetAllUsers()
        {
            return userRepository.GetAllUsers();
        }
    }
}
