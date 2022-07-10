using BakaXL.Core.Systems.Standards;

namespace BakaXL.Core.Systems;

public interface OSInfo {

	public static OSInfo? Current => StandardOSInfo.Current;

	OSType Type { get; }
	ArchType Arch { get; }
	BitType Bit { get; }

	IReadOnlyList<ArchType> SupportedArches { get; }
	IReadOnlyList<BitType> SupportedBits { get; }

}
