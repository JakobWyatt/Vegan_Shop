using System;
using Microsoft.AspNetCore.Mvc;

namespace api_server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DiffController : ControllerBase
    {
        [HttpGet]
        public ActionResult<String> GetDiff()
        {
            return "Diff functionality has not been implemented.";
        }
    }
}
