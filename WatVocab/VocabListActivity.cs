
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace WatVocab
{
	[Activity (Label = "@string/vocabs")]			
	public class VocabListActivity : Activity
	{
		private List<Vocab> vocabs;
		private ListView lvvocabs;

		protected override void OnCreate (Bundle savedInstanceState)
		{
			base.OnCreate (savedInstanceState);
			SetContentView (Resource.Layout.VocabList);
			lvvocabs = FindViewById<ListView> (Resource.Id.listViewVocabs);

			Note note1 = new Note ("front 1", "back 1");
			Note note2 = new Note ("front 2", "back 2");
			List<Note> notes = new List<Note>{ note1, note2 };

			vocabs = new List<Vocab>();
			vocabs.Add(new Vocab(notes) { name = "James Bond", author = "Sherlock Holmes" });
			// get vocabs from DB

			//ArrayAdapter<Vocab> adapter = new ArrayAdapter(this, FindViewById<Vocab>(Resource.Id.listViewVocabs));
			VocabListAdapter adapter = new VocabListAdapter(this, vocabs);
			lvvocabs.Adapter = adapter;
		}
	}
}

