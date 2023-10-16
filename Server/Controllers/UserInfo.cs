using DailyFood.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using Npgsql;

namespace DailyFood.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserInfo : ControllerBase
    {
        static HttpClient httpClient = new HttpClient();

        [HttpGet]
        [Route("")]
        //GET api/ControllerName?email="something@somthing.com"&p5=5
        public async Task<ActionResult<UserInfo>> Get(string email)
        {
            Npgsql.
        }


    }
}
