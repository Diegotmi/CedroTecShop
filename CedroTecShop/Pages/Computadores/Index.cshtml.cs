using System.Collections.Generic;
using System.Threading.Tasks;
using CedroTecShop.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace CedroTecShop.Pages.Computadores
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
