namespace MVCCourse.Models;

public static class CategoriesRepository
{
    private static readonly List<Category> _categories =
    [
        new() { CategoryId = 1, Name = "Beverages", Description = "Soft drinks, coffees, teas, beers, and ales" },
        new() { CategoryId = 2, Name = "Condiments", Description = "Sweet and savory sauces, relishes, spreads, and seasonings" },
        new() { CategoryId = 3, Name = "Confections", Description = "Desserts, candies, and sweet breads" },
        new() { CategoryId = 4, Name = "Dairy Products", Description = "Cheeses" },
        new() { CategoryId = 5, Name = "Grains/Cereals", Description = "Breads, crackers, pasta, and cereal" },
        new() { CategoryId = 6, Name = "Meat/Poultry", Description = "Prepared meats" },
        new() { CategoryId = 7, Name = "Produce", Description = "Dried fruit and bean curd" },
        new() { CategoryId = 8, Name = "Seafood", Description = "Seaweed and fish" }
    ];

    public static void AddCategory(Category category)
    {
        ArgumentNullException.ThrowIfNull(category);

        category.CategoryId = _categories.Max(c => c.CategoryId) + 1;
        _categories.Add(category);
    }

    public static void DeleteCategory(int categoryId)
    {
        var category = GetCategoryById(categoryId);
        if (category == null)
        {
            throw new KeyNotFoundException($"Category with ID {categoryId} not found.");
        }

        _categories.Remove(category);
    }

    public static List<Category> GetCategories()
    {
        return _categories;
    }

    public static Category GetCategoryById(int categoryId)
    {
        var category = _categories.FirstOrDefault(c => c.CategoryId == categoryId);
        if (category == null)
        {
            throw new KeyNotFoundException($"Category with ID {categoryId} not found.");
        }
        return category;
    }

    public static void UpdateCategory(int categoryId, Category category)
    {
        ArgumentNullException.ThrowIfNull(category);

        var existingCategory = GetCategoryById(categoryId);
        if (existingCategory == null)
        {
            throw new KeyNotFoundException($"Category with ID {category.CategoryId} not found.");
        }

        existingCategory.Name = category.Name;
        existingCategory.Description = category.Description;
    }
}
