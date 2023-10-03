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
    public class DeleteModel : PageModel
    {
        private readonly TP1ASPNET.Data.DataContext _context;

        public DeleteModel(TP1ASPNET.Data.DataContext context)
        {
            _context = context;
        }

        [BindProperty]
      public Livre Livre { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Livre == null)
            {
                return NotFound();
            }

            var livre = await _context.Livre.FirstOrDefaultAsync(m => m.id == id);

            if (livre == null)
            {
                return NotFound();
            }
            else 
            {
                Livre = livre;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.Livre == null)
            {
                return NotFound();
            }
            var livre = await _context.Livre.FindAsync(id);

            if (livre != null)
            {
                Livre = livre;
                _context.Livre.Remove(Livre);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
