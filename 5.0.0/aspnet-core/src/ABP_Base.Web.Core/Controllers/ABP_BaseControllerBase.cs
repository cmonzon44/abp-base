using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace ABP_Base.Controllers
{
    public abstract class ABP_BaseControllerBase: AbpController
    {
        protected ABP_BaseControllerBase()
        {
            LocalizationSourceName = ABP_BaseConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
