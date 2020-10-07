using Microsoft.AspNetCore.Mvc;

namespace DockerAPI.Controllers
{
    [ApiController]
    public class BlaController : ControllerBase
    {
        public BlaController()
        {
            
        }

        [HttpGet]
        [Route("[controller]/[action]")]
        public string Hello()
        {
            string returnStr = "hello there all";
            return returnStr;
        }
    }
}