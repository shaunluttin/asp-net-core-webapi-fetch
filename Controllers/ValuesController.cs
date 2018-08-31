using System;
using Microsoft.AspNetCore.Mvc;

namespace temp01.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        public class MyModel 
        {
            public int Id { get; set; }
            public DateTime FromDate { get; set; }
        }

        // PUT api/values/
        [HttpPut()]
        public ActionResult Put([FromBody] MyModel value)
        {
            return new JsonResult(value);
        }

    }
}
