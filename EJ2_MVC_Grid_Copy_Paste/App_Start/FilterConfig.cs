using System.Web;
using System.Web.Mvc;

namespace EJ2_MVC_Grid_Copy_Paste
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
