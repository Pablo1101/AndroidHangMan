package md55afc1eca3667a29f4dc06008fcaafa37;


public class Start
	extends android.app.Activity
	implements
		mono.android.IGCUserPeer
{
	static final String __md_methods;
	static {
		__md_methods = 
			"n_onCreate:(Landroid/os/Bundle;)V:GetOnCreate_Landroid_os_Bundle_Handler\n" +
			"";
		mono.android.Runtime.register ("XHangman1.Start, XHangman1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", Start.class, __md_methods);
	}


	public Start () throws java.lang.Throwable
	{
		super ();
		if (getClass () == Start.class)
			mono.android.TypeManager.Activate ("XHangman1.Start, XHangman1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onCreate (android.os.Bundle p0)
	{
		n_onCreate (p0);
	}

	private native void n_onCreate (android.os.Bundle p0);

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
