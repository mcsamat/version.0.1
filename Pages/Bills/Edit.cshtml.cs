using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using version._0._1.Models;

namespace version._0._1
{
    public class EditModelB : PageModel
    {
        private readonly version._0._1.Data.version_0_1Context _context;

        public EditModelB(version._0._1.Data.version_0_1Context context)
        {
            _context = context;
        }

        [BindProperty]
        public Trans Trans { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Trans = await _context.Trans.FirstOrDefaultAsync(m => m.ID == id);

            if (Trans == null)
            {
                return NotFound();
            }
            return Page();
        }

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Trans).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TransExists(Trans.ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool TransExists(int id)
        {
            return _context.Trans.Any(e => e.ID == id);
        }
    }
}
