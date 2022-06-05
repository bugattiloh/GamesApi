using System.Collections.Generic;
using System.Threading.Tasks;

namespace GamesApi.Repository
{
    public interface IEntityRepository<T> where T : class, new()
    {
        Task Create(T entity);
        Task<List<T>> Read();
        Task Update(int id, string name);
        
        Task Delete(T entity);
    }
}