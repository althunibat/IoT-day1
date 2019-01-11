using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Rasp.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Data data )
        {
            await Console.Out.WriteLineAsync($"[{data.Timestamp}] - Humidity: {data.Humidity:F}% - Temperature: {data.Temperature:F}");
            return Ok();
        }
    }

    public class Data
    {
        public double Humidity { get; set; }
        public double Temperature { get; set; }
        public DateTime Timestamp {get;set;}
    }
}
