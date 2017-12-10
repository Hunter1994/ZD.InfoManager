using Abp.Application.Navigation;
using Abp.Localization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ZD.InfoManager.Core;
using ZD.InfoManager.Core.Authorization;

namespace ZD.InfoManager.App_Start
{
    public class InfoManagerNavigationProvider : NavigationProvider
    {
        public override void SetNavigation(INavigationProviderContext context)
        {
            context.Manager.MainMenu
            .AddItem(
                new MenuItemDefinition(
                    PageNames.Home,
                    L("HomePage"),
                    url: "",
                    icon: "home",
                    requiresAuthentication: true
                )
            ).AddItem(
                new MenuItemDefinition(
                    PageNames.Tenants,
                    L("Tenants"),
                    url: "Tenants",
                    icon: "business",
                    requiredPermissionName: PermissionNames.Pages_Tenants
                )
            ).AddItem(
                new MenuItemDefinition(
                    PageNames.Users,
                    L("Users"),
                    url: "Users",
                    icon: "people",
                    requiredPermissionName: PermissionNames.Pages_Users
                )
            ).AddItem(
                new MenuItemDefinition(
                    PageNames.Roles,
                    L("Roles"),
                    url: "Roles",
                    icon: "local_offer",
                    requiredPermissionName: PermissionNames.Pages_Roles
                )
            ).AddItem(
                new MenuItemDefinition(
                    PageNames.InfoMangers,
                    L("InfoManager"),
                    icon: "lock",
                    requiredPermissionName: PermissionNames.Pages_InfoManager
                ).AddItem(new MenuItemDefinition(
                    PageNames.InfoMangers_Passowrd,
                    L("Infos"),
                    url: "PasswordInfo",
                    icon: "lock",
                    requiredPermissionName: PermissionNames.Pages_InfoManager_Password)
            ));

        }

        private static ILocalizableString L(string name)
        {
            return new LocalizableString(name, InfoManagerConsts.LocalizationSourceName);
        }
    }
}