   M S B A M L   `   `   `  ����K  GWpfApp_Animation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:WpfApp_AnimationWpfApp_Animation  5   	   !    WpfApp_Animation.TestWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:WpfApp_Animation     5   	     � Title$  
TestWindow��5   	   $	��450��6   $	��800��6)    � 	Resources 5	         Loading g� Duration �� 
TargetName �� TargetProperty	 W� To W� From��%�   &	        �� 5   
   .��5      W� $ 0:0:0.5D�6   $	 btn��61   $ FontSize�6M   $ 30X�6r   W� 5       $ 0X�6   $	 150X�6'   $ 0:1:0D�60   $	 btn��6A   $ Width�6]   5!      5"       � Triggers 5#      :� 5$   
    :� RoutedEvent$ Loaded��6   .[�5%      �� #��[  6   5&      .��5(      � .+�5)   
   �� -   5        	 ��Name$		 btn��5)      $��我爱宝贝��6   $	��120��6-   $��60��69   
���  ��6E   �� 5+   
   
����  �$��50��6    $��50��6+   $��Right=�67   z�5,      �� 5-      -   5        rect��
 �� Angle$
 0Q�5-   0    �� CenterX$ 25Q�6:    �� CenterY$ 25Q�6G    5/      :� 50      $ Mouse.MouseMove��6   .[�51      �� .��52      �� .��53      W�  g� AutoReverse .  g� RepeatBehavior$ 9��6A   $ 0:0:2D�6T   $ 0X�6e   $	 360X�6n   $
 rect��6w   $ Angle�6�   54      55      56      58      59      5:      