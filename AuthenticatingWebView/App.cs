using System;

using Xamarin.Forms;

namespace AuthenticatingWebViewTest
{
    public class App : Application
    {
        public App ()
        {
            var webView = new AuthenticatingWebView()
            {
                Source = new UrlWebViewSource { Url = "https://google.com" },
                ShouldTrustCertificate = cert =>
                {
                    return false;
                },
            };
            webView.Navigated += (sender, e) =>
            {
                if (e.Result == WebNavigationResult.Failure)
                {
                    webView.Source = new UrlWebViewSource { Url = "http://google.com" };
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

