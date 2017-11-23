using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CedroTecShop.Models;

namespace CedroTecShop.Pages.Computador
{
    public class DetailsModel : PageModel
    {
        private readonly CedroTecShop.Models.ShopContext _context;

        public DetailsModel(CedroTecShop.Models.ShopContext context)
        {
            _context = context;
        }

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
    }
}
