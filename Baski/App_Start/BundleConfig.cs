using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace Baski.App_Start
{
    public static class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {

            var scriptsBundle = new ScriptBundle("~/bundles/js")
                .Include("~/assets/plugins/jquery-2.0.3.min.js")
                .Include("~/assets/plugins/jquery.easing.1.3.js")
                .Include("~/assets/plugins/jquery.cookie.js")
                .Include("~/assets/plugins/jquery.appear.js")
                .Include("~/assets/plugins/jquery.isotope.js")
                .Include("~/assets/plugins/masonry.js")
                .Include("~/assets/plugins/bootstrap/js/bootstrap.min.js")
                .Include("~/assets/plugins/magnific-popup/jquery.magnific-popup.min.js")
                .Include("~/assets/plugins/owl-carousel/owl.carousel.min.js")
                .Include("~/assets/plugins/stellar/jquery.stellar.min.js")
                .Include("~/assets/plugins/knob/js/jquery.knob.js")
                .Include("~/assets/plugins/jquery.backstretch.min.js")
                .Include("~/assets/plugins/superslides/dist/jquery.superslides.min.js")
                .Include("~/assets/js/scripts.js")
                .Include("~/assets/plugins/revolution-slider/js/jquery.themepunch.plugins.min.js")
                .Include("~/assets/plugins/revolution-slider/js/jquery.themepunch.revolution.min.js")
                .Include("~/assets/js/slider_revolution.js")
                .Include("~/Scripts/baski.js");

            var modernizr = new ScriptBundle("~/bundles/modernizr")
                .Include("~/assets/plugins/modernizr.min.js");

            var stylesBundle = new StyleBundle("~/bundles/css")
                .Include("~/assets/plugins/bootstrap/css/bootstrap.min.css", new CssRewriteUrlTransform())
                .Include("~/assets/css/font-awesome.css", new CssRewriteUrlTransform())
                .Include("~/assets/plugins/owl-carousel/owl.carousel.css", new CssRewriteUrlTransform())
                .Include("~/assets/plugins/owl-carousel/owl.theme.css", new CssRewriteUrlTransform())
                .Include("~/assets/plugins/owl-carousel/owl.transitions.css", new CssRewriteUrlTransform())
                .Include("~/assets/plugins/magnific-popup/magnific-popup.css", new CssRewriteUrlTransform())
                .Include("~/assets/css/animate.css", new CssRewriteUrlTransform())
                .Include("~/assets/css/superslides.css", new CssRewriteUrlTransform())
                .Include("~/assets/css/essentials.css", new CssRewriteUrlTransform())
                .Include("~/assets/css/layout.css", new CssRewriteUrlTransform())
                .Include("~/assets/css/layout-responsive.css", new CssRewriteUrlTransform())
                .Include("~/assets/css/color_scheme/darkblue.css", new CssRewriteUrlTransform())
                .Include("~/assets/css/layout-dark.css", new CssRewriteUrlTransform())
                .Include("~/assets/plugins/revolution-slider/css/settings.css", new CssRewriteUrlTransform())
                .Include("~/Styles/baski.css");
            
            bundles.Add(modernizr);
            bundles.Add(scriptsBundle);
            bundles.Add(stylesBundle);
        }
    }
}