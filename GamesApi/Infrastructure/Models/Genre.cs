using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GamesApi.Infrastructure.Models
{
    public class Genre
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public List<Game> Games { get; set; } = new List<Game>();
    }
}