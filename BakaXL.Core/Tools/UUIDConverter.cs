using System.Security.Cryptography;
using System.Text;

namespace BakaXL.Core.Tools;

public static class UUIDConverter {

	public static Guid GetOfflineUUIDFromPlayerName(string name) {
		var hash = MD5.Create().ComputeHash(Encoding.UTF8.GetBytes($"OfflinePlayer:{name}"));
		hash[6] &= 0x0f;
		hash[6] |= 0x30;
		hash[8] &= 0x3f;
		hash[8] |= 0x80;
		(hash[7], hash[6]) = (hash[6], hash[7]);
		(hash[5], hash[4]) = (hash[4], hash[5]);
		(hash[3], hash[0]) = (hash[0], hash[3]);
		(hash[2], hash[1]) = (hash[1], hash[2]);
		return new Guid(hash);
	}

}
