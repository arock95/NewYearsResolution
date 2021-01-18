using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NewYearsResolutionShared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewYearsResolutionAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ResolutionsController : ControllerBase
    {
        public IActionResult AddResolution(Resolution res)
        {
            if (ModelState.IsValid)
            {
                // write to db
                return Ok();
            }
            else
            {
                return BadRequest();
            }
        }
    }
}
