using BakaXL.Core.Identities.Standards;
using BakaXL.Core.Launchers;

namespace BakaXL.Core.Test.Identities.Standards;

[TestClass]
public class OfflineIdentityTests {

	[TestMethod]
	public void TestSetLaunchProperties() {
		var properties = new LaunchProperties();
		new OfflineIdentity("FanHua").SetLaunchProperties(properties);
		CollectionAssert.AreEquivalent(properties, new Dictionary<string, string> {
			["user_type"] = "legacy",
			["auth_uuid"] = "da68088d957437e9a1d60a1bdc5de8db",
			["auth_player_name"] = "FanHua",
			["user_properties"] = "{}",
			["auth_access_token"] = "da68088d957437e9a1d60a1bdc5de8db",
			["auth_session"] = "da68088d957437e9a1d60a1bdc5de8db",
		});
	}

	[TestMethod]
	public void TestRandomIdSetLaunchProperties() {
		var id = Guid.NewGuid();
		var properties = new LaunchProperties();
		new OfflineIdentity(id, "Random").SetLaunchProperties(properties);
		CollectionAssert.AreEquivalent(properties, new Dictionary<string, string> {
			["user_type"] = "legacy",
			["auth_uuid"] = id.ToString("N"),
			["auth_player_name"] = "Random",
			["user_properties"] = "{}",
			["auth_access_token"] = id.ToString("N"),
			["auth_session"] = id.ToString("N"),
		});
	}

}

