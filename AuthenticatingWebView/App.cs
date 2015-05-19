using Xamarin.Forms;

namespace AuthenticatingWebViewTest
{
    public class App : Application
    {
        public App ()
        {
            var webView = new AuthenticatingWebView()
            {
                Source = new UrlWebViewSource { Url = "https://www.pcwebshop.co.uk/" },
                ShouldTrustCertificate = cert =>
                {
                    return true;
                },
            };
            webView.Navigated += (sender, e) =>
            {
                if (e.Result == WebNavigationResult.Failure)
                {
                    webView.Source = new UrlWebViewSource { Url = "http://blog.adamkemp.com" };
                }
            };
            MainPage = new ContentPage {
                Content = webView,
            };
        }

        protected override void OnStart ()
        {
            // Handle when your app starts
        }

        protected override void OnSleep ()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume ()
        {
            // Handle when your app resumes
        }
    }
}

