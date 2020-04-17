using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MyYouTubePlayer
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		private YouTubeServiceManager serviceManager;
		private VideoPlayer videoPlayer;

		public MainWindow()
		{
			VideoPlayer.InitSettings();

			InitializeComponent();
		}

		private void Window_Loaded(object sender, RoutedEventArgs e)
		{
			AnimationManager.SetFrameworkElement(this);
			videoPlayer = new VideoPlayer(webBrowser);
		}

		private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
		{
			videoPlayer.Dispose();
		}

		private void Window_KeyDown(object sender, KeyEventArgs e)
		{
			videoPlayer.KeyDownEventHandler(e);
		}
	}
}
