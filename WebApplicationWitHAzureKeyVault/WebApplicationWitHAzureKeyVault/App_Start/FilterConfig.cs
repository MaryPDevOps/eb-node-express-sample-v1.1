using System.Web.Mvc;

namespace WebApplicationWitHAzureKeyVault
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
