using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using version._0._1.Models;

namespace version._0._1
{
    public class DetailsModelP : PageModel
    {
        private readonly version._0._1.Data.version_0_1Context _context;

        public DetailsModelP(version._0._1.Data.version_0_1Context context)
        {
            _context = context;
        }

        public People People { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            People = await _context.People.FirstOrDefaultAsync(m => m.ID == id);

            if (People == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
