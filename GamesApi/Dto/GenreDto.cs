using System.Collections.Generic;

namespace GamesApi.Dto
{
    public class GenreDto
    {
        public string Name { get; set; }

        public List<GameDto> Games { get; set; }
    }
}