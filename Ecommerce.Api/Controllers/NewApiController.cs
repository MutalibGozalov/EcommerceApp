using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Ecommerce.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class NewApiController : ControllerBase
    {
        [HttpGet]
        public ActionResult<List<string>> GetData()
        {
            ModelDto myModel = new ModelDto
            {
                Id = 1,
                MyProperty = "property value"
            };

            return Ok(new List<string>{"oewnfwn", "woejfow", "efwonfw"});
        }
    }
    public class ModelDto
    {
        public int Id {get; set;}
        public string? MyProperty {get; set;}

    }
}