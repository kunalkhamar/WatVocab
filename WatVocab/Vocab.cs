using System;
using System.Collections.Generic;

namespace WatVocab
{
	public class Vocab
	{
		public string Name { get; set; }
		public string Author { get; set; }
		public List<Note> Notes { get; set; }
		public int Count {
			get { return Notes != null ? Notes.Count : 0; }
		}

		public Vocab(): this(new List<Note>()) {}

		public Vocab (List<Note> notes) {
			this.Notes = notes;
		}

		public void Add(Note n) 
		{
			Notes.Add(n);
		}
	}
}
	