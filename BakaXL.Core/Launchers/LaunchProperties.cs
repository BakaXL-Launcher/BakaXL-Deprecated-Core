namespace BakaXL.Core.Launchers;

public class LaunchProperties : Dictionary<string, string> {

	public string PlayerType { set => this["user_type"] = value; }
	public Guid PlayerId { set => this["auth_uuid"] = value.ToString("N"); }
	public string PlayerName { set => this["auth_player_name"] = value; }
	public string PlayerProperties { set => this["user_properties"] = value; }
	public string AccessToken {
		set {
			this["auth_access_token"] = value;
			// 旧版本兼容
			this["auth_session"] = value;
		}
	}


}
