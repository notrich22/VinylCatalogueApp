using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using VinylCatalogueApp.Model;
namespace VinylCatalogueApp.Pages
{
    public class VinylAppFormModel : PageModel
    {
        private IDataProvider dataProvider = new SqlServerDataProvider();
        public List<VinylDisk>? vinylDisks = null;
        [BindProperty]
        public VinylDisk? newDisk { get; set; } = new();

        public void OnGet()
        {
            vinylDisks = dataProvider.GetAllVinylDisks();
            newDisk = null;
        }
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            if(newDisk != null)dataProvider.CreateVinylDisk(newDisk);
            return RedirectToAction("Get");
        }

        public IActionResult OnPostDelete(int id)
        {
            dataProvider.DeleteVinylDisk(id);
            return RedirectToAction("Get");
        }
                public void OnPostView(int id)
        {
            vinylDisks = dataProvider.GetAllVinylDisks();
            newDisk = dataProvider.GetVinylDisk(id);
        }

        public IActionResult OnPostEdit()
        {
            if (!ModelState.IsValid || newDisk is null)
            {
                return Page();
            }
            dataProvider.UpdateVinylDisk(newDisk);
            return RedirectToAction("Get");
        }
        
    }
}
