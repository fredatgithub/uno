#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Xaml.Controls
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class CandidateWindowBoundsChangedEventArgs 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Foundation.Rect Bounds
		{
			get
			{
				throw new global::System.NotImplementedException("The member Rect CandidateWindowBoundsChangedEventArgs.Bounds is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=Rect%20CandidateWindowBoundsChangedEventArgs.Bounds");
			}
		}
		#endif
		// Forced skipping of method Microsoft.UI.Xaml.Controls.CandidateWindowBoundsChangedEventArgs.Bounds.get
	}
}
