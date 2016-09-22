using Abp.Web.Mvc.Views;

namespace tigerball.Web.Views
{
    public abstract class tigerballWebViewPageBase : tigerballWebViewPageBase<dynamic>
    {

    }

    public abstract class tigerballWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected tigerballWebViewPageBase()
        {
            LocalizationSourceName = tigerballConsts.LocalizationSourceName;
        }
    }
}