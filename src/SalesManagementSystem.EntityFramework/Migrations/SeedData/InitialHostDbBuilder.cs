using SalesManagementSystem.EntityFramework;
using EntityFramework.DynamicFilters;

namespace SalesManagementSystem.Migrations.SeedData
{
    public class InitialHostDbBuilder
    {
        private readonly SalesManagementSystemDbContext _context;

        public InitialHostDbBuilder(SalesManagementSystemDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            _context.DisableAllFilters();

            new DefaultEditionsCreator(_context).Create();
            new DefaultLanguagesCreator(_context).Create();
            new HostRoleAndUserCreator(_context).Create();
            new DefaultSettingsCreator(_context).Create();
        }
    }
}
