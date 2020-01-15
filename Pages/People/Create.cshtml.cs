﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using version._0._1.Data;
using version._0._1.Models;

namespace version._0._1
{
    public class CreateModelP : PageModel
    {
        private readonly version._0._1.Data.version_0_1Context _context;

        public CreateModelP(version._0._1.Data.version_0_1Context context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public People People { get; set; }

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.People.Add(People);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
