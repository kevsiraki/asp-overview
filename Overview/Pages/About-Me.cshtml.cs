using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Overview.Pages
{
    public class About_UsModel : PageModel
    {
        private string[] names = {"Kevin", "Artin" };
        public IEnumerable<string> FilteredNames { get; private set; }

        public void OnGet()
        {
            FilteredNames = names.Where(name => name.StartsWith("K"));

        }
    }
}
