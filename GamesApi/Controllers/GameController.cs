using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GamesApi.Dto;
using GamesApi.Infrastructure;
using GamesApi.Infrastructure.Models;
using GamesApi.Repository;
using GamesApi.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace GamesApi.Controllers
{
    [ApiController]
    [ApiVersion("1.0")]
    [Route("v{version:apiVersion}/[controller]/[action]")]
    public class GameController : ControllerBase
    {
        private readonly ILogger<GameController> _logger;
        private readonly IGameService _service;


        public GameController(ILogger<GameController> logger, IGameService service)
        {
            _logger = logger;
            _service = service;
        }

        [HttpGet]
        public async Task<List<Game>> Get()
        {
            return await _service.GetAllGames();
        }

        [HttpDelete]
        public async Task DeleteGame(Game game)
        {
            await _service.DeleteGame(game);
        }

        [HttpPost]
        public async Task CreateGame(Game game)
        {
            await _service.CreateGame(game);
        }

        [HttpPut]
        public async Task SetGameNameById(int id, string name)
        {
            await _service.SetGameNameById(id, name);
        }
        
        [HttpGet]
        public async Task GetGamesWithSameGenre(Genre genre)
        {
            await _service.GetGamesWithSameGenre(genre);
        }
        
        
    }
}