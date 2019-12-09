using Learning.CoreMvc.Data.Context;
using Learning.CoreMvc.Data.Models;
using Learning.CoreMvc.DataAccess.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning.CoreMvc.DataAccess.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly ApplicationDbContext applicationDbContext;

        public UserRepository()
        {
            this.applicationDbContext = Activator.CreateInstance<ApplicationDbContext>();
        }

        public async Task<User> CreateAsync(User objectToCreate)
        {
            var result = applicationDbContext.Users.Add(objectToCreate);
            await applicationDbContext.SaveChangesAsync();
            return result.Entity;
        }

        public async Task<User> GetAsync(Guid idOfObject)
        {
            var result = await applicationDbContext.Users.FindAsync(idOfObject);
            return result;
        }

        public IEnumerable<User> GetAllUsers()
        {
            var result = applicationDbContext.Users.ToList();
            return result;
        }

        public void Remove(User objectToRemove)
        {
            applicationDbContext.Remove(objectToRemove);
        }

        public User Update(User objectToUpdate)
        {
            applicationDbContext.Entry(objectToUpdate).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            return objectToUpdate;
        }
    }
}
