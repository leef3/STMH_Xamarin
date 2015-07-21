package md527aff83b250a3754c6f8deb6275d93ee;


public class ItemListAdapter_ViewHolder
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer
{
	static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("STMH.ItemListAdapter/ViewHolder, STMH, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", ItemListAdapter_ViewHolder.class, __md_methods);
	}


	public ItemListAdapter_ViewHolder () throws java.lang.Throwable
	{
		super ();
		if (getClass () == ItemListAdapter_ViewHolder.class)
			mono.android.TypeManager.Activate ("STMH.ItemListAdapter/ViewHolder, STMH, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}

	java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}
