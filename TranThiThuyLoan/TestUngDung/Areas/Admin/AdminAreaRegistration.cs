using System.Web.Mvc;

namespace TestUngDung.Areas.Admin
{
    public class AdminAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Admin";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
               "xem chi tiet",
               "Admin/{controller}/{action}/{id}",
               new { controller = "Product", action = "Detail", id = UrlParameter.Optional }
            );
            context.MapRoute(
               "Create_default",
               "Admin/{controller}/{action}/{product}",
               new { controller = "Product", action = "create", user = UrlParameter.Optional }
           );
            context.MapRoute(
               "Delete_default",
               "Admin/{controller}/{action}/{user}",
               new { controller = "UserAccount", action = "Delete", user = UrlParameter.Optional }
           );

            context.MapRoute(
                "User_Index_default",
                "Admin/{controller}",
                new { controller = "UserAccount", id = UrlParameter.Optional }
            );
            context.MapRoute(
                "Admin_default",
                "Admin/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}