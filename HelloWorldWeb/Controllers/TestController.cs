using Microsoft.AspNetCore.Mvc;

namespace HelloWorldWeb.Controllers
{
    [Route("my/test/")]
    public class TestController : Controller
    {
        [Route("show")]
        public string Index()
        {
            return "Test Index method";
        }
        
        [Route("details/{id}")]
        public string Details(string id)
        {
            return "ID Value = " + id;
        }
    }
}