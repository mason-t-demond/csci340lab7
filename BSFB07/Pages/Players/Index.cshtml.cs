using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BSFB07.Data;
using BSFB07.Models;

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

        public async Task OnGetAsync()
        {
            Player = await _context.Player.ToListAsync();
        }
    }
}
