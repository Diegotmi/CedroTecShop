using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CedroTecShop.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace CedroTecShop.Pages
{
    public class ShopModel : PageModel
    {
        private readonly CedroTecShop.Models.ShopContext _context;
        private IList<Computador> Carrinho { get; set; }

        public ShopModel(CedroTecShop.Models.ShopContext context)
        {
            _context = context;
        }


        public IList<Computador> Computadores { get; set; }

        public async Task OnGetAsync()
        {
            Computadores = await _context.Computador.ToListAsync();
        }
    }
}
