using Abp.Authorization;
using aspReact.Authorization.Roles;
using aspReact.Authorization.Users;

namespace aspReact.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
