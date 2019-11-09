using Abp.Authorization;
using ABP_Base.Authorization.Roles;
using ABP_Base.Authorization.Users;

namespace ABP_Base.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
