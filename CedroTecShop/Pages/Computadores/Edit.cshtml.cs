using System.Threading.Tasks;
using CedroTecShop.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace CedroTecShop.Pages.Computadores
{
    public class EditModel : PageModel
    {
        private readonly CedroTecShop.Models.ShopContext _context;

        public EditModel(CedroTecShop.Models.ShopContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Computador Computador { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Computador = await _context.Computador.SingleOrDefaultAsync(m => m.ID == id);

            if (Computador == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Computador).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                
            }

            return RedirectToPage("./Index");
        }
    }
}
