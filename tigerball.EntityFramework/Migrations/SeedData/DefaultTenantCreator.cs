using System.Linq;
using tigerball.EntityFramework;
using tigerball.MultiTenancy;

namespace tigerball.Migrations.SeedData
{
    public class DefaultTenantCreator
    {
        private readonly tigerballDbContext _context;

        public DefaultTenantCreator(tigerballDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            CreateUserAndRoles();
        }

        private void CreateUserAndRoles()
        {
            //Default tenant

            var defaultTenant = _context.Tenants.FirstOrDefault(t => t.TenancyName == Tenant.DefaultTenantName);
            if (defaultTenant == null)
            {
                _context.Tenants.Add(new Tenant {TenancyName = Tenant.DefaultTenantName, Name = Tenant.DefaultTenantName});
                _context.SaveChanges();
            }
        }
    }
}
