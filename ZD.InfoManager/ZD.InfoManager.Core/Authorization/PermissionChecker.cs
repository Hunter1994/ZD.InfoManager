using Abp.Authorization;
using ZD.InfoManager.Core.Authorization.Roles;
using ZD.InfoManager.Core.Authorization.Users;

namespace ZD.InfoManager.Core.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
