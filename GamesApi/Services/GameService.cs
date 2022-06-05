using System.Collections.Generic;
using System.Threading.Tasks;
using GamesApi.Infrastructure.Models;
using GamesApi.Repository;

namespace GamesApi.Services
{
    public class GameService: IGameService
    {
        private readonly IGameRepository _gameRepository;

        public GameService(IGameRepository gameRepository)
        {
            _gameRepository = gameRepository;
        }

        public async Task<List<Game>> GetAllGames()
        {
            return await _gameRepository.Read();
        }

        public async Task CreateGame(Game game)
        {
            await _gameRepository.Create(game);
        }

        public async Task SetGameNameById(int id, string name)
        {
            await _gameRepository.Update(id, name);
        }

        public async Task DeleteGame(Game game)
        {
            await _gameRepository.Delete(game);
        }

        public async Task<List<Game>> GetGamesWithSameGenre(Genre genre)
        {
            return await _gameRepository.FindGamesWithSameGenre(genre);
        }
    }
}