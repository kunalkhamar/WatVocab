using System;
using System.Collections.Generic;

namespace WatVocab
{
	public class Language
	{
		string stFull;
		string stCode;
		string stRegion;

		public Language (string stCode, string stRegion)
		{
			this.stCode = stCode;
			this.stRegion = stRegion;
		}

		public static string[] CODES = { "en", "es", "ko" };
		public static string[] LANGS = { "English", "Spanish", "Korean" };
		public static Dictionary<string, string> mapcode_full;

		public static string getFull(string code) {
			if (mapcode_full == null) {
				mapcode_full = new Dictionary<string, string> ();
				for (int i = 0; i < CODES.Length; i++) {
					mapcode_full.Add (CODES[i], LANGS[i]);
				}
			}
			string ret;
			mapcode_full.TryGetValue(code, out ret);
			return ret;
		}
	}
}
