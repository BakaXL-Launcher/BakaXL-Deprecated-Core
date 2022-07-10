using BakaXL.Core.Systems;
using System.Runtime.InteropServices;

namespace BakaXL.Core.Test.Systems;

[TestClass]
public class BitTypeTests {

	[TestMethod]
	public void TestCurrentBitType() {
		var arch = RuntimeInformation.OSArchitecture;
		switch (arch) {
			case Architecture.X86:
			case Architecture.Arm:
				Assert.AreEqual(arch.ToBitType(), BitType.X32);
				break;
			case Architecture.X64:
			case Architecture.Arm64:
				Assert.AreEqual(arch.ToBitType(), BitType.X64);
				break;
			default:
				Assert.Fail($"Unsupported operating system architecture ({arch}) for BitType");
				break;
		}
	}

	[TestMethod]
	public void TestGetBitsX32() {
		Assert.AreEqual(BitType.X32.GetBits(), 32);
	}

	[TestMethod]
	public void TestGetBitsX64() {
		Assert.AreEqual(BitType.X64.GetBits(), 64);
	}

	[TestMethod]
	public void TestWithLowerBitsX32() {
		CollectionAssert.AreEqual(BitType.X32.WithLowerBits(), new BitType[] { BitType.X32 });
	}

	[TestMethod]
	public void TestWithLowerBitsX64() {
		CollectionAssert.AreEqual(BitType.X64.WithLowerBits(), new BitType[] { BitType.X64, BitType.X32 });
	}

}
