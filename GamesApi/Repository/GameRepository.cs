using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GamesApi.Data;
using GamesApi.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;

namespace GamesApi.Repository
{
    public class GameRepository : IGameRepository
    {
        private readonly GameContext _context;

        public GameRepository(GameContext context)
        {
            _context = context;
        }

        public async Task Create(Game game)
        {
            _context.Add(game);
            await _context.SaveChangesAsync();
        }

        public async Task<List<Game>> Read()
        {
            return await _context.Games.ToListAsync();
        }

        public async Task Update(int id, string name)
        {
            var game = await _context.Games.SingleOrDefaultAsync(g => g.Id == id);
            game.Name = name;
            await _context.SaveChangesAsync();
        }

        public async Task Delete(Game game)
        {
            _context.Games.Remove(game);
            await _context.SaveChangesAsync();
        }

        public async Task<List<Infrastructure.Models.Game>> FindGamesWithSameGenre(Genre genre)
        {
            var games = await _context.Games.Where(game => game.Genres.Any(g => g.Id == genre.Id)).ToListAsync();
            return games;
        }
    }
}