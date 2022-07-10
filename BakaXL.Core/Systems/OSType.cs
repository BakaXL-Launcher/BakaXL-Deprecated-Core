using System.Runtime.InteropServices;

namespace BakaXL.Core.Systems;

public enum OSType {
	Windows,
	macOS,
	Linux,
}

public static class OSTypeTools {

	public static OSType? Current
		=> RuntimeInformation.IsOSPlatform(OSPlatform.Windows) ? OSType.Windows
		:  RuntimeInformation.IsOSPlatform(OSPlatform.OSX) ? OSType.macOS
		:  RuntimeInformation.IsOSPlatform(OSPlatform.Linux) ? OSType.Linux
		:  null;

}
