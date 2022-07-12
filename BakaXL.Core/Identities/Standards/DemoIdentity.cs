namespace BakaXL.Core.Identities.Standards;

public class DemoIdentity : OfflineIdentity {
	
	protected override string PlayerType => "demo";

	public DemoIdentity(string name) : base(name) {}

	public DemoIdentity(Guid id, string name) : base(id, name) {}

}
