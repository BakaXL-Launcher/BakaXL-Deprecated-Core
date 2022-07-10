namespace BakaXL.Core.Test {
	[TestClass]
	public class CoreTest {
		[TestMethod]
		public void SaySomething() {
			var result = "Hello World";
			Assert.AreEqual(result, First.Hello());
		}
	}
}