using System;

namespace WatVocab
{
	public class Note
	{
		public static bool FRONT = false, BACK = true;

		bool orient;
		string front, back;

		public Note (string front) : this(front, "", FRONT) {}

		public Note (string front, string back) : this(front, back, FRONT) {}

		public Note(string front, string back, bool orient) {
			this.front = front;
			this.back = back;
			this.orient = orient;
		}
	}
}
