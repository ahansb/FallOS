namespace FallOS.Data.Models
{
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using System.Collections.Generic;
    using System.Security.Claims;
    using System.Threading.Tasks;

    public class User : IdentityUser
    {
        private ICollection<Hui> huis;

        public User() : base()
        {
            this.huis = new HashSet<Hui>();
        }

        public string Firstname { get; set; }

        public string Lastname { get; set; }

        public string Nationality { get; set; }

        public Gender Gender { get; set; }

        public int Age { get; set; }

        public string Avatar { get; set; }

        public double Points { get; set; }

        public virtual ICollection<Hui> Huis { get { return this.huis; } set { this.huis = value} }

        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<User> manager, string authenticationType)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, authenticationType);
            // Add custom user claims here
            return userIdentity;
        }
    }
}
