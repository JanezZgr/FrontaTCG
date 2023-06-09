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
    public class IndexModel : PageModel
    {
        private readonly FrontaTCG.EntityFrameworkCore.FrontaTCGDbContext _context;

        public IndexModel(FrontaTCG.EntityFrameworkCore.FrontaTCGDbContext context)
        {
            _context = context;
        }

        public IList<Card> Card { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Cards != null)
            {
                Card = await _context.Cards.ToListAsync();
            }
        }
    }
}
