using Microsoft.AspNetCore.Mvc;
using MVCCourse.Models;

namespace MVCCourse.Controllers;

public class CategoriesController : Controller
{
    public IActionResult Add()
    {
        return View();
    }

    public IActionResult Delete(int? categoryId)
    {
        CategoriesRepository.DeleteCategory(categoryId ?? 0);
        return RedirectToAction(nameof(Index));
    }

    [HttpPost]
    public IActionResult Add(Category category)
    {
        if (!ModelState.IsValid)
        {
            return View(category);
        }
        CategoriesRepository.AddCategory(category);
        return RedirectToAction(nameof(Index));
    }

    public IActionResult Edit(int? id)
    {
        var category = CategoriesRepository.GetCategoryById(id ?? 0);
        return View(category);
    }

    [HttpPost]
    public IActionResult Edit(Category category)
    {
        if (!ModelState.IsValid)
        {
            return View(category);
        }
        CategoriesRepository.UpdateCategory(category.CategoryId, category);
        return RedirectToAction(nameof(Index));
    }

    // GET
    public IActionResult Index()
    {
        var categories = CategoriesRepository.GetCategories();
        return View(categories);
    }
}
