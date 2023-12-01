using Microsoft.EntityFrameworkCore;
using BSFB07.Data;

namespace BSFB07.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new BSFB07Context(
            serviceProvider.GetRequiredService<
                DbContextOptions<BSFB07Context>>()))
        {
            if (context == null || context.Player == null)
            {
                throw new ArgumentNullException("Null RazorPagesMovieContext");
            }

            // Look for any movies.
            if (context.Player.Any())
            {
                return;   // DB has been seeded
            }

            context.Player.AddRange(
                new Player
                {
                    name = "Achmed Khan",
                    primaryOffPos = "WR",
                    primaryDefPos = "LB",
                    primarySpePos = "BL",
                    Running = 8,
                    Passing = 5,
                    Catching = 5,
                    Kicking = 6,
                    Blocking = 6,
                    Ovr = 76
                },

                new Player
                {
                    name = "Alex Smith",
                    primaryOffPos = "QB",
                    primaryDefPos = "S",
                    primarySpePos = "BL",
                    Running = 5,
                    Passing = 7,
                    Catching = 4,
                    Kicking = 5,
                    Blocking = 5,
                    Ovr = 72
                },

                new Player
                {
                    name = "Angela Delvecchio",
                    primaryOffPos = "QB",
                    primaryDefPos = "S",
                    primarySpePos = "K",
                    Running = 8,
                    Passing = 8,
                    Catching = 4,
                    Kicking = 7,
                    Blocking = 6,
                    Ovr = 81
                },

                new Player
                {
                    name = "Annie Frazier",
                    primaryOffPos = "C",
                    primaryDefPos = "DL",
                    primarySpePos = "K",
                    Running = 2,
                    Passing = 3,
                    Catching = 6,
                    Kicking = 9,
                    Blocking = 6,
                    Ovr = 72
                },

                new Player
                {
                    name = "Arthur Chen",
                    primaryOffPos = "WR",
                    primaryDefPos = "CB",
                    primarySpePos = "KR",
                    Running = 8,
                    Passing = 3,
                    Catching = 8,
                    Kicking = 4,
                    Blocking = 6,
                    Ovr = 76
                },

                new Player
                {
                    name = "Ashley Webber",
                    primaryOffPos = "WR",
                    primaryDefPos = "CB",
                    primarySpePos = "BL",
                    Running = 6,
                    Passing = 6,
                    Catching = 7,
                    Kicking = 4,
                    Blocking = 6,
                    Ovr = 76
                },

                new Player
                {
                    name = "Ben Roethlisberger",
                    primaryOffPos = "QB",
                    primaryDefPos = "DL",
                    primarySpePos = "K",
                    Running = 5,
                    Passing = 8,
                    Catching = 5,
                    Kicking = 7,
                    Blocking = 7,
                    Ovr = 80
                },

                new Player
                {
                    name = "Braylon Edwards",
                    primaryOffPos = "WR",
                    primaryDefPos = "CB",
                    primarySpePos = "BL",
                    Running = 8,
                    Passing = 4,
                    Catching = 8,
                    Kicking = 5,
                    Blocking = 5,
                    Ovr = 77
                },

                new Player
                {
                    name = "Brian Urlacher",
                    primaryOffPos = "C",
                    primaryDefPos = "LB",
                    primarySpePos = "C",
                    Running = 7,
                    Passing = 4,
                    Catching = 8,
                    Kicking = 4,
                    Blocking = 8,
                    Ovr = 79
                },

                new Player
                {
                    name = "Carnell Williams",
                    primaryOffPos = "RB",
                    primaryDefPos = "S",
                    primarySpePos = "BL",
                    Running = 8,
                    Passing = 2,
                    Catching = 7,
                    Kicking = 2,
                    Blocking = 6,
                    Ovr = 71
                }
            );
            context.SaveChanges();
        }
    }
}