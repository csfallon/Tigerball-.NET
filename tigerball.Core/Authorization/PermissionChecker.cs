using Abp.Authorization;
using tigerball.Authorization.Roles;
using tigerball.MultiTenancy;
using tigerball.Users;

namespace tigerball.Authorization
{
    public class PermissionChecker : PermissionChecker<Tenant, Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
