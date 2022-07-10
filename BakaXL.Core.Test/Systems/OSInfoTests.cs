using BakaXL.Core.Systems;
using System.Runtime.InteropServices;

namespace BakaXL.Core.Test.Systems;

[TestClass]
public class OSInfoTests {

	[TestMethod]
	public void TestCurrentOSInfo() {
		var os = OSTypeTools.Current;
		var arch = RuntimeInformation.OSArchitecture.ToArchType();
		var bit = RuntimeInformation.OSArchitecture.ToBitType();

		var info = OSInfo.Current;
		if (os == null || arch == null || bit == null) {
			Assert.AreEqual(info, null);
			return;
		}
		Assert.AreNotEqual(info, null);
		Assert.AreEqual(info!.Type, os);
		Assert.AreEqual(info!.Arch, arch);
		Assert.AreEqual(info!.Bit, bit);

		// AppleSilicon 特殊处理
		if (os == OSType.macOS && arch == ArchType.ARM)
			CollectionAssert.AreEqual(info!.SupportedArches.ToList(), new ArchType[] { ArchType.X86, ArchType.ARM });
		else
			CollectionAssert.AreEqual(info!.SupportedArches.ToList(), new ArchType[] { arch.Value });

		CollectionAssert.AreEqual(info!.SupportedBits.ToList(), bit.Value.WithLowerBits());
	}

}
