using Learning.CoreMvc.Data.Context;
using Learning.CoreMvc.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Learning.CoreMvc.DataAccess.Repositories.Interfaces
{
    public interface IUserRepository : ICrudRepository<User, Guid>
    {
        IEnumerable<User> GetAllUsers();
    }
}
