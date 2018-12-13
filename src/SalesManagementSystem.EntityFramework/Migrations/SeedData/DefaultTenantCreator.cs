using System.Linq;
using SalesManagementSystem.EntityFramework;
using SalesManagementSystem.MultiTenancy;

namespace SalesManagementSystem.Migrations.SeedData
{
    public class DefaultTenantCreator
    {
        private readonly SalesManagementSystemDbContext _context;

        public DefaultTenantCreator(SalesManagementSystemDbContext context)
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
