   M S B A M L   `   `   `  ����J  FMyYouTubePlayer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:MyYouTubePlayerMyYouTubePlayer  5   	   V RCefSharp.Wpf, Version=79.1.360.0, Culture=neutral, PublicKeyToken=40c4b6fc221f4138A0clr-namespace:CefSharp.Wpf;assembly=CefSharp.WpfCefSharp.Wpf 5   	        MyYouTubePlayer.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:MyYouTubePlayer     5   	   @wpf0clr-namespace:CefSharp.Wpf;assembly=CefSharp.Wpf     5   	   h dMahApps.Metro.IconPacks.Zondicons, Version=3.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag cMahApps.Metro.IconPacks.Typicons, Version=3.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ak gMahApps.Metro.IconPacks.FeatherIcons, Version=3.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ae	 aMahApps.Metro.IconPacks.Modern, Version=3.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag
 cMahApps.Metro.IconPacks.Ionicons, Version=3.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ak gMahApps.Metro.IconPacks.WeatherIcons, Version=3.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137al hMahApps.Metro.IconPacks.MaterialLight, Version=3.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag cMahApps.Metro.IconPacks.Octicons, Version=3.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ae aMahApps.Metro.IconPacks.Entypo, Version=3.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137af bMahApps.Metro.IconPacks.Unicons, Version=3.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137af bMahApps.Metro.IconPacks.Microns, Version=3.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ac _MahApps.Metro.IconPacks.Core, Version=3.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag cMahApps.Metro.IconPacks.Material, Version=3.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137aj fMahApps.Metro.IconPacks.FontAwesome, Version=3.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137aj fMahApps.Metro.IconPacks.SimpleIcons, Version=3.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag cMahApps.Metro.IconPacks.BoxIcons, Version=3.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag cMahApps.Metro.IconPacks.EvaIcons, Version=3.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ai eMahApps.Metro.IconPacks.RPGAwesome, Version=3.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ai eMahApps.Metro.IconPacks.PicolIcons, Version=3.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137a^ ZMahApps.Metro.IconPacks, Version=3.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137am iMahApps.Metro.IconPacks.MaterialDesign, Version=3.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag cMahApps.Metro.IconPacks.JamIcons, Version=3.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag	iconPacks-http://metro.mahapps.com/winfx/xaml/iconpacks    	 
                  5	   	   -   5          � Title$  
MainWindow��5   	   $	��450��6   $	��906��6)    � WindowState$ 	Maximized=�6~   .��5      � -   5         �Name$ MainGrid��5      ��5   
   �� 5       �� EndPoint$ 0.5,1&�6"    �� 
StartPoint$ 0.5,0&�63   .��5      �  � Color$ 	#FFFFE286��6    � Offset$
 0.36Q�61   � 5      $ 	#FFEFC94C��6   $ 1Q�61   5      .+�5   
   � -   5        $ 
ScreenGrid��5      $��80,10q�6#   
������� J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5         ShadowDepth$ 20Q�6#   	   Opacity$		 0.6Q�64   
   	Direction$	
 -90Q�6B      RenderingBias$ Quality=�6R      
BlurRadius$ 15Q�6j   .+�5      %  CefSharp.Wpf.ChromiumWebBrowser  -   5          Name$ 
webBrowser��5   %      Address$1 +https://www.youtube.com/watch?v=taUG9-LA_QE��69   5      � 5    
   -   5        $ PlaylistGrid��5       ���	#FF434F5B$��50��6<   $��Right=�6G    5!        5"      $	
 180Q�6#   $		 0.5Q�63   $ 2Q�6A   $ Quality=�6Q   .+�5$      �� ���	#FF2E2E2E$��48��6)   $��2,0,0,0q�65   
���   �$	��Top=�6U    �� RadiusX$ 1��6m    �� RadiusY$ 1��6y   $��0��6�    � Cursor$
 Hand��6�   �� 5%      ���	#FF8AB839$��2,0,0,0q�6-   $
��Left=�6G   $��2��6b    5&        5'      $ 1Q�6'   $		 0.5Q�67   5)      �� 5*      $��Found 10 user playlists��6   $��35��66   $��49,6,0,0q�6B   $	��Top=�6T   $
��Bold"�6l   $��18(�6~   
�������$��10,5,5,5q�6�   �� 5+      $��7��6   $��2,45,0,0q�6#   $	��Top=�65    5,        5-      $ 1Q�6'   $		 0.5Q�67   5/      � 50      $	��130��6   $��
10,69,10,0q�6    $	��Top=�64   .+�51      �� ���	#FFC0E4FA$��0,33,0,0q�6-   $ 1��6?   $ 1��6K   
���   �$��0��6f    52        53      $
	 0.45Q�6+   $ 2Q�6:   55      �� 56      ���	#FF2E2E2E$��35��6-   $��0,0,0,-2q�69   
���   �$	��Top=�6Z   $ 1��6r   $ 1��6~   $��0��6�   $
 Hand��6�    57        58      $		 0.5Q�6+   $ 2Q�69   5:      .  (MahApps.Metro.IconPacks.PackIconMaterial  5;         Kind$  ArrowDownDropCircleOutline=�6-   $
��Left=�6O   $��16��6j   $��10,9,0,0q�6v   $	��Top=�6�   $��16��6�   ���	#FF8AB839$
 Hand��6�   �� 5<      $!��The Story of My Preferences��6   $��23��6?   $��32,6,0,0q�6K   $	��Top=�6]   $��14(�6u   $��Medium"�6�   
�������$��CharacterEllipsis=�6�   $
 Hand��6�   �� 5=      ���	#FF8AB839$��0,0,0,2q�61   $��2��6K   $��0,33,0,0q�6V   $	��Top=�6h   5>      A� 5?      $
��Left=�6   $��30��61   $��11,9,0,0q�6=   $	��Top=�6O   $��30��6g   ���	#FF2E2E2E$
 Hand��6�   
�������6�     5@      $
 Menu=�6)   $
��Left=�65   $��14��6P   $��	19,17,0,0q�6\    �� BitmapScalingMode$ HighQuality=�6o    �� EdgeMode$ Aliased=�6�   $	��Top=�6�   $��14��6�   
�������$
 Hand��6�   5A      � 5E   
   -   5        $ UserGrid��5E      $
��Left=�6!   $��50��6<   ���	#FF434F5B 5F        5G      $
 0Q�6#   $		 0.5Q�61   $ 2Q�6?   .+�5I      �� ���	#FF8AB839$��0,0,2,0q�6-   $��Right=�6G   $��2��6c     5J      $ AccountCircle=�6)   ���	#FFC0E4FA$
��Left=�6U   $��30��6p   $	��Top=�6|   $��30��6�   $��9,9,0,0q�6�   $
 Hand��6�    5K        5L      $ 1Q�6'   $		 0.5Q�67   5N      �� 5O      $��6��6   $��0,45,2,0q�6#   $	��Top=�65    5P        5Q      $ 1Q�6'   $		 0.5Q�67   5S      �� 5T      -   5         ��Name$ UsernameTextBlock��5T      $��PandrPi��63   $��24��6B   $��
44,13,31,0q�6N   $	��Top=�6b   $��14(�6z   $��Medium"�6�   
�������$��CharacterEllipsis=�6�   $
 Hand��6�    � ToolTip 5U      _� 5V      .��6   	User name5X      5Z        5[      -   5          Name$ UserLogButton��5[   )   $ Logout=�6@   ���	#FFC0E4FA$
��Left=�6e   $��16��6�   $	��Top=�6�   $��16��6�   $��
174,16,0,0q�6�   $
 Hand��6�    5\        5]      $ 1Q�6'   $		 0.5Q�67    5_      _� 5`      .��6   Click to Log out5b      5d          MyYouTubePlayer.MenuButton  5e      $
��Left=�6   $��36��6:   $��0,64,0,0q�6F   $	��Top=�6X   $	��198��6p      
HoverColor$ 	#FFFF0707��6|   ���	#FF8CB24A���	#FF00FF74$��3,0,0,0q�6�     5f      $
��Left=�6   $��36��6:   $��	0,114,0,0q�6F   $	��Top=�6Y   $	��198��6q   $ 	#FFFF0707��6}   ���	#FF8CB24A���	#FF00FF74$��3,0,0,0q�6�   5g      5i      5j      