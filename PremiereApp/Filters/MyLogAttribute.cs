using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Diagnostics;

namespace PremiereApp.Filters
{
  
    public class MyLogAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            if (!EventLog.Exists("Newsletter"))
            { 
                EventLog.CreateEventSource("Newsletter", "Newsletter");
            }

            EventLog.WriteEntry("Newsletter",
                string.Format ("Controller: {0} Action: {1}",
                  filterContext.RouteData.Values["Controller"],
                  filterContext.RouteData.Values["Action"]
                ));
            base.OnActionExecuting(filterContext);
        }
    }
}