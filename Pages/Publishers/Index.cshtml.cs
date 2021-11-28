using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Ionascu_Adrian_Lab8.Data;
using Ionascu_Adrian_Lab8.Models;

namespace Ionascu_Adrian_Lab8.Pages.Publishers
{
    public class IndexModel : PageModel
    {
        private readonly Ionascu_Adrian_Lab8.Data.Ionascu_Adrian_Lab8Context _context;

        public IndexModel(Ionascu_Adrian_Lab8.Data.Ionascu_Adrian_Lab8Context context)
        {
            _context = context;
        }

        public IList<Publisher> Publisher { get;set; }

        public async Task OnGetAsync()
        {
             Book = await _context.Book
            .Include(b => b.Publisher)
            .ToListAsync();
            Publisher = await _context.Publisher.ToListAsync();
        }
    }
}
