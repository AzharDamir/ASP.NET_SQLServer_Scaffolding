using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using TP1ASPNET.Data;
using TP1ASPNET.Models;

namespace TP1ASPNET.Pages.Livres
{
    public class IndexModel : PageModel
    {
        private readonly DataContext _context;

        public IndexModel(DataContext context)
        {
            _context = context;
        }

        public IList<Livre> Livre { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Livre != null)
            {
                Livre = await _context.Livre.ToListAsync();
            }
        }
    }
}
