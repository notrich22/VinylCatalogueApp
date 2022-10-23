using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using VinylCatalogueApp.Model;
namespace VinylCatalogueApp.Pages
{
    public class VinylAppFormModel : PageModel
    {
        private IDataProvider dataProvider = new Plug();
        public void OnGet()
        {
        }
    }
}
