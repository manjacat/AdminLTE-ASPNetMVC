using System.Web;
using System.Web.Optimization;

namespace AdminLTE_ASPNetMVC
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            // JavaScript
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                         "~/plugins/jquery/jquery.min.js",
                        "~/plugins/jquery-ui/jquery-ui.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/adminlte").Include(
                        "~/plugins/bootstrap/js/bootstrap.bundle.min.js",
                        "~/plugins/chart.js/Chart.min.js",
                        "~/plugins/sparklines/sparkline.js",
                        "~/plugins/jqvmap/jquery.vmap.min.js",
                        "~/plugins/jquery-knob/jquery.knob.min.js",
                        "~/plugins/moment/moment.min.js",
                        "~/plugins/daterangepicker/daterangepicker.js",
                        "~/plugins/tempusdominus-bootstrap-4/js/tempusdominus-bootstrap-4.min.js",
                        "~/plugins/summernote/summernote-bs4.min.js",
                        "~/plugins/overlayScrollbars/js/jquery.overlayScrollbars.min.js",
                        "~/plugins/sweetalert2/sweetalert2.min.js",
                        "~/plugins/toastr/toastr.min.js",
                        "~/dist/js/adminlte.js",
                        "~/dist/js/demo.js"));

            // CSS
            bundles.Add(new StyleBundle("~/adminlte/css").Include(
                      "~/plugins/fontawesome-free/css/all.min.css",
                      "~/plugins/tempusdominus-bootstrap-4/css/tempusdominus-bootstrap-4.min.css",
                      "~/plugins/icheck-bootstrap/icheck-bootstrap.min.css",
                      "~/plugins/jqvmap/jqvmap.min.css",
                      "~/dist/css/adminlte.min.css",
                      "~/plugins/overlayScrollbars/css/OverlayScrollbars.min.css",
                      "~/plugins/daterangepicker/daterangepicker.css",
                      "~/plugins/summernote/summernote-bs4.min.css",
                      "~/plugins/sweetalert2-theme-bootstrap-4/bootstrap-4.min.css",
                      "~/plugins/toastr/toastr.min.css"));
        }
    }
}
