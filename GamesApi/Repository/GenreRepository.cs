using System.Collections.Generic;
using System.Threading.Tasks;
using GamesApi.Data;
using GamesApi.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;

namespace GamesApi.Repository
{
    public class GenreRepository : IEntityRepository<Genre>
    {
        private readonly GameContext _context;

        public GenreRepository(GameContext context)
        {
            _context = context;
        }

        public async Task Create(Genre genre)
        {
            _context.Add(genre);
            await _context.SaveChangesAsync();
        }

        public async Task<List<Genre>> Read()
        {
            return await _context.Genres.ToListAsync();
        }

        public async Task Update(int id, string name)
        {
            var game = await _context.Genres.SingleOrDefaultAsync(g => g.Id == id);
            game.Name = name;
            await _context.SaveChangesAsync();
        }

        public async Task Delete(Genre genre)
        {
            _context.Genres.Remove(genre);
            await _context.SaveChangesAsync();
        }
    }
}