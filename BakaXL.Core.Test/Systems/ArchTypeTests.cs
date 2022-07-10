using BakaXL.Core.Systems;
using System.Runtime.InteropServices;

namespace BakaXL.Core.Test.Systems;

[TestClass]
public class ArchTypeTests {
	
	[TestMethod]
	public void TestCurrentArchType() {
		var arch = RuntimeInformation.OSArchitecture;
		switch (arch) {
			case Architecture.X86:
			case Architecture.X64:
				Assert.AreEqual(arch.ToArchType(), ArchType.X86);
				break;
			case Architecture.Arm:
			case Architecture.Arm64:
				Assert.AreEqual(arch.ToArchType(), ArchType.ARM);
				break;
			default:
				Assert.Fail($"Unsupported operating system architecture ({arch}) for ArchType");
				break;
		}
	}

}
