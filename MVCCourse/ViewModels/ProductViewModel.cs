using MVCCourse.Models;

namespace MVCCourse.ViewModels;

public class ProductViewModel
{
    public ProductDTO Product { get; set; } = new();

    public IEnumerable<CategoryDto> Categories { get; set; } = new List<CategoryDto>();
}
