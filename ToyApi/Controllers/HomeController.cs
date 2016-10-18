using System.Web.Http;

namespace ToyApi.Controllers
{
    public class HomeController : ApiController
    {
        [Route("")]
        public string GetHome()
        {
            return "Welcome to Toy API!";
        }
    }
}
