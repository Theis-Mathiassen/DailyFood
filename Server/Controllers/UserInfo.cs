using DailyFood.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using Npgsql;

namespace DailyFood.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserInfoController : ControllerBase
    {
        static HttpClient httpClient = new HttpClient();

        [HttpGet]
        [Route("")]
        //GET api/ControllerName?email="something@somthing.com"&password=xyz
        public async Task<ActionResult<UserInfoController>> Login(string email, string password)
        {


            return null;
        }
        [HttpPost]
        [Route("")]
        public async Task<ActionResult<UserInfoController>> Get(string email, string password)
        {


            return null;
        }


    }
}
