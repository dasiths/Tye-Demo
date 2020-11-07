﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace UppercaseService.Controllers
{
    [ApiController]
    [Route("")]
    public class UppercaseController : ControllerBase
    {
        private readonly ILogger<UppercaseController> _logger;

        public UppercaseController(ILogger<UppercaseController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public ActionResult<string> Get(string sentence)
        {
            _logger.LogInformation($"{GetType().Name} triggered with sentence={sentence}");
            return sentence.ToUpper();
        }
    }
}
