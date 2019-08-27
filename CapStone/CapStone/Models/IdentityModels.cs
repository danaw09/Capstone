using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace CapStone.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit https://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
        internal bool isActive;

        public string Name { get;  set; }

        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {    public DbSet<Patient> patient { get; set; }
        public DbSet<Doctor> doctors { get; set; }
        public DbSet<Appointment> appointments { get; set; }
        public DbSet<Attendence> attendences{ get; set; }
        public DbSet<Specialization> Specializations { get; set; }
        public DbSet<City> Cities { get; set; }

        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //modelBuilder.Configurations.Add(new PatientConfiguration());
            //modelBuilder.Configurations.Add(new AppointmentConfiguration());
            //modelBuilder.Configurations.Add(new DoctorConfiguration());
            //modelBuilder.Configurations.Add(new AttendanceConfiguration());
            //modelBuilder.Configurations.Add(new SpecializationConfiguration());
            //modelBuilder.Configurations.Add(new CityConfiguration());

            base.OnModelCreating(modelBuilder);
        }
    }
}