namespace FallOs.Data
{
    using FallOS.Data.Models;
    using Microsoft.AspNet.Identity.EntityFramework;
    using System.Data.Entity;
    public class FallOSDbContext : IdentityDbContext<User>
    {

        public FallOSDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public IDbSet<Hui> Huis { get; set; }

        public static FallOSDbContext Create()
        {
            return new FallOSDbContext();
        }
    }
}
