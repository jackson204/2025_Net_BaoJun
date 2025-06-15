using Microsoft.AspNetCore.Mvc;
using MVCCourse.Models;

namespace MVCCourse.Controllers;

public class CategoriesController : Controller
{
    public IActionResult Edit(int? id)
    {
        var category = CategoriesRepository.GetCategoryById( id ?? 0);
        return View(category);
    }

    // GET
    public IActionResult Index()
    {
        var categories = CategoriesRepository.GetCategories();
        return View(categories);
    }
}
