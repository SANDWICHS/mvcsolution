﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace MvcSolution.Infrastructure.Captcha
{
    public static class HtmlHelperExtensions
    {
        public static IHtmlString Captcha(this HtmlHelper helper)
        {
            var str = "<div class='captcha'><img src='/Captcha/Refresh' alt='captcha' />";
            str +=
                "<a href='javascript:void(0);' onclick=\"$(this).closest('.captcha').find('img').attr('src','/Captcha/Refresh?timestamp='+new Date().getTime())\">Refresh</a></div>";
            return helper.Raw(str);
        }
    }
}
