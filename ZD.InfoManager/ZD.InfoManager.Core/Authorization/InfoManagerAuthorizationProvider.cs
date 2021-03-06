﻿using Abp.Authorization;
using Abp.Localization;
using Abp.MultiTenancy;

namespace ZD.InfoManager.Core.Authorization
{
    public class InfoManagerAuthorizationProvider : AuthorizationProvider
    {
        public override void SetPermissions(IPermissionDefinitionContext context)
        {
            context.CreatePermission(PermissionNames.Pages_Users, L("Users"));
            context.CreatePermission(PermissionNames.Pages_Roles, L("Roles"));
            context.CreatePermission(PermissionNames.Pages_Tenants, L("Tenants"), multiTenancySides: MultiTenancySides.Host);
            context.CreatePermission(PermissionNames.Pages_InfoManager, L("InfoManager"));
            context.CreatePermission(PermissionNames.Pages_InfoManager_Password, L("PasswordInfo"));
        }

        private static ILocalizableString L(string name)
        {
            return new LocalizableString(name, InfoManagerConsts.LocalizationSourceName);
        }
    }
}
