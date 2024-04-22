using eUseControl.BuisnessLogic.Interfaces;
using eUseControl.Domain.Enums;
using eUseControl.Web.Extension;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
public class AdminModeAttribute : ActionFilterAttribute
{
    public override void OnActionExecuting(ActionExecutingContext filterContext)
    {
        string userRole = filterContext.HttpContext.Session["UserRole"] as string;
        if (userRole != "Admin")
        {
            filterContext.Result = new ViewResult
            {
                ViewName = "Error"
            };
        }
    }
}