using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace TitlecaseService.Controllers
{
    [ApiController]
    [Route("")]
    public class TitlecaseController : ControllerBase
    {
        private readonly ILogger<TitlecaseController> _logger;

        public TitlecaseController(ILogger<TitlecaseController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public ActionResult<string> Get(string sentence)
        {
            _logger.LogInformation($"{GetType().Name} triggered with sentence={sentence}");
            return CultureInfo.CurrentCulture.TextInfo.ToTitleCase(sentence);
        }
    }
}
