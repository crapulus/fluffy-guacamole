using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using StackExchange.Redis;

namespace netcoreapp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class dbController : ControllerBase
    {
        private readonly ILogger<dbController> _logger;    

        public dbController(ILogger<dbController> logger, IDatabase db)
        {
            _logger = logger;          
        }

        [HttpGet]
        public string Get()
        {
            return "Hello";
        // var db = redis.getDatabase();
        //  return db.StringGet("DEMO:app2");
        }
    }
}
