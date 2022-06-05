using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GamesApi.Infrastructure.Models
{
    public class Game
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string StudioName { get; set; }
        public List<Genre> Genres { get; set; } = new List<Genre>();

    }
}