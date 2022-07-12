using BakaXL.Core.Tools;

namespace BakaXL.Core.Test.Tools;

[TestClass]
public class UUIDConverterTests {

	[TestMethod]
	public void TestGetOfflineUUIDFromPlayerName() {
		Assert.AreEqual(
			UUIDConverter.GetOfflineUUIDFromPlayerName("FanHua"),
			new Guid("da68088d-9574-37e9-a1d6-0a1bdc5de8db")
		);
		Assert.AreEqual(
			UUIDConverter.GetOfflineUUIDFromPlayerName("TT702"),
			new Guid("f7a2a13b-fdc7-3197-af1a-3ff42ea1c616")
		);
		Assert.AreEqual(
			UUIDConverter.GetOfflineUUIDFromPlayerName("ZhaiShu"),
			new Guid("ca2b7f48-e7e4-3fb5-ac61-7c63a5a7d5d8")
		);
	}

}
