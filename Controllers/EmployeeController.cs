using Microsoft.AspNetCore.Mvc;

namespace ErHaSolution.Controllers
{
    [Route("employee")]
    public class EmployeeController : ControllerBase
    {
        
        public EmployeeController()
        {
            
        }

        [Route("/")]
        public string Metodo()
        {
            return "oi";
        }
    }
}
