using Learning.CoreMvc.DataAccess.Repositories;
using Learning.CoreMvc.DataAccess.Repositories.Interfaces;

namespace Learning.CoreMvc.Business
{
    public class UserManager
    {
        private readonly IUserRepository userRepository;

        public UserManager(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }
    }
}
