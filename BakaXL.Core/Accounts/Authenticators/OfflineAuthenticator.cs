namespace BakaXL.Core.Accounts.Authenticators;

public sealed class OfflineAuthenticator : IAuthenticator {

    public static readonly IAuthenticator Authenticator = new OfflineAuthenticator();
    
    private OfflineAuthenticator() {}

    public Task<IAuthenticationResult> Auth(IAuthenticationInfo info) {
        throw new NotImplementedException();
    }

}

public class OfflineAuthenticationInfo : IAuthenticationInfo {

    public string DisplayName { get; init; }
    public string UUID { get; init; }
    public string Properties { get; init; }
    public string AccessToken { get; init; }

    private OfflineAuthenticationInfo() {

    }

}
