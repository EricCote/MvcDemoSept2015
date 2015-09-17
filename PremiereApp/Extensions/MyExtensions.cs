using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace PremiereApp.Extensions
{
    public static class MyExtensions
    {
        public static HtmlString GlyphActionLink(this HtmlHelper html,
                                         string icon,
                                         string text,
                                         string actionName,
                                         object routeValues)
        {
 
            UrlHelper url = new UrlHelper(html.ViewContext.RequestContext);
            string result =
            @"<a href='" + url.Action(actionName, routeValues) + "' title='" + text + "' >" +
                    "<span class='glyphicon glyphicon-" + icon + "'></span> " +
                    "<span class='sr-only'>" + text + "</span>" +
                    "</a>";
            return new HtmlString(result);

        }




        public static HtmlString Img(this HtmlHelper html,
                                     int width, int height, string src)
        {
            //string result = string.Format(
            //    "<img width='{0}' height='{1}' src='{2}' />",
            //    width, height, src);

            TagBuilder img = new TagBuilder("img");
            img.Attributes.Add("Height", height.ToString());
            img.Attributes.Add("Width", width.ToString());
            img.Attributes.Add("src", src);

            string result = img.ToString(TagRenderMode.SelfClosing);

            return new HtmlString(result);
        }
    }
}