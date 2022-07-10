using System.Runtime.InteropServices;

namespace BakaXL.Core.Systems;

public enum BitType {
	X32,
	X64,
}

public static class BitTypeTools {

	public static BitType? ToBitType(this Architecture architecture)
		=> architecture switch {
			Architecture.X86 => BitType.X32,
			Architecture.Arm => BitType.X32,
			Architecture.X64 => BitType.X64,
			Architecture.Arm64 => BitType.X32,
			_ => null,
		};

	public static ushort GetBits(this BitType type)
		=> type switch {
			BitType.X32 => 32,
			BitType.X64 => 64,
			_ => throw new NotImplementedException(),
		};

	public static BitType[] WithLowerBits(this BitType type)
		=> type switch {
			BitType.X32 => new BitType[] { BitType.X32 },
			BitType.X64 => new BitType[] { BitType.X64, BitType.X32 },
			_ => throw new NotImplementedException(),
		};

}
