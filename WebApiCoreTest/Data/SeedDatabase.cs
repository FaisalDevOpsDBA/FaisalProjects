using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiCoreTest.Data
{
    public class SeedDatabase
    {
        public static void Initializer(IServiceProvider serviceProvider)
        {
            var context = serviceProvider.GetRequiredService<ApplicationDBContext>();
            var userManager = serviceProvider.GetRequiredService<UserManager<ApplicationUser>>();
            context.Database.EnsureCreated();
            if (!context.Users.Any())
            {
                ApplicationUser user = new ApplicationUser()
                {
                    Email = "syedfaisal.mca@gmail.com",
                    SecurityStamp = Guid.NewGuid().ToString(),
                    UserName = "Faisal"
                };
                Task<IdentityResult> result = userManager.CreateAsync(user,"Password@123");
            }
        }
    }
}
