using Abp.Authorization;
using abpReact.Authorization.Roles;
using abpReact.Authorization.Users;

namespace abpReact.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
