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

namespace STMH
{
    [Activity(Label = "ItemListAdapter")]
    public class ItemListAdapter : BaseAdapter
    {
        Context context;
        protected List<string> itemList;
        LayoutInflater inflater;

        public ItemListAdapter(Context context, List<string> itemList)
        {
            this.itemList = itemList;
            this.context = context;
            this.inflater = (LayoutInflater)context.GetSystemService(Context.LayoutInflaterService);
        }

        public override int Count
        {
            get { return itemList.Count; }
        }

        public override Java.Lang.Object GetItem(int position)
        {
            return null;
        }

        public override long GetItemId(int position)
        {
            return position;
        }
        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            ViewHolder holder;
            if(convertView == null)
            {
                holder = new ViewHolder();
                convertView = this.inflater.Inflate(Resource.Layout.List_Item, parent, false);

                holder.text = (TextView)convertView.FindViewById(Resource.Id.itemText);

                //Set tag to easily find the button's container index later
                holder.text.Tag = position;

                convertView.Tag = holder;
            }
            else
            {
                holder = (ViewHolder)convertView.Tag;
            }

            //Get the current User Item
            string item = itemList[position];

            holder.text.Text = item;
            return convertView;
        }

        private class ViewHolder : Java.Lang.Object
        {
            public TextView text;
        }
    }

}