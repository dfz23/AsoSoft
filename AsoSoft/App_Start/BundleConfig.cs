﻿using System.Web;
using System.Web.Optimization;

namespace AsoSoft
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-3.1.1.js"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            //bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
            //            "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));

            //bundles.Add(new ScriptBundle("~/bundles/angularJS").Include(
            //         "~/Scripts/angular.js"));

            bundles.Add(new ScriptBundle("~/bundles/customJS").Include(
                                 "~/Content/BookScripts/Module.js",
                                 "~/Content/BookScripts/Service.js",
                                 "~/Content/BookScripts/Controller.js"));
        }
    }
}
