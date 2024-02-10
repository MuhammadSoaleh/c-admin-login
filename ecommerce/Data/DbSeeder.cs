using ecommerce.Constants;
using Microsoft.AspNetCore.Identity;

namespace ecommerce.Data
{
    public class DbSeeder
    {
        public static async Task SeeDefaultData(IServiceProvider service)
        {
            var usrMngr = service.GetService<UserManager<IdentityUser>>();
            var roleMngr = service.GetService<RoleManager<IdentityRole>>();

            roleMngr.CreateAsync(new IdentityRole(Roles.User.ToString()));
            roleMngr.CreateAsync(new IdentityRole(Roles.Admin.ToString()));

            var admin = new IdentityUser
            {
                UserName = "admin@gmail.com",
                Email = "admin@gmail.com",
                EmailConfirmed = true
            };

            var isUserExist = usrMngr.FindByEmailAsync(admin.Email);
            if (isUserExist is null) //!isUserExist
            {
                await usrMngr.CreateAsync(admin,"Admin@123");
                await usrMngr.AddToRoleAsync(admin, Roles.Admin.ToString());
            }

        }
    }
}
