using Abp.Authorization;
using SalesManagementSystem.Authorization.Roles;
using SalesManagementSystem.Authorization.Users;

namespace SalesManagementSystem.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
