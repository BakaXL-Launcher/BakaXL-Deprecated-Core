using BakaXL.Core.Systems;
using System.Runtime.InteropServices;

namespace BakaXL.Core.Test.Systems;

[TestClass]
public class OSTypeTests {

	[TestMethod]
	public void TestCurrentOSType() {
		if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
			Assert.AreEqual(OSTypeTools.Current, OSType.Windows);
		else if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
			Assert.AreEqual(OSTypeTools.Current, OSType.macOS);
		else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
			Assert.AreEqual(OSTypeTools.Current, OSType.Linux);
		else
			Assert.Fail("Unsupported operating system for OSType");
	}

}
