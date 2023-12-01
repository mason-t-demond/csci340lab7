using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BSFB07.Data;
using BSFB07.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BSFB07.Pages_Players
{
    public class IndexModel : PageModel
    {
        private readonly BSFB07.Data.BSFB07Context _context;

        public IndexModel(BSFB07.Data.BSFB07Context context)
        {
            _context = context;
        }

        public IList<Player> Player { get;set; } = default!;

        [BindProperty(SupportsGet = true)]
        public string? SearchString { get; set; }

        public SelectList? Positions { get; set; }

        [BindProperty(SupportsGet = true)]
        public string? PlayerPosition { get; set; }

        public async Task OnGetAsync()
        {
            // Use LINQ to get list of genres.
            IQueryable<string> PosQuery = from p in _context.Player
                                          orderby p.primaryOffPos
                                          select p.primaryOffPos;
            
            
            var players = from p in _context.Player
                        select p;

            if (!string.IsNullOrEmpty(SearchString))
            {
                players = players.Where(s => s.name.Contains(SearchString));
            }

            if (!string.IsNullOrEmpty(PlayerPosition))
            {
                players = players.Where(x => x.primaryOffPos == PlayerPosition || x.primaryDefPos == PlayerPosition || x.primarySpePos == PlayerPosition);
            }
            
            Positions = new SelectList(await PosQuery.Distinct().ToListAsync());
            Player = await players.ToListAsync();
        }
    }
}