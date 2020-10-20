using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Bpa_Test_2.Data;
using Bpa_Test_2.Models;

namespace Bpa_Test_2.Pages.Restaurants
{
    public class IndexModel : PageModel
    {
        private readonly Bpa_Test_2.Data.Bpa_Test_2Context _context;

        public IndexModel(Bpa_Test_2.Data.Bpa_Test_2Context context)
        {
            _context = context;
        }

        public IList<Restaurant> Restaurant { get;set; }

        public async Task OnGetAsync()
        {
            Restaurant = await _context.Restaurant.ToListAsync();
        }
    }
}
