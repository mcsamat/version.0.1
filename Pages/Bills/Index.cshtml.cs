using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using version._0._1.Models;

namespace version._0._1
{
    public class IndexModelB : PageModel
    {
        private readonly version._0._1.Data.version_0_1Context _context;

        public IndexModelB(version._0._1.Data.version_0_1Context context)
        {
            _context = context;
        }

        public IList<Trans> Trans { get; set; }

        public async Task OnGetAsync()
        {
            Trans = await _context.Trans.ToListAsync();
        }
    }
}
