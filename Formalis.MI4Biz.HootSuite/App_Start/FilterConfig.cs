using System.Web;
using System.Web.Mvc;

namespace Formalis.MI4Biz.HootSuite
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
