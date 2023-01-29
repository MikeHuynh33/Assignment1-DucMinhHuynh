using System.Web;
using System.Web.Mvc;

namespace Assignment1_DucMinhHuynh
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
