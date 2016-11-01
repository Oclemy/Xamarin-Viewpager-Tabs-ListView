using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.V4.App;
using Android.Views;
using Android.Widget;

namespace Viewpager_Tabs_ListView.mFrags
{
    class DocumentaryFragment : Fragment
    {

        private ListView lv;
        private ArrayAdapter adapter;
        private String[] documentaries = { "Death of The Sun", "The Milky Way", "Planets From Hell", "How to Make a Jet Engine", "Speed of Light" };

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            View rootView = inflater.Inflate(Resource.Layout.documentary, container, false);

            lv = rootView.FindViewById<ListView>(Resource.Id.docLv);

            adapter = new ArrayAdapter(this.Activity, Android.Resource.Layout.SimpleListItem1, documentaries);

            lv.Adapter = adapter;

            lv.ItemClick += lv_ItemClick;

            return rootView;
        }

        void lv_ItemClick(object sender, AdapterView.ItemClickEventArgs e)
        {
            Toast.MakeText(this.Activity, documentaries[e.Position], ToastLength.Short).Show();
        }
    }
}