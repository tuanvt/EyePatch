﻿using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Xml.Linq;
using EyePatch.Core.Mvc.Sitemap;

namespace EyePatch.Core.Mvc.ActionResults
{
    public class XmlSiteMapResult : ActionResult
    {
        private readonly IEnumerable<ISiteMapItem> items;

        public XmlSiteMapResult(IEnumerable<ISiteMapItem> items)
        {
            this.items = items;
        }

        public override void ExecuteResult(ControllerContext context)
        {
            context.HttpContext.Response.ContentType = "application/rss+xml";
            context.HttpContext.Response.Flush();
            context.HttpContext.Response.Write(XmlSiteMap.Create(items));
        }
    }
}