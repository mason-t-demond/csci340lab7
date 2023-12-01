using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BSFB07.Models;

namespace BSFB07.Data
{
    public class BSFB07Context : DbContext
    {
        public BSFB07Context (DbContextOptions<BSFB07Context> options)
            : base(options)
        {
        }

        public DbSet<BSFB07.Models.Player> Player { get; set; } = default!;
    }
}
