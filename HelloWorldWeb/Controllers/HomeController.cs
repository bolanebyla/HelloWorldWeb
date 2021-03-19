using Microsoft.AspNetCore.Mvc;

namespace HelloWorldWeb.Controllers
{
    public class HomeController : Controller
    {
        // GET
        public string Index(string id)
        {
            return "ID Value = " + id;
        }
    }
}