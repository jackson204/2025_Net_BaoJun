using Microsoft.AspNetCore.Mvc;

namespace MVCCourse.Controller;

public class HomeController : Microsoft.AspNetCore.Mvc.Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}
