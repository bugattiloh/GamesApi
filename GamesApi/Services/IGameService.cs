using System.Collections.Generic;
using System.Threading.Tasks;
using GamesApi.Data;
using GamesApi.Infrastructure.Models;
using GamesApi.Repository;

namespace GamesApi.Services
{
    public interface IGameService
    {
        Task<List<Game>> GetAllGames();
        Task CreateGame(Game game);
        Task SetGameNameById(int id, string name);
        Task DeleteGame(Game game);

        Task<List<Game>> GetGamesWithSameGenre(Genre genre);
    }
}