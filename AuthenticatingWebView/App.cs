using Xamarin.Forms;

namespace AuthenticatingWebViewTest
{
    public class App : Application
    {
        public App ()
        {
            var webView = new AuthenticatingWebView()
            {
                // This site happens to have an unverified certificate.
                Source = new UrlWebViewSource { Url = "https://www.pcwebshop.co.uk/" },
                ShouldTrustUnknownCertificate = cert => true,
            };

            webView.Navigated += (sender, e) =>
            {
                if (e.Result == WebNavigationResult.Failure)
                {
                    webView.Source = new UrlWebViewSource { Url = "http://blog.adamkemp.com" };
                }
            };

            MainPage = new ContentPage { Content = webView };
        }
    }
}

