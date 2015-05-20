using System.Security.Cryptography.X509Certificates;

namespace AuthenticatingWebViewTest.iOS
{
    public class Certificate : ICertificate
    {
        private readonly string _host;
        private readonly X509Certificate2 _certificate;

        public Certificate(string host, X509Certificate2 certificate)
        {
            _host = host;
            _certificate = certificate;
        }

        public string Host { get { return _host; } }

        public byte[] Hash { get { return _certificate.GetCertHash(); } }

        public string HashString { get { return _certificate.GetCertHashString(); } }

        public byte[] PublicKey { get { return _certificate.GetPublicKey(); } }

        public string PublicKeyString { get { return _certificate.GetPublicKeyString(); } }
    }
}

