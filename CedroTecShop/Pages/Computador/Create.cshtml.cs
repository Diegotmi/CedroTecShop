using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using CedroTecShop.Models;

namespace CedroTecShop.Pages.Computador
{
    public class CreateModel : PageModel
    {
        private readonly CedroTecShop.Models.ShopContext _context;

        public CreateModel(CedroTecShop.Models.ShopContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Computador Computador { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Computador.Add(Computador);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}