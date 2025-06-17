using Microsoft.AspNetCore.Mvc;
using MVCCourse.Models;
namespace MVCCourse.Controllers;

public class ProductsController : Controller
{
    // GET
    public IActionResult Index()
    {
        var products = ProductsRepository.GetProducts();
        return View(products);
    }
}
