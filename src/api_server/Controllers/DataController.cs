using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace api_server.Controllers
{
    //API ARCHITECTURE
    //Under api/diff we have a page that returns the difference
    //  between the given version and the current version
    //Under api/data/{ID} we have the text based data for a product
    //Under api/data/{ID}.png we have the image for a product
    [Route("api/[controller]")]
    [ApiController]
    public class DataController : ControllerBase
    {
        [HttpGet("{id}")]
        public ActionResult<String> GetProductData(String id)
        {
            return id;
        }
    }
}
