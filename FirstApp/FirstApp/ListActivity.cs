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

namespace FirstApp
{
    [Activity(Label = "ListActivity")]
    public class ListofThingsActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.list_layout);
            // Create your application here
            var listView = FindViewById<ListView>(Resource.Id.listView1);
            var cars = new string[] { "volvo", "audi", "dacia" };
            listView.Adapter = new ArrayAdapter<string>(this, Android.Resource.Layout.SimpleListItem1, cars);
        }
    }
}