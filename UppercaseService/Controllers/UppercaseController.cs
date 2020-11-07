using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace UppercaseService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UppercaseController : ControllerBase
    {
        [HttpGet]
        public ActionResult<string> Get(string sentence)
        {
            return sentence.ToUpper();
        }
    }
}
