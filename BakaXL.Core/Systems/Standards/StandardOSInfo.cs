using System.Runtime.InteropServices;

namespace BakaXL.Core.Systems.Standards;

public class StandardOSInfo : OSInfo {

	public static OSInfo? Current {

		get {
			var os = OSTypeTools.Current;
			if (os == null) return null;
			var arch = RuntimeInformation.OSArchitecture.ToArchType();
			if (arch == null) return null;
			var bit = RuntimeInformation.OSArchitecture.ToBitType();
			if (bit == null) return null;

			// AppleSilicon 特殊处理
			var arches = os == OSType.macOS && arch == ArchType.ARM
				? new ArchType[] { ArchType.ARM, ArchType.X86 }
				: new ArchType[] { arch.Value }
				;

			return new StandardOSInfo {
				Type = os.Value,
				Arch = arch.Value,
				Bit = bit.Value,

				SupportedArches = arches,
				SupportedBits = bit.Value.WithLowerBits(),
			};
		}

	}

	public OSType Type { get; init; }

	public ArchType Arch { get; init; }

	public BitType Bit { get; init; }

	public IReadOnlyList<ArchType> SupportedArches { get; init; } = Array.Empty<ArchType>();
	public IReadOnlyList<BitType> SupportedBits { get; init; } = Array.Empty<BitType>();

	public override string ToString() => $"OS({Type} <{Arch} | {Bit}>) <Supported: <Arches: [{string.Join(", ", SupportedArches)}], Bits: [{string.Join(", ", SupportedBits)}]>>";

}
