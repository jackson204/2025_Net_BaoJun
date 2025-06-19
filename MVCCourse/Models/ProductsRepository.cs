﻿namespace MVCCourse.Models;

public class ProductsRepository
{
    private static readonly List<Product> _products = new()
    {
        new Product { ProductId = 1, CategoryId = 1, Name = "Iced Tea", Quantity = 100, Price = 1.99 },
        new Product { ProductId = 2, CategoryId = 1, Name = "Canada Dry", Quantity = 200, Price = 1.99 },
        new Product { ProductId = 3, CategoryId = 2, Name = "Whole Wheat Bread", Quantity = 300, Price = 1.50 },
        new Product { ProductId = 4, CategoryId = 2, Name = "White Bread", Quantity = 300, Price = 1.50 }
    };

    public static void AddProduct(Product product)
    {
        var maxId = _products.Max(x => x.ProductId);
        product.ProductId = maxId + 1;
        _products.Add(product);
    }

    public static void DeleteProduct(int productId)
    {
        var product = _products.FirstOrDefault(x => x.ProductId == productId);
        if (product != null)
        {
            _products.Remove(product);
        }
    }

    public static Product? GetProductById(int productId, bool loadCategory = false)
    {
        var product = _products.FirstOrDefault(x => x.ProductId == productId);
        if (product != null)
        {
            var prod = new Product
            {
                ProductId = product.ProductId,
                Name = product.Name,
                Quantity = product.Quantity,
                Price = product.Price,
                CategoryId = product.CategoryId
            };
            if (loadCategory && product.CategoryId.HasValue)
            {
                prod.Category = CategoriesRepository.GetCategoryById(product.CategoryId.Value);
            }
        }

        return null;
    }

    public static List<Product> GetProducts(bool loadCategory = false)
    {
        if (!loadCategory)
        {
            return _products;
        }
        if (_products.Count > 0)
        {
            _products.ForEach(product =>
            {
                if (product.CategoryId.HasValue)
                {
                    product.Category = CategoriesRepository.GetCategoryById(product.ProductId);
                }
            });
        }
        return _products;
    }

    public static void UpdateProduct(int productId, Product product)
    {
        if (productId != product.ProductId)
        {
            return;
        }

        var productToUpdate = _products.FirstOrDefault(x => x.ProductId == productId);
        if (productToUpdate != null)
        {
            productToUpdate.Name = product.Name;
            productToUpdate.Quantity = product.Quantity;
            productToUpdate.Price = product.Price;
            productToUpdate.CategoryId = product.CategoryId;
        }
    }
}
