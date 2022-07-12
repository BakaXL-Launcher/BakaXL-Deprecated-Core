using BakaXL.Core.Identities.Standards;
using BakaXL.Core.Launchers;

namespace BakaXL.Core.Test.Launchers;

[TestClass]
public class LaunchPropertiesTests {

	[TestMethod]
	public void TestLaunchProperties() {
		var properties = new LaunchProperties();
		properties.PlayerType = "legacy";
		properties.PlayerId = new Guid("da68088d-9574-37e9-a1d6-0a1bdc5de8db");
		properties.PlayerName = "FanHua";
		properties.PlayerProperties = "{}";
		properties.AccessToken = "da68088d957437e9a1d60a1bdc5de8db";

		CollectionAssert.AreEquivalent(properties, new Dictionary<string, string> {
			["user_type"] = "legacy",
			["auth_uuid"] = "da68088d957437e9a1d60a1bdc5de8db",
			["auth_player_name"] = "FanHua",
			["user_properties"] = "{}",
			["auth_access_token"] = "da68088d957437e9a1d60a1bdc5de8db",
			["auth_session"] = "da68088d957437e9a1d60a1bdc5de8db",
		});
	}

}

