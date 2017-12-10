using Abp.Web.Mvc.Views;
using ZD.InfoManager.Core;

namespace ZD.InfoManager.Views
{
    public abstract class InfoManagerWebViewPageBase: InfoManagerWebViewPageBase<dynamic>
    {
    }
    public abstract class InfoManagerWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected InfoManagerWebViewPageBase()
        {
            LocalizationSourceName = InfoManagerConsts.LocalizationSourceName;
        }
    }
}