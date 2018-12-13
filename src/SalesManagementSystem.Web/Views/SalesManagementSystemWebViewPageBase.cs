using Abp.Web.Mvc.Views;

namespace SalesManagementSystem.Web.Views
{
    public abstract class SalesManagementSystemWebViewPageBase : SalesManagementSystemWebViewPageBase<dynamic>
    {

    }

    public abstract class SalesManagementSystemWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected SalesManagementSystemWebViewPageBase()
        {
            LocalizationSourceName = SalesManagementSystemConsts.LocalizationSourceName;
        }
    }
}