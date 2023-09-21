using DailyFood.Shared;
using Microsoft.AspNetCore.Mvc;
using System;

namespace DailyFood.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RecipeDataController : ControllerBase
    {
        private readonly ILogger<RecipeDataController> _logger;

        public RecipeDataController(ILogger<RecipeDataController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public RecipeData GetAll()
        {
            RecipeData result = ;
            return result;
        }


    }
}