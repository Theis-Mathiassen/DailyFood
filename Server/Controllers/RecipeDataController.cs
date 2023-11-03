using DailyFood.Shared;
using Microsoft.AspNetCore.Mvc;
using System;

namespace DailyFood.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RecipeDataController : ControllerBase
    {
        static HttpClient httpClient = new HttpClient();
        private readonly ILogger<RecipeDataController> _logger;

        public RecipeDataController(ILogger<RecipeDataController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public async Task<ActionResult<RecipeData>> GetAll()
        {
            var requestMessage = new HttpRequestMessage(HttpMethod.Get, "http://3637.dk/godmadApi/getAllRecipeData.php");
            requestMessage.Headers.Add("Accept", "application/json, text/plain, */*");

            HttpResponseMessage response = await httpClient.SendAsync(requestMessage);
            if (response.IsSuccessStatusCode == false)
            {
                return BadRequest(response.StatusCode);
            }

            RecipeData? result = await response.Content.ReadFromJsonAsync<RecipeData>();

            if (result == null)
            {
                return BadRequest("null");
            }

            return result;
        }


    }
}