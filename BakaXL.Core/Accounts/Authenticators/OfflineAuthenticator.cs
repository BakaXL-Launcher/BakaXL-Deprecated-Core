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

    public OfflineAuthenticationInfo(string displayName) {
		DisplayName = displayName;
    }
}

public class OfflineAuthenticationResult : IAuthenticationResult {
    public string DisplayName { get; set; }
    public Guid UUID { get; set; }
    public string Properties { get; set; }
    public string AccessToken { get; set; }

	public OfflineAuthenticationResult(OfflineAuthenticationInfo authenticationInfo) {
		DisplayName = authenticationInfo.DisplayName;
		UUID = Tools.UUIDConverter.GetOfflineUUIDFromPlayerName(authenticationInfo.DisplayName);
		AccessToken = Guid.NewGuid().ToString("N").ToLower();
		Properties = "{}";
	}
}
