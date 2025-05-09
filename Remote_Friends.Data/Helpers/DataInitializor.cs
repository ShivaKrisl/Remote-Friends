using Remote_Friends.Data.DataContext.Models;
using Remote_Friends.DataContext;
using Remote_Friends.DataContext.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remote_Friends.Data.Helpers
{
    public static class DataInitializor
    {
        public static async Task SeedAsync(ApplicationDbContext applicationDbContext)
        {
            if (!applicationDbContext.Users.Any() && !applicationDbContext.Posts.Any())
            {
                User user = new User()
                {
                    UserName = "Shiva Krishna",
                    ProfileUrl = "D://SHIVA KRISHNA//Downloads//MySelf_Passport_Official.png"
                };
                await applicationDbContext.Users.AddAsync(user);
                await applicationDbContext.SaveChangesAsync();

                Post postWithOutImage = new Post()
                {
                    Content = "This is My first Post loaded from DB without Image",
                    ImageUrl = "",
                    NoOfReports = 0,
                    CreatedAt = DateTime.UtcNow,
                    LastUpdatedAt = DateTime.UtcNow,
                    UserId = user.UserId,
                };

                Post postWithImage = new Post()
                {
                    Content = "This post is from DB with Image",
                    ImageUrl = "https://unsplash.com/photos/a-seagull-flies-freely-in-the-bright-blue-sky-MmMhB7kVW-0",
                    NoOfReports = 0,
                    CreatedAt = DateTime.UtcNow,
                    LastUpdatedAt = DateTime.UtcNow,
                    UserId = user.UserId,
                };

                await applicationDbContext.Posts.AddRangeAsync(postWithOutImage,  postWithImage);
                await applicationDbContext.SaveChangesAsync();
            }
        }
    }
}
