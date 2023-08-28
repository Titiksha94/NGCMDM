using Microsoft.EntityFrameworkCore;

namespace NGCMDM.Data.Models
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {
        }
        public DbSet<UserSetting> UserSettings { get; set; }
        public DbSet<User> User { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // modelBuilder.Seed();
            modelBuilder.Entity<User>().ToTable("User");
            modelBuilder.Entity<UserSetting>().ToTable("UserSetting");
            modelBuilder.Entity<Version>().ToTable("Version");
            modelBuilder.Entity<BusinessZone>().ToTable("BusinessZone");
            modelBuilder.Entity<GlobalSetting>().ToTable("GlobalSettings");
            modelBuilder.Entity<PricingScreenSetting>().ToTable("PricingScreenSettings");
            modelBuilder.Entity<ProductMaster>().ToTable("ProductMaster");
            modelBuilder.Entity<SalesOrg>().ToTable("SalesOrg");
            modelBuilder.Entity<Version>().ToTable("Version");
            modelBuilder.Entity<VersionBusinessZone>().ToTable("VersionBusinessZone");
            modelBuilder.Entity<VersionSalesOrg>().ToTable("VersionSalesOrg");

            //modelBuilder.Entity<UserSetting>()
            //   .HasData(
            //   new User
            //   {
            //       Guid = Guid.NewGuid(),
            //       Deleted = false,
            //       DateNew = DateTime.Now,
            //       DateChanged = DateTime.Now,
            //       Email = "titiksha.mahimker@test.com",
            //       Prename = "Ms",
            //       UserChanged = "Titiksha",
            //       SalesOrg = "5000",
            //       UserName = "Titiksha",
            //       Surname = "Mahimker",
            //       State = "MH",
            //       UserNew = "Titiksha",
            //       SettingsID = new Guid()
            //   }
            //   );
            //modelBuilder.Entity<User>()
            //    .HasData(
            //    new User
            //    {
            //        Guid = Guid.NewGuid(),
            //        Deleted = false,
            //        DateNew = DateTime.Now,
            //        DateChanged = DateTime.Now,
            //        Email = "titiksha.mahimker@test.com",
            //        Prename = "Ms",
            //        UserChanged = "Titiksha",
            //        SalesOrg = "5000",
            //        UserName = "Titiksha",
            //        Surname = "Mahimker",
            //        State = "MH",
            //        UserNew = "Titiksha",
            //        SettingsID = new Guid()
            //    }
            //    );
            // modelBuilder.Entity<GlobalSetting>()
            //.Property<string>("JsonSettings")
            //.HasField("JsonSettingsColumn");
            //   modelBuilder.Entity<Version>()
            //.HasOne(e => e.ChangePeriod)
            //.WithOne(e => e.Version)
            //.HasForeignKey<Version>(e => e.CamosGuid)
            //.IsRequired();

        }
    }
}
