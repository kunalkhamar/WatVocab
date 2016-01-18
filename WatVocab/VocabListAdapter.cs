using Android.App;
using Android.Widget;
using Android.OS;
using System;
using System.Collections.Generic;
using Android.Content;
using Android.Views;

namespace WatVocab
{
	public class VocabListAdapter : BaseAdapter<Vocab>
	{
		private List<Vocab> items;
		private Context context;

		public VocabListAdapter(Context context, List<Vocab> items)
		{
			this.context = context;
			this.items = items;
		}

		public override int Count {
			get { return items.Count; }
		}

		public override Vocab this[int index] {
			get { return items[index]; }
		}

		public override long GetItemId (int position)
		{
			return position;
		}

		public override View GetView(int position, View convertView, ViewGroup parent)
		{
			View row = convertView;

			if (row == null) {
				row = LayoutInflater.From(context).Inflate(Resource.Layout.ListView_Vocab, null, false);
			}

			Vocab vocab = items[position];
			TextView tvName = row.FindViewById<TextView>(Resource.Id.vocabName);
			tvName.Text = vocab.name;

			TextView tvAuthor = row.FindViewById<TextView>(Resource.Id.vocabAuthor);
			tvAuthor.Text = vocab.author;

			TextView tvSize = row.FindViewById<TextView>(Resource.Id.vocabSize);
			tvSize.Text = vocab.Count + " words";

			return row;
		}
	}
}

