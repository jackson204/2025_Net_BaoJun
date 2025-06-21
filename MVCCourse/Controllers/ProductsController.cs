using Microsoft.AspNetCore.Mvc;
using MVCCourse.Models;
using MVCCourse.ViewModels;

namespace MVCCourse.Controllers;

public class ProductsController : Controller
{
    public IActionResult Edit(int id)
    {
        var productViewModel = new ProductViewModel
        {
            Product = ProductsRepository.GetProductById(id)?? new Product(),
            Categories = CategoriesRepository.GetCategories()
        };
        return View(productViewModel);
    }

    [HttpPost]
    public IActionResult Edit(ProductViewModel productViewModel)
    {
        if (ModelState.IsValid)
        {
            ProductsRepository.UpdateProduct(productViewModel.Product.ProductId,productViewModel.Product);
            return RedirectToAction(nameof(Index));
        }
        productViewModel.Categories = CategoriesRepository.GetCategories();
        return View(productViewModel); 
    }
    
    
    public IActionResult Add()
    {
        var productViewModel = new ProductViewModel
        {
            Categories = CategoriesRepository.GetCategories()
        };
        return View(productViewModel);
    }
    [HttpPost]
    public IActionResult Add(ProductViewModel productViewModel)
    {
        if (ModelState.IsValid)
        {
            ProductsRepository.AddProduct(productViewModel.Product);
            return RedirectToAction(nameof(Index));
        }
        productViewModel.Categories = CategoriesRepository.GetCategories();
        return View(productViewModel);
    }

    // GET
    public IActionResult Index()
    {
        var products = ProductsRepository.GetProducts(true);
        return View(products);
    }
}
