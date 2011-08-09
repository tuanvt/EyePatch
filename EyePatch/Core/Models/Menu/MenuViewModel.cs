﻿using System.Collections.Generic;
using System.Web;
using EyePatch.Core.Entity;

namespace EyePatch.Core.Models.Menu
{
    public class MenuViewModel : List<MenuItem>
    {
        public MenuViewModel(IEnumerable<Page> pages, HttpRequestBase request)
        {
            foreach (var page in pages)
            {
                var requestUrl = !request.Path.EndsWith("/") ? request.Path + "/" : request.Path;
                var pageUrl = !page.Url.EndsWith("/") ? page.Url + "/" : page.Url;

                Add(new MenuItem(page.Title, page.Url, page.Description, pageUrl == requestUrl));
            }
        }
    }
}