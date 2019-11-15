using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace aspReact.Controllers
{
    public abstract class aspReactControllerBase: AbpController
    {
        protected aspReactControllerBase()
        {
            LocalizationSourceName = aspReactConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
