namespace FallOs.Data
{
    using FallOS.Data.Models;
    using Microsoft.AspNet.Identity.EntityFramework;

    public class FallOSDbContext : IdentityDbContext<User>
    {
        public FallOSDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static FallOSDbContext Create()
        {
            return new FallOSDbContext();
        }
    }
}
