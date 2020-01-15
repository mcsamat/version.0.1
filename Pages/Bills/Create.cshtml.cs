using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Threading.Tasks;
using version._0._1.Models;

namespace version._0._1
{
    public class CreateModelB : PageModel
    {
        private readonly version._0._1.Data.version_0_1Context _context;

        public CreateModelB(version._0._1.Data.version_0_1Context context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Trans Trans { get; set; }

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Trans.Add(Trans);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
