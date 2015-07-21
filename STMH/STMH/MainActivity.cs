using System;
using Android.App;
using System.Collections.Generic;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace STMH
{
    [Activity(Label = "STMH", MainLauncher = true, Icon = "@drawable/icon", Theme = "@android:style/Theme.DeviceDefault.NoActionBar.Fullscreen")]
    public class MainActivity : Activity
    {
        private List<string> itemList;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            //Setup Listview
            itemList = new List<string>();
            ListView itemListView = (ListView)FindViewById(Resource.Id.itemListView);
            ItemListAdapter mAdapter = new ItemListAdapter(this, itemList);
            itemListView.Adapter = mAdapter;


            // Get our button from the layout resource,
            // and attach an event to it
            Button addItem = FindViewById<Button>(Resource.Id.addButton);

            EditText newItem = (EditText)FindViewById(Resource.Id.newItemEntry);

            addItem.Click += delegate 
            {
                if(newItem.Text != "")
                {
                    itemList.Add(newItem.Text + "");
                    newItem.Text = "";
                    mAdapter.NotifyDataSetChanged();
                }
                else
                {
                    Toast.MakeText(this, "You should add text!", ToastLength.Short).Show();
                }
            };

            
        }
    }
}

