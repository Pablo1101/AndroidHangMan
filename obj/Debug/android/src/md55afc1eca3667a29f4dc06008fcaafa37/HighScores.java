package md55afc1eca3667a29f4dc06008fcaafa37;


public class HighScores
	extends android.app.Activity
	implements
		mono.android.IGCUserPeer
{
	static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("XHangman1.HighScores, XHangman1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", HighScores.class, __md_methods);
	}


	public HighScores () throws java.lang.Throwable
	{
		super ();
		if (getClass () == HighScores.class)
			mono.android.TypeManager.Activate ("XHangman1.HighScores, XHangman1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
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
