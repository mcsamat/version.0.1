using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using version._0._1.Data;
using version._0._1.Models;

namespace version._0._1
{
    public class EditModelP : PageModel
    {
        private readonly version._0._1.Data.version_0_1Context _context;

        public EditModelP(version._0._1.Data.version_0_1Context context)
        {
            _context = context;
        }

        [BindProperty]
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

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(People).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PeopleExists(People.ID))
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

        private bool PeopleExists(int id)
        {
            return _context.People.Any(e => e.ID == id);
        }
    }
}
