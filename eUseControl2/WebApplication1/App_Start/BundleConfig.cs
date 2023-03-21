﻿using System;
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
                "~/Vendor/fontawesome/css/all.min.css", new CssRewriteUrlTransform()));

            bundles.Add(new StyleBundle("~/bundles/bootstrap/css").Include(
                "~/Vendor/bootstrap/css/bootstrap.min.css", new CssRewriteUrlTransform()));

            bundles.Add(new StyleBundle("~/bundles/jqueryui/css").Include(
                "~/Vendor/jquery-ui/jquery-ui.min.css", new CssRewriteUrlTransform()));

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

            bundles.Add(new Bundle("~/bundles/bootstrap/js").Include("~/Vendor/bootstrap/js/bootstrap.min.js"));

            bundles.Add(new Bundle("~/bundles/jquery/js").Include("~/Vendor/jquery-3.6.0.min.js"));

            bundles.Add(new Bundle("~/bundles/slick/js").Include("~/Vendor/slick/slick.min.js"));

            bundles.Add(new Bundle("~/bundles/jqueryui/js").Include("~/Vendor/jquery-ui/jquery-ui.min.js"));

            bundles.Add(new Bundle("~/bundles/popper/js").Include("~/Vendor/poper/poper.min.js"));

            bundles.Add(new Bundle("~/bundles/magnific-popup/js").Include("~/Vendor/magnific-popup/jquery.magnific-popup.min.js"));

            bundles.Add(new Bundle("~/bundles/isotope/js").Include("~/Vendor/isotope.min.js"));

            bundles.Add(new Bundle("~/bundles/imgloaded/js").Include("~/Vendor/imagesloaded.min.js"));

            bundles.Add(new Bundle("~/bundles/counterup/js").Include("~/Vendor/jquery.counterup.min.js"));

            bundles.Add(new Bundle("~/bundles/waypoints/js").Include("~/Vendor/jquery.waypoints.js"));

            bundles.Add(new Bundle("~/bundles/nice-select/js").Include("~/Vendor/nice-select/js/jquery.nice-select.min.js"));

            bundles.Add(new Bundle("~/bundles/wow/js").Include("~/Vendor/wow.min.js"));

            bundles.Add(new Bundle("~/bundles/theme/js").Include("~/Scripts/js/theme.js"));

        }
    }
}