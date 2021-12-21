using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;

namespace ErHaSolution.Controllers
{
    [Route("employee")]
    public class EmployeeController : ControllerBase
    {

        //[Route("")]
        //public string Metodo()
        //{
        //    return "oi";
        //}

        [HttpGet]
        [Route("")]
        public string Get()
        {
            return "oi";
        }

        [HttpPost]
        [Route("")]
        public string Post()
        {
            return "oi";
        }

        [HttpPut]
        [Route("")]
        public string Put()
        {
            return "oi";
        }

        [HttpDelete]
        [Route("")]
        public string Delete()
        {
            return "oi";
        }

    }
}
