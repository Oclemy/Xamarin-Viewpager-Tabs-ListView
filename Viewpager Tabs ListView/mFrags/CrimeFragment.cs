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
    class CrimeFragment : Fragment
    {
        private ListView lv;
        private String[] crime = { "BlackList", "Gotham", "Crisis", "Banshee", "Breaking Bad" };
        private ArrayAdapter adapter;

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            View rootView = inflater.Inflate(Resource.Layout.crimelayout, container, false);

            lv = rootView.FindViewById<ListView>(Resource.Id.crimeLv);

            adapter=new ArrayAdapter(this.Activity,Android.Resource.Layout.SimpleListItem1,crime);

            lv.Adapter = adapter;

            lv.ItemClick += lv_ItemClick;

            return rootView;
        }

        void lv_ItemClick(object sender, AdapterView.ItemClickEventArgs e)
        {
            Toast.MakeText(this.Activity,crime[e.Position],ToastLength.Short).Show();
        }
    }
}