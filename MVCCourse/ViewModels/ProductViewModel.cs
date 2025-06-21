using MVCCourse.Models;

namespace MVCCourse.ViewModels;

public class ProductViewModel
{
    public Product Product { get; set; } = new();

    public IEnumerable<Category> Categories { get; set; } = new List<Category>();
}
