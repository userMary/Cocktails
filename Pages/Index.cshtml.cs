using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;
using Cocktails.Models;
using System.Collections.Generic;
using System.IO;

namespace Cocktails.Pages
{
    public class IndexModel : PageModel
    {
        //public string Text { get; set; }
        //public IndexModel()
        //{
        //    Text = "Testtttt";
        //}
        public List<Cocktail> Cocktails { get; set; }
        public void OnGet()
        {
            var filePath = Path.Combine(Directory.GetCurrentDirectory(), "cocktails.json");
            var json = System.IO.File.ReadAllText(filePath);
            Cocktails = JsonConvert.DeserializeObject<List<Cocktail>>(json);
        }
    }
}
