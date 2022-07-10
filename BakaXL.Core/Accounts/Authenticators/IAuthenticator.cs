namespace BakaXL.Core.Accounts.Authenticators;

/// <summary>
/// 认证器 Authenticator
/// </summary>
public interface IAuthenticator {
	/// <summary>
	/// 认证 Begin the Authenticaton
	/// </summary>
	/// <returns>认证信息 Authentication Result</returns>
	Task<IAuthenticationResult> Auth(IAuthenticationInfo info);
}
