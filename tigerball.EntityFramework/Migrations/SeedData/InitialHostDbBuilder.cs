using tigerball.EntityFramework;
using EntityFramework.DynamicFilters;

namespace tigerball.Migrations.SeedData
{
    public class InitialHostDbBuilder
    {
        private readonly tigerballDbContext _context;

        public InitialHostDbBuilder(tigerballDbContext context)
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
