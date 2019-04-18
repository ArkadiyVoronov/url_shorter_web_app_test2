using System.Web;
using System.Web.Mvc;

namespace url_shorter_web_app_test2
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
