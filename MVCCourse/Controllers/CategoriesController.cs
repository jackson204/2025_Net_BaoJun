using Microsoft.AspNetCore.Mvc;

namespace MVCCourse.Controllers;

public class CategoriesController : Controller
{
    public IActionResult Edit(int? id)
    {
        if (id == null)
        {
            return new ContentResult
            {
                Content = "No ID provided"
            };
        }

        return new ContentResult
        {
            Content = id.ToString()
        };
    }

    // GET
    public IActionResult Index()
    {
        return View();
    }
}
