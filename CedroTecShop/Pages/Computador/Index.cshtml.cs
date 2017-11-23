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
    public class IndexModel : PageModel
    {
        private readonly CedroTecShop.Models.ShopContext _context;

        public IndexModel(CedroTecShop.Models.ShopContext context)
        {
            _context = context;
        }

        public IList<Computador> Computador { get;set; }

        public async Task OnGetAsync()
        {
            Computador = await _context.Computador.ToListAsync();
        }
    }
}
