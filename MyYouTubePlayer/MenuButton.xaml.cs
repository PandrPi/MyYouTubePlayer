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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MyYouTubePlayer
{
	/// <summary>
	/// Interaction logic for MenuButton.xaml
	/// </summary>
	public partial class MenuButton : UserControl
	{
		public static readonly DependencyProperty HoverColorProperty = DependencyProperty.Register("HoverColor", typeof(Color), typeof(MenuButton), new UIPropertyMetadata(default(Color)));


		public Color HoverColor { get { return (Color)GetValue(HoverColorProperty); } set { SetValue(HoverColorProperty, value); } }


		private Storyboard MouseEnterSB = new Storyboard();
		private Storyboard MouseLeaveSB = new Storyboard();
		private TimeSpan HoverDuration = TimeSpan.FromSeconds(0.1);

		private ExponentialEase expEaseIn = new ExponentialEase() { EasingMode = EasingMode.EaseIn };
		private ExponentialEase expEaseOut = new ExponentialEase() { EasingMode = EasingMode.EaseOut };

		public MenuButton()
		{
			InitializeComponent();

			//MouseEnterSB.Children.Add(AnimationManager.GetColorAnimation(HoverColor, HoverDuration, "btnGrid", "(Grid.Background).Brush", expEaseIn));
			MouseEnterSB.Children.Add(AnimationManager.GetDoubleAnimation(0, 1, HoverDuration, "btnBorder", "Opacity", expEaseIn));
			//MouseLeaveSB.Children.Add(AnimationManager.GetColorAnimation(AnimationManager.Transparent, HoverDuration, "btnGrid", "(Grid.Background).Brush", expEaseOut));
			MouseLeaveSB.Children.Add(AnimationManager.GetDoubleAnimation(0, 1, HoverDuration, "btnBorder", "Opacity", expEaseOut));
		}

		private void UserControl_MouseEnter(object sender, MouseEventArgs e)
		{
			AnimationManager.BeginAnimation(this, MouseEnterSB);
		}

		private void UserControl_MouseLeave(object sender, MouseEventArgs e)
		{
			AnimationManager.BeginAnimation(this, MouseLeaveSB);
		}
	}
}
