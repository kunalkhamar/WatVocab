using System;
using System.Collections.Generic;

namespace WatVocab
{
	/*
	 * TODO
	 * - synonym support?
	 * - use language locale?
	 */
	public class Word
	{
		Dictionary<Language, string> translations;

		public Word(Language lang, string st)
		{
			translations = new Dictionary<Language, string> ();
			translations.Add (lang, st);
		}

		public void Add(Language lang, string st) {
			translations.Add(lang, st);
		}
	}
}
