using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreVideo.Controllers
{
    [Route("company/[controller]/[action]")]
    public class EmployeeController : Controller
    {
        public string Index()
        {
            return "Hello from Index";
        }

        public ContentResult Name()
        {
            return Content("Minh");
        }
        
        public string Country()
        {
            return "VietNam";
        }
    }
}