using NGCMDM.Data.Models;
using System.Diagnostics;

namespace NGCMDM.Data.Configurations
{
    public class DbInitializer
    {
        public static void Initialize(ApplicationDBContext context)
        {
            context.Database.EnsureCreated();

            //Look for any students.
            if (context.User.Any())
                {
                    return;   // DB has been seeded
                }

            var students = new User[]
            {
            new User{Guid=new Guid(),UserName="Titiksha",Prename="Ms",Surname="Mahimker",DateNew=DateTime.UtcNow,Email="titiksha@test.com",SalesOrg="5000 IND",State="MH"},


            };
            foreach (User s in students)
            {
                context.User.Add(s);
            }
            context.SaveChanges();

            var courses = new UserSetting[]
            {
            new UserSetting{UserNew="Titiksha",DateNew=DateTime.Now,ShowTechnicalNames=true,ShowAbbreviations=true,ShowLockIcons = true,Guid=new Guid()}

            };
            foreach (UserSetting c in courses)
            {
                context.UserSettings.Add(c);
            }
            context.SaveChanges();

        }

    }
}
