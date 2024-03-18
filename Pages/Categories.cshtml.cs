using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Routing.Template;

namespace MyRazorApp.Pages;

public class Categories : PageModel
{
    public List<Category> Category { get; set; } = new();
    public void OnGet(
        int skip = 0,
        int take = 25)
    {
        for (int i = 0; i <= 1000; i++)
        {
            Category.Add(
                new Category(i,
                    Title:$"Category {i}",
                    Price: i*18.95M));
        }

        Category = Category
            .Skip(skip)
            .Take(take)
            .ToList();
    }
}

public record Category(
    int Id,
    string Title,
    decimal Price
);