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
    public class IndexModelS : PageModel
    {
        private readonly version._0._1.Data.version_0_1_2Context _context;

        public IndexModelS(version._0._1.Data.version_0_1_2Context context)
        {
            _context = context;
        }

        public IList<Trans> Trans { get;set; }

        public async Task OnGetAsync()
        {
            Trans = await _context.Trans.ToListAsync();
        }
    }
}
