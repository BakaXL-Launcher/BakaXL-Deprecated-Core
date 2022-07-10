using System.Runtime.InteropServices;

namespace BakaXL.Core.Systems;

public enum ArchType {
	X86,
	ARM,
}

public static class ArchTypeTools {

	public static ArchType? ToArchType(this Architecture architecture)
		=> architecture switch {
			Architecture.X86 => ArchType.X86,
			Architecture.X64 => ArchType.X86,
			Architecture.Arm => ArchType.ARM,
			Architecture.Arm64 => ArchType.ARM,
			_ => null,
		};

}
