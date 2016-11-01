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
    class DramaFragment : Fragment
    {
        private ListView lv;
        private String[] drama = { "Banshee", "Hannibal", "Burn Notice", "Men In Black", "Game of Thrones", "Blindspot" };
        private ArrayAdapter adapter;

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            View rootView = inflater.Inflate(Resource.Layout.dramalayout, container, false);

            lv = rootView.FindViewById<ListView>(Resource.Id.dramaLv);

            adapter = new ArrayAdapter(this.Activity, Android.Resource.Layout.SimpleListItem1, drama);

            lv.Adapter = adapter;

            lv.ItemClick += lv_ItemClick;

            return rootView;
        }

        void lv_ItemClick(object sender, AdapterView.ItemClickEventArgs e)
        {
            Toast.MakeText(this.Activity,drama[e.Position],ToastLength.Short).Show();
        }
    }
}