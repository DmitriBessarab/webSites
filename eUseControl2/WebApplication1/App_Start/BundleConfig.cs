using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace WebApplication1.App_Start
{
    public static class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/bundles/fontawesome/css").Include(
                "~/Content/font-awesome.min.css", new CssRewriteUrlTransform()));

            bundles.Add(new StyleBundle("~/bundles/bootstrap/css").Include(
                "~/Content/bootstrap.min.css", new CssRewriteUrlTransform()));

            bundles.Add(new StyleBundle("~/bundles/jqueryui/css").Include(
                "~/Content/jquery-ui.css", new CssRewriteUrlTransform()));

            bundles.Add(new StyleBundle("~/bundles/niceselect/css").Include(
                "~/Vendor/nice-select/css/nice-select.css", new CssRewriteUrlTransform()));

            bundles.Add(new StyleBundle("~/bundles/slick/css").Include(
                "~/Vendor/slick/slick.css", new CssRewriteUrlTransform()));

            bundles.Add(new StyleBundle("~/bundles/animate/css").Include(
                "~/Vendor/animate.css", new CssRewriteUrlTransform()));

            bundles.Add(new StyleBundle("~/bundles/default/css").Include(
                "~/Vendor/default.css", new CssRewriteUrlTransform()));

            bundles.Add(new StyleBundle("~/bundles/style/css").Include(
                "~/Vendor/style.css", new CssRewriteUrlTransform()));

            bundles.Add(new StyleBundle("~/bundles/flaticon/css").Include(
                "~/Vendor/flaticon/flaticon.css", new CssRewriteUrlTransform()));

            bundles.Add(new StyleBundle("~/bundles/magnific-popup/css").Include(
                "~/Vendor/magnific-popup/dist/magnific-popup.css", new CssRewriteUrlTransform()));

            bundles.Add(new Bundle("~/bundles/bootstrap/js").Include("~/Scripts/bootstrap.min.js"));

            bundles.Add(new Bundle("~/bundles/jquery/js").Include("~/Scripts/jquery-3.6.3.js"));

            bundles.Add(new Bundle("~/bundles/slick/js").Include("~/Vendor/slick/slick.min.js"));

            bundles.Add(new Bundle("~/bundles/jqueryui/js").Include("~/Scripts/jquery-ui.js"));


        }
    }
}