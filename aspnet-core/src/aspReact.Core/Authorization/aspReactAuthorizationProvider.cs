using Abp.Authorization;
using Abp.Localization;
using Abp.MultiTenancy;

namespace aspReact.Authorization
{
    public class aspReactAuthorizationProvider : AuthorizationProvider
    {
        public override void SetPermissions(IPermissionDefinitionContext context)
        {
            var test1 = L("Users");
            var test2 = L("Authors");
            context.CreatePermission(PermissionNames.Pages_Users, L("Users"));
            context.CreatePermission(PermissionNames.Pages_Roles, L("Roles"));
            context.CreatePermission(PermissionNames.Pages_Tenants, L("Tenants"), multiTenancySides: MultiTenancySides.Host);
            context.CreatePermission(PermissionNames.Pages_Authors, L("Authors"));
            context.CreatePermission(PermissionNames.Pages_Books, L("Books"));
            context.CreatePermission(PermissionNames.Pages_Categories, L("Categories"));
        }

        private static ILocalizableString L(string name)
        {
            return new LocalizableString(name, aspReactConsts.LocalizationSourceName);
        }
    }
}
