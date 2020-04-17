using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using CefSharp;
using CefSharp.Wpf;

namespace MyYouTubePlayer
{
	public sealed class VideoPlayer
	{
		private ChromiumWebBrowser browser;

		public VideoPlayer(ChromiumWebBrowser browser)
		{
			this.browser = browser;

			this.browser.FrameLoadEnd += ChromiumWebBrowser_FrameLoadEnd;
			MyLifespanHandler lifeSpan = new MyLifespanHandler();
			this.browser.LifeSpanHandler = lifeSpan;
		}

		public static void InitSettings()
		{
			CefSettings settings = new CefSettings();
			settings.CefCommandLineArgs["autoplay-policy"] = "no-user-gesture-required";
			Cef.Initialize(settings);
		}

		public void KeyDownEventHandler(KeyEventArgs e)
		{

		}

		public void Dispose()
		{
			browser.Stop();
			browser.Dispose();
		}

		private void ChromiumWebBrowser_FrameLoadEnd(object sender, FrameLoadEndEventArgs e)
		{
			if (e.Frame.IsMain)
			{
				e.Frame.ExecuteJavaScriptAsync(@"
					if ('mediaSession' in navigator) {
						navigator.mediaSession.setActionHandler('play', function() {});
						navigator.mediaSession.setActionHandler('pause', function() {});
						navigator.mediaSession.setActionHandler('seekbackward', function() {});
						navigator.mediaSession.setActionHandler('seekforward', function() {});
						navigator.mediaSession.setActionHandler('previoustrack', function() {});
						navigator.mediaSession.setActionHandler('nexttrack', function() {});
					}
				");
			}
		}
	}

	public class MyLifespanHandler : ILifeSpanHandler
	{
		//event that receive url popup
		public event Action<string> PopupRequest;

		bool ILifeSpanHandler.OnBeforePopup(IWebBrowser browserControl, IBrowser browser, IFrame frame, string targetUrl, string targetFrameName, WindowOpenDisposition targetDisposition, bool userGesture, IPopupFeatures popupFeatures, IWindowInfo windowInfo, IBrowserSettings browserSettings, ref bool noJavascriptAccess, out IWebBrowser newBrowser)
		{
			//get url popup
			if (this.PopupRequest != null)
				this.PopupRequest(targetUrl);

			//stop open popup
			newBrowser = null;
			return true;
		}


		bool ILifeSpanHandler.DoClose(IWebBrowser browserControl, IBrowser browser)
		{ return false; }


		void ILifeSpanHandler.OnBeforeClose(IWebBrowser browserControl, IBrowser browser) { }


		void ILifeSpanHandler.OnAfterCreated(IWebBrowser browserControl, IBrowser browser) { }
	}
}
