#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Web.Http.Headers
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class HttpDateOrDeltaHeaderValue : global::Windows.Foundation.IStringable
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::System.DateTimeOffset? Date
		{
			get
			{
				throw new global::System.NotImplementedException("The member DateTimeOffset? HttpDateOrDeltaHeaderValue.Date is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=DateTimeOffset%3F%20HttpDateOrDeltaHeaderValue.Date");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::System.TimeSpan? Delta
		{
			get
			{
				throw new global::System.NotImplementedException("The member TimeSpan? HttpDateOrDeltaHeaderValue.Delta is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=TimeSpan%3F%20HttpDateOrDeltaHeaderValue.Delta");
			}
		}
		#endif
		// Forced skipping of method Windows.Web.Http.Headers.HttpDateOrDeltaHeaderValue.Date.get
		// Forced skipping of method Windows.Web.Http.Headers.HttpDateOrDeltaHeaderValue.Delta.get
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public override string ToString()
		{
			throw new global::System.NotImplementedException("The member string HttpDateOrDeltaHeaderValue.ToString() is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=string%20HttpDateOrDeltaHeaderValue.ToString%28%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.Web.Http.Headers.HttpDateOrDeltaHeaderValue Parse( string input)
		{
			throw new global::System.NotImplementedException("The member HttpDateOrDeltaHeaderValue HttpDateOrDeltaHeaderValue.Parse(string input) is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=HttpDateOrDeltaHeaderValue%20HttpDateOrDeltaHeaderValue.Parse%28string%20input%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static bool TryParse( string input, out global::Windows.Web.Http.Headers.HttpDateOrDeltaHeaderValue dateOrDeltaHeaderValue)
		{
			throw new global::System.NotImplementedException("The member bool HttpDateOrDeltaHeaderValue.TryParse(string input, out HttpDateOrDeltaHeaderValue dateOrDeltaHeaderValue) is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=bool%20HttpDateOrDeltaHeaderValue.TryParse%28string%20input%2C%20out%20HttpDateOrDeltaHeaderValue%20dateOrDeltaHeaderValue%29");
		}
		#endif
	}
}
