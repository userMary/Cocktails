using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.IO;

namespace Cocktails.Pages
{
    public class SaveToFile1Model : PageModel
    {
        [BindProperty]
        public string Name { get; set; } = "";
        [BindProperty]
        public string Ingredients { get; set; } = "";
        [BindProperty]
        public string Recipe { get; set; } = "";
        [BindProperty]
        public string ImageUrl { get; set; } = "";

        public IActionResult OnPost()
        {
            var filePath = Path.Combine(Directory.GetCurrentDirectory(), $"{Name}.pdf");
            var content = $"Name: {Name}\nIngredients: {Ingredients}\nRecipe: {Recipe}/*\nImageUrl: {ImageUrl}*/";
            System.IO.File.WriteAllText(filePath, content);

            return RedirectToPage("Index");
        }
    }
}