using Microsoft.AspNetCore.Mvc;
using SimpleMvcSitemap;

namespace seandouganwebsite.Controllers;

public class SitemapController : BaseController
{
    public ActionResult Index()
    {
        // Create a list of all URLs you want to include in the sitemap.
        var nodes = new List<SitemapNode>
        {
            new SitemapNode(Url.Action("Index", "Home", null, Request.Scheme)),
            new SitemapNode(Url.Action("Index", "Contact", null, Request.Scheme)),
            new SitemapNode(Url.Action("Index", "FreeServices", null, Request.Scheme)),
            new SitemapNode(Url.Action("Index", "Games", null, Request.Scheme)),
            new SitemapNode(Url.Action("Index", "Learning", null, Request.Scheme)),
            new SitemapNode(Url.Action("Index", "Partner", null, Request.Scheme)),
            new SitemapNode(Url.Action("Index", "ThisApplication", null, Request.Scheme)),
            // Add more nodes here.
        };

        // Generate the sitemap XML.
        return new SitemapProvider().CreateSitemap(new SitemapModel(nodes));
    }
}