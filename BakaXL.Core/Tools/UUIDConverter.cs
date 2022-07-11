using System.Security.Cryptography;
using System.Text;

namespace BakaXL.Core.Tools;

public static class UUIDConverter {
	public static Guid GetOfflineUUIDFromPlayerName(string playerName) {
		var md5 = MD5.Create();
		var uuidBytes = md5.ComputeHash(Encoding.UTF8.GetBytes("OfflinePlayer:" + playerName));
		uuidBytes[6] &= 0x0f;
		uuidBytes[6] |= 0x30;
		uuidBytes[8] &= 0x3f;
		uuidBytes[8] |= 0x80;
		var uuid = new Guid(ToUUIDString(uuidBytes));
		return uuid;
	}

	private static string ToUUIDString(byte[] data) {
		long msb = 0;
		long lsb = 0;
		for (int i = 0; i < 8; i++)
			msb = (msb << 8) | (data[i] & 0xff);
		for (int i = 8; i < 16; i++)
			lsb = (lsb << 8) | (data[i] & 0xff);
		return (Digits(msb >> 32, 8) + "-" +
			Digits(msb >> 16, 4) + "-" +
			Digits(msb, 4) + "-" +
			Digits(lsb >> 48, 4) + "-" +
			Digits(lsb, 12));
	}

	private static string Digits(long val, int digits) {
		long hi = 1L << (digits * 4);
		return (hi | (val & (hi - 1))).ToString("X").Substring(1);
	}
}