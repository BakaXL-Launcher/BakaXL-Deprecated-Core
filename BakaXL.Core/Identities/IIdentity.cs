using BakaXL.Core.Launchers;

namespace BakaXL.Core.Identities;

public interface IIdentity : ILaunchProperty {

	Guid PlayerId { get; }
	string PlayerName { get; }

	ValueTask<IIdentity> Auth();

}
