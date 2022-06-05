using System.Collections.Generic;
using System.Threading.Tasks;
using GamesApi.Infrastructure.Models;

namespace GamesApi.Repository
{
    public interface IGameRepository : IEntityRepository<Infrastructure.Models.Game>
    {
        Task<List<Game>> FindGamesWithSameGenre(Genre genre);
    }
}