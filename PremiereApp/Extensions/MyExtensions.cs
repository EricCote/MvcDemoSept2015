using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PremiereApp.Extensions
{
    public static class MyExtensions
    {
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