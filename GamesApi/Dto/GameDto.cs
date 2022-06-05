using System.Collections.Generic;

namespace GamesApi.Dto
{
    public class GameDto
    {
        public string Name { get; set; }
        public string StudioName { get; set; }
        public List<GenreDto> GenresDto { get; set; }
    }
}