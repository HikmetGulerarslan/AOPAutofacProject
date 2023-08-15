using AOP.Business.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace CoreMvcExample.Controllers
{
    public class HomeController : Controller
    {

        private IExample example;
        public HomeController(IExample example)
        {
            this.example = example;
        }   

        public IActionResult Index()
        {
            return Content(example.ExampleMethod());
        }

       
    }
}
