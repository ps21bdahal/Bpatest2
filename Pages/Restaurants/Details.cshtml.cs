﻿using System;
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
    public class DetailsModel : PageModel
    {
        private readonly Bpa_Test_2.Data.Bpa_Test_2Context _context;

        public DetailsModel(Bpa_Test_2.Data.Bpa_Test_2Context context)
        {
            _context = context;
        }

        public Restaurant Restaurant { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Restaurant = await _context.Restaurant.FirstOrDefaultAsync(m => m.RestaurantID == id);

            if (Restaurant == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
