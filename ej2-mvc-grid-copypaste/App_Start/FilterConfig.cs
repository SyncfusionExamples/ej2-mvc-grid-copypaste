using System.Web;
using System.Web.Mvc;

namespace ej2_mvc_grid_copypaste
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
