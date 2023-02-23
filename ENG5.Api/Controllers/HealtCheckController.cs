using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;

namespace ENG5.Api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class HealtCheckController : ControllerBase
    {
        public IActionResult Get()
        {
            return Ok($"{DateTime.UtcNow:o}");
        }
    }
}
