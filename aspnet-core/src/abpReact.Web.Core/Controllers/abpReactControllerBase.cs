using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace abpReact.Controllers
{
    public abstract class abpReactControllerBase: AbpController
    {
        protected abpReactControllerBase()
        {
            LocalizationSourceName = abpReactConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
