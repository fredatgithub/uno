#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Media.Devices.Core
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class FrameExposureCompensationControl 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  float? Value
		{
			get
			{
				throw new global::System.NotImplementedException("The member float? FrameExposureCompensationControl.Value is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=float%3F%20FrameExposureCompensationControl.Value");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Media.Devices.Core.FrameExposureCompensationControl", "float? FrameExposureCompensationControl.Value");
			}
		}
		#endif
		// Forced skipping of method Windows.Media.Devices.Core.FrameExposureCompensationControl.Value.get
		// Forced skipping of method Windows.Media.Devices.Core.FrameExposureCompensationControl.Value.set
	}
}
