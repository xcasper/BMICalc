package md5c79b9c61dc060ab5e6a85c6f89bc8bf3;


public class BMIDetailsActivity
	extends android.app.Activity
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onCreate:(Landroid/os/Bundle;)V:GetOnCreate_Landroid_os_Bundle_Handler\n" +
			"";
		mono.android.Runtime.register ("BMICalc_Android.BMIDetailsActivity, BMICalc_Android, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", BMIDetailsActivity.class, __md_methods);
	}


	public BMIDetailsActivity () throws java.lang.Throwable
	{
		super ();
		if (getClass () == BMIDetailsActivity.class)
			mono.android.TypeManager.Activate ("BMICalc_Android.BMIDetailsActivity, BMICalc_Android, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onCreate (android.os.Bundle p0)
	{
		n_onCreate (p0);
	}

	private native void n_onCreate (android.os.Bundle p0);

	private java.util.ArrayList refList;
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
