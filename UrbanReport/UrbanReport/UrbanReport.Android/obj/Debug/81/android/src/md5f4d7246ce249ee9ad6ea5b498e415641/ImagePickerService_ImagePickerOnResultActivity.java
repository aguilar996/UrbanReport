package md5f4d7246ce249ee9ad6ea5b498e415641;


public class ImagePickerService_ImagePickerOnResultActivity
	extends com.theartofdev.edmodo.cropper.CropImageActivity
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onCropImageComplete:(Lcom/theartofdev/edmodo/cropper/CropImageView;Lcom/theartofdev/edmodo/cropper/CropImageView$CropResult;)V:GetOnCropImageComplete_Lcom_theartofdev_edmodo_cropper_CropImageView_Lcom_theartofdev_edmodo_cropper_CropImageView_CropResult_Handler\n" +
			"";
		mono.android.Runtime.register ("Xamarin.Forms.ImagePicker.Android.ImagePickerService+ImagePickerOnResultActivity, Xamarin.Forms.ImagePicker.Android", ImagePickerService_ImagePickerOnResultActivity.class, __md_methods);
	}


	public ImagePickerService_ImagePickerOnResultActivity ()
	{
		super ();
		if (getClass () == ImagePickerService_ImagePickerOnResultActivity.class)
			mono.android.TypeManager.Activate ("Xamarin.Forms.ImagePicker.Android.ImagePickerService+ImagePickerOnResultActivity, Xamarin.Forms.ImagePicker.Android", "", this, new java.lang.Object[] {  });
	}


	public void onCropImageComplete (com.theartofdev.edmodo.cropper.CropImageView p0, com.theartofdev.edmodo.cropper.CropImageView.CropResult p1)
	{
		n_onCropImageComplete (p0, p1);
	}

	private native void n_onCropImageComplete (com.theartofdev.edmodo.cropper.CropImageView p0, com.theartofdev.edmodo.cropper.CropImageView.CropResult p1);

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
