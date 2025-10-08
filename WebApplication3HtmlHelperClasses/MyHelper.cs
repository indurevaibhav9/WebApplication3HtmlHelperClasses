using Microsoft.AspNetCore.Html;

namespace WebApplication3HtmlHelperClasses
{
    public static class MyHelper
    {
        public static HtmlString Button(string type, string value)
        {
            return new HtmlString(String.Format("<input type = '{0}' value='{1}' />", type, value));
        }

        public static HtmlString Image(string src, string alt="", string height="", string width = "")
        {
            return new HtmlString(String.Format("<img src='{0}' alt='{1}' height='{2}' width='{3}' />", src, alt, height, width));
        }
    }
}
