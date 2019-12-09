using Learning.CoreMvc.Data.Models.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace Learning.CoreMvc.DataAccess.Repositories.Interfaces
{
    /// <summary>
    /// Create Read Update and Delete operations over T object, where T is inherited from IBaseEntity
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <typeparam name="TKey"></typeparam>
    /// <typeparam name="TContext"></typeparam>
    public interface ICrudRepository<T, TKey, TContext>
        where T: IBaseEntity<TKey>
        where TContext : DbContext
    {

        Task<T> CreateAsync(T objectToCreate);
        Task<T> GetAsync(TKey idOfObject);
        T Update(T objectToUpdate);
        void Remove(T objectToRemove);
    }
}
