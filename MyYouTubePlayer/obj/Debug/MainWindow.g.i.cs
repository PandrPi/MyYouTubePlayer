#pragma checksum "..\..\MainWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "CE224DD1E6F2710F5C801387EB3F54F2B3660D90AA4FC7FEC0390DD767D6C49F"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using MahApps.Metro.IconPacks;
using MahApps.Metro.IconPacks.Converter;
using MyYouTubePlayer;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;
using WPF.ImageEffects;


namespace MyYouTubePlayer
{


	/// <summary>
	/// MainWindow
	/// </summary>
	public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector
	{


#line 11 "..\..\MainWindow.xaml"
		[System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
		internal System.Windows.Controls.Grid MainGrid;

#line default
#line hidden


#line 21 "..\..\MainWindow.xaml"
		[System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
		internal System.Windows.Controls.Grid ScreenGrid;

#line default
#line hidden


#line 30 "..\..\MainWindow.xaml"
		[System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
		internal System.Windows.Controls.Grid PlaylistGrid;

#line default
#line hidden


#line 67 "..\..\MainWindow.xaml"
		[System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
		internal System.Windows.Controls.Grid UserGrid;

#line default
#line hidden


#line 82 "..\..\MainWindow.xaml"
		[System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
		internal System.Windows.Controls.TextBlock UsernameTextBlock;

#line default
#line hidden


#line 89 "..\..\MainWindow.xaml"
		[System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
		internal MahApps.Metro.IconPacks.PackIconMaterial UserLogButton;

#line default
#line hidden

		private bool _contentLoaded;

		/// <summary>
		/// InitializeComponent
		/// </summary>
		[System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			if (_contentLoaded)
			{
				return;
			}
			_contentLoaded = true;
			System.Uri resourceLocater = new System.Uri("/MyYouTubePlayer;component/mainwindow.xaml", System.UriKind.Relative);

#line 1 "..\..\MainWindow.xaml"
			System.Windows.Application.LoadComponent(this, resourceLocater);

#line default
#line hidden
		}

		[System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
		[System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
		internal System.Delegate _CreateDelegate(System.Type delegateType, string handler)
		{
			return System.Delegate.CreateDelegate(delegateType, this, handler);
		}

		[System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
		[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
		[System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
		[System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
		[System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
		void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
		{
			switch (connectionId)
			{
				case 1:

#line 10 "..\..\MainWindow.xaml"
					((MyYouTubePlayer.MainWindow)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);

#line default
#line hidden

#line 10 "..\..\MainWindow.xaml"
					((MyYouTubePlayer.MainWindow)(target)).SizeChanged += new System.Windows.SizeChangedEventHandler(this.Window_SizeChanged);

#line default
#line hidden

#line 10 "..\..\MainWindow.xaml"
					((MyYouTubePlayer.MainWindow)(target)).Closing += new System.ComponentModel.CancelEventHandler(this.Window_Closing);

#line default
#line hidden
					return;
				case 2:
					this.MainGrid = ((System.Windows.Controls.Grid)(target));
					return;
				case 3:
					this.ScreenGrid = ((System.Windows.Controls.Grid)(target));
					return;
				case 4:
					this.webBrowser = ((System.Windows.Controls.WebBrowser)(target));
					return;
				case 5:
					this.PlaylistGrid = ((System.Windows.Controls.Grid)(target));
					return;
				case 6:
					this.UserGrid = ((System.Windows.Controls.Grid)(target));
					return;
				case 7:
					this.UsernameTextBlock = ((System.Windows.Controls.TextBlock)(target));
					return;
				case 8:
					this.UserLogButton = ((MahApps.Metro.IconPacks.PackIconMaterial)(target));
					return;
			}
			this._contentLoaded = true;
		}
	}
}

