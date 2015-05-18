
namespace AuthenticatingWebViewTest
{
    public interface ICertificate
    {
        string Host { get; }
        byte[] Hash { get; }
        string HashString { get; }
        byte[] PublicKey { get; }
        string PublicKeyString { get; }
    }
}
