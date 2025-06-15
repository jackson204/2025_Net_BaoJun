using Microsoft.AspNetCore.Mvc;
using MVCCourse.Models;

namespace MVCCourse.Controllers;

public class CategoriesController : Controller
{
    public IActionResult Edit(int? id)
    {
        var category = new Category()
        {
            CategoryId = id ?? 0,
            Name = "Category " + (id ?? 0),
            Description = "Description for category " + (id ?? 0)
        };
        return View(category);
    }

    // GET
    public IActionResult Index()
    {
        var categories = CategoriesRepository.GetCategories();
        return View(categories);
    }
}
