using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
using WebsiteLinks.Dto;

namespace WebsiteLinks.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Website : ControllerBase
    {
        private readonly ILogger<Website> _logger;

        public Website(ILogger<Website> logger)
        {
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }


        [HttpGet]
        public async Task<ActionResult<IEnumerable<WebsiteGetDto>>> GetWebsiteList()
        {
            _logger.LogInformation($"Match method {nameof(GetWebsiteList)}");

            return Ok();
        }

        [HttpGet("{url}")]
        public async Task<ActionResult<WebsiteGetDto>> GetWebsiteInfo(
            [FromRoute]
            [Url]
            Uri url,
            [FromQuery]
            bool request = false
        )
        {

            return await Ok();
        }
    }
}
