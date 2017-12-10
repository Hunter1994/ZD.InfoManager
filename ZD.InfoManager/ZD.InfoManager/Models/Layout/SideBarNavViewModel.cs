using Abp.Application.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ZD.InfoManager.Models.Layout
{
    public class SideBarNavViewModel
    {
        public UserMenu MainMenu { get; set; }

        public string ActiveMenuItemName { get; set; }
    }
}