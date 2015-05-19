using System;
using Android.Net.Http;

namespace AuthenticatingWebViewTest.Droid
{
    public class Certificate : ICertificate
    {
        private readonly string _host;
        private readonly SslCertificate _certificate;

        public Certificate(string host, SslCertificate certificate)
        {
            _host = host;
            _certificate = certificate;
        }

        #region ICertificate implementation

        public string Host { get { return _host; } }

        public byte[] Hash {
            get {
                throw new NotImplementedException ();
            }
        }

        public string HashString {
            get {
                throw new NotImplementedException ();
            }
        }

        public byte[] PublicKey {
            get {
                throw new NotImplementedException ();
            }
        }

        public string PublicKeyString {
            get {
                throw new NotImplementedException ();
            }
        }

        #endregion
    }
}

