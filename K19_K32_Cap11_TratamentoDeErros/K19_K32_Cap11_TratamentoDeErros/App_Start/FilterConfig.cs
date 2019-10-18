using System.Web;
using System.Web.Mvc;

namespace K19_K32_Cap11_TratamentoDeErros
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}