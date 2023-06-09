using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using FrontaTCG.Cards;
using FrontaTCG.EntityFrameworkCore;

namespace FrontaTCG.Web.Pages.Cards
{
    public class DetailsModel : PageModel
    {
        private readonly FrontaTCG.EntityFrameworkCore.FrontaTCGDbContext _context;

        public DetailsModel(FrontaTCG.EntityFrameworkCore.FrontaTCGDbContext context)
        {
            _context = context;
        }

      public Card Card { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(Guid? id)
        {
            if (id == null || _context.Cards == null)
            {
                return NotFound();
            }

            var card = await _context.Cards.FirstOrDefaultAsync(m => m.Id == id);
            if (card == null)
            {
                return NotFound();
            }
            else 
            {
                Card = card;
            }
            return Page();
        }
    }
}
