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
    public class IndexModel : PageModel
    {
        private readonly version._0._1.Data.version_0_1Context _context;

        public IndexModel(version._0._1.Data.version_0_1Context context)
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
