using Xamarin.Forms;

namespace AuthenticatingWebViewTest
{
    public delegate bool ShouldTrustCertificate(ICertificate certificate);
    public class AuthenticatingWebView : WebView
    {
        public ShouldTrustCertificate ShouldTrustCertificate { get; set; }
    }
}

