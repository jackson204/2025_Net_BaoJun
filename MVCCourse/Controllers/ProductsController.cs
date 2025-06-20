using Microsoft.AspNetCore.Mvc;
using MVCCourse.Models;
using MVCCourse.ViewModels;

namespace MVCCourse.Controllers;

public class ProductsController : Controller
{
    public IActionResult Add()
    {
        var productViewModel = new ProductViewModel
        {
            Categories = new []{new CategoryDto()}
        };
        return View();
    }

    // GET
    public IActionResult Index()
    {
        var products = ProductsRepository.GetProducts(true);
        return View(products);
    }
}
