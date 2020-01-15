using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using version._0._1.Data;
using version._0._1.Models;

namespace version._0._1
{
    public class DeleteModelS : PageModel
    {
        private readonly version._0._1.Data.version_0_1_2Context _context;

        public DeleteModelS(version._0._1.Data.version_0_1_2Context context)
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Trans = await _context.Trans.FindAsync(id);

            if (Trans != null)
            {
                _context.Trans.Remove(Trans);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
