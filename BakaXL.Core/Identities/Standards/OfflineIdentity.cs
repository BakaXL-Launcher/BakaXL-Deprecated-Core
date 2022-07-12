using BakaXL.Core.Launchers;
using BakaXL.Core.Tools;

namespace BakaXL.Core.Identities.Standards;

public class OfflineIdentity : IIdentity {

	protected virtual string PlayerType => "legacy";

	public Guid PlayerId { get; }

	public string PlayerName { get; }

	public OfflineIdentity(Guid id, string name) {
		PlayerId = id;
		PlayerName = name;
	}

	public OfflineIdentity(string name) : this(UUIDConverter.GetOfflineUUIDFromPlayerName(name), name) {}

	public void SetLaunchProperties(LaunchProperties properties) {
		properties.PlayerType = PlayerType;
		properties.PlayerId = PlayerId;
		properties.PlayerName = PlayerName;
		properties.PlayerProperties = "{}";
		properties.AccessToken = Guid.NewGuid().ToString("N");
	}

	public ValueTask<IIdentity> Auth() {
		return new ValueTask<IIdentity>(this);
	}

}
