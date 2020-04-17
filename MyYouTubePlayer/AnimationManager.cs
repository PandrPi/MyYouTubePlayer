using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Animation;

namespace MyYouTubePlayer
{
	public class AnimationManager
	{
		private static FrameworkElement frameworkElement;


		public static readonly Color Transparent = Color.FromArgb(255, 0, 0, 0);


		public static void SetFrameworkElement(FrameworkElement frameworkElement)
		{
			AnimationManager.frameworkElement = frameworkElement;
		}

		public void Initiallize()
		{
			ExponentialEase exponentialEase = new ExponentialEase();
			exponentialEase.EasingMode = EasingMode.EaseIn;
		}

		public static DoubleAnimation GetDoubleAnimation(double from, double to, TimeSpan duration,
			string targetProperty, string propertyPath, IEasingFunction easingFunction)
		{
			DoubleAnimation da = new DoubleAnimation(from, to, duration);
			da.SetValue(Storyboard.TargetNameProperty, targetProperty);
			Storyboard.SetTargetProperty(da, new PropertyPath(propertyPath));
			da.EasingFunction = easingFunction;

			return da;
		}

		public static ColorAnimation GetColorAnimation(Color to, TimeSpan duration,
			string targetProperty, string propertyPath, IEasingFunction easingFunction, Color? from = null)
		{
			ColorAnimation ca = new ColorAnimation(from ?? Transparent, to, duration);
			ca.SetValue(Storyboard.TargetNameProperty, targetProperty);
			Storyboard.SetTargetProperty(ca, new PropertyPath(propertyPath));
			ca.EasingFunction = easingFunction;

			return ca;
		}

		public static void BeginAnimation(Storyboard st)
		{
			st.Begin(frameworkElement);
		}

		public static void BeginAnimation(FrameworkElement element, Storyboard st)
		{
			st.Begin(element);
		}

		public static void SetAnimationCompleteCallback(Storyboard st, Action callback)
		{
			st.Completed += (sender, e) => callback();
		}
	}
}
