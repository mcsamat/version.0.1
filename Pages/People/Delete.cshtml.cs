﻿using System;
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
    public class DeleteModelP : PageModel
    {
        private readonly version._0._1.Data.version_0_1Context _context;

        public DeleteModelP(version._0._1.Data.version_0_1Context context)
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            People = await _context.People.FindAsync(id);

            if (People != null)
            {
                _context.People.Remove(People);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
