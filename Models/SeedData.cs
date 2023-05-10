using Microsoft.EntityFrameworkCore;

namespace Tones.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ToneDbContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<ToneDbContext>>()))
            {
                if (context == null || context.Tones == null)
                {
                    throw new ArgumentNullException("Null RazorPagesTonesContext");
                }
                if (context.Tones.Any())
                {
                    return; 
                }

                context.Tones.AddRange(
                    new Tone {
                        FirstName = "Stephen",
                        LastName = "Sanchez",
                        Album ="Easy On My Eyes",
                        Genre = "Sing/Songwriter",
                        Year = 2022,
                    },
                    new Tone {
                        FirstName = "Labrinth",
                        LastName = "",
                        Album = "Ends & Begins",
                        Genre = "Pop",
                        Year = 2023,
                    },
                    new Tone {
                        FirstName = "Tyler",
                        LastName = "Childers",
                        Album = "Country Squire",
                        Genre = "Country",
                        Year = 2019,
                    },
                    new Tone {
                        FirstName = "Zach",
                        LastName = "Bryan",
                        Album = "Summertime Blues",
                        Genre = "Country",
                        Year = 2022,
                    },
                    new Tone {
                        FirstName = "Bailey",
                        LastName = "Zimmerman",
                        Album = "Leave The Light On",
                        Genre = "Country",
                        Year = 2022,
                    },
                    new Tone {
                        FirstName = "Lewis",
                        LastName = "Calpaldi",
                        Album = "Broken By Desire To Be Heavenly Sent",
                        Genre = "Alternative",
                        Year = 2023 ,
                    },
                    new Tone {
                        FirstName = "Lana Del",
                        LastName = "Rey",
                        Album = "Born To Die",
                        Genre = "Alternative",
                        Year = 2011 ,
                    },
                    new Tone {
                        FirstName = "Lord",
                        LastName = "Hunron",
                        Album = "Strange Trails",
                        Genre = "Indie Rock",
                        Year = 2192,
                    },
                    new Tone {
                        FirstName = "6lack",
                        LastName = "",
                        Album = "Since I Have A Lover",
                        Genre = "R&B Soul",
                        Year = 2023,
                    },
                    new Tone {
                        FirstName = "Eddy",
                        LastName = "Lover",
                        Album = "Perdoname",
                        Genre = "Hip-Hop",
                        Year = 2008,
                    },
                    new Tone {
                        FirstName = "Michael",
                        LastName = "Jackson",
                        Album = "The Essential Michael Jackson",
                        Genre = "Pop",
                        Year = 1982,
                    },
                    new Tone {
                        FirstName = "Adele",
                        LastName = "",
                        Album = "25",
                        Genre = "Pop",
                        Year = 2015,
                    },
                    new Tone {
                        FirstName = "Bon",
                        LastName = "Iver",
                        Album = "Blood Bank",
                        Genre = "Alternative",
                        Year = 2009,
                    },
                    new Tone {
                        FirstName = "Colby",
                        LastName = "O'Donis",
                        Album = "Colby O",
                        Genre = "R&B Soul",
                        Year = 2008,
                    },
                    new Tone {
                        FirstName = "KALEO",
                        LastName = "",
                        Album = "A/B",
                        Genre = "Alternative",
                        Year = 2016 ,
                    },
                    new Tone {
                        FirstName = "",
                        LastName = "",
                        Album = "",
                        Year = 2192 ,
                    },
                    new Tone {
                        FirstName = "Fleetwood",
                        LastName = "Mac",
                        Album = "The Very Best Of Fleetwood Mac",
                        Genre = "Rock",
                        Year = 1987,
                    },
                    new Tone {
                        FirstName = "Aubrey",
                        LastName = "Graham",
                        Album = "Views",
                        Genre = "Hip-Hop",
                        Year = 2016,
                    },
                    new Tone {
                        FirstName = "Novo",
                        LastName = "Amor",
                        Album = "Birthplace",
                        Genre = "Alternative",
                        Year = 2018,
                    },
                    new Tone {
                        FirstName = "Morgan",
                        LastName = "Wallen",
                        Album = "Dangerous: The Double Album",
                        Genre = "Country",
                        Year = 2021,
                    },
                    new Tone {
                        FirstName = "Coyote",
                        LastName = "Theory",
                        Album = "Color-EP ",
                        Genre = "Rock",
                        Year = 2011,
                    },
                    new Tone {
                        FirstName = "Steve",
                        LastName = "Lacy",
                        Album = "Gemini Rights",
                        Genre = "R&B Soul",
                        Year = 2022,
                    },
                    new Tone {
                        FirstName = "Joji",
                        LastName = "",
                        Album = "SMITHEREENS",
                        Genre = "Pop",
                        Year = 2022 ,
                    },
                    new Tone {
                        FirstName = "Ali",
                        LastName = "Gate",
                        Album = "WHO HURT YOU?",
                        Genre = "R&B Soul",
                        Year = 2020 ,
                    },
                    new Tone {
                        FirstName = "Dean",
                        LastName = "Lewis",
                        Album = "The Hardest Love",
                        Genre = "Sing/Songwriter",
                        Year = 2022 ,
                    },
                    new Tone {
                        FirstName = "Daniel",
                        LastName = "Caesar",
                        Album = "Let Me Go",
                        Genre = "R&B Soul",
                        Year = 2023,
                    }
                );

                context.SaveChanges();
            }
        }
    }
}