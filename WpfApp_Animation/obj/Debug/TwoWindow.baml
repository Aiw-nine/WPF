   M S B A M L   `   `   `  ����K  GWpfApp_Animation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:WpfApp_AnimationWpfApp_Animation  5   	        WpfApp_Animation.TwoWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:WpfApp_Animation     5   	     � Title$  	TwoWindow��5   	   $	��450��6   $
��1000��6(   .��5	      A�  A� Rows$ 3��6    A� Columns$ 2��6   .+�5
   
   �� 
����  �$��50��6    $��50��6+   $
��Left=�67   z�5      T� 5      -   5        	myAnimate�� T� X$ 0Q�5   8    T� Y$ 0Q�6>    � Triggers 5      :� 5       :� RoutedEvent$# Rectangle.MouseLeftButtonDown��6   .[�5      �� .��5      �� .��5      W�  W� From$ 0X�6.   	 W� To$	 350X�67   	 g� Duration$	 0:0:2D�6@   
 �� 
TargetName$
 	myAnimate��6Q    �� TargetProperty$ X�6s   W� 5      $	 350X�6.   $ 50X�69   $	 0:0:5D�6A    g� 	BeginTime$ 0:0:2X�6R   $
 	myAnimate��6d   $ X�6�   W� 5      $ 50X�6.   $	 200X�68   $	 0:0:1D�6A   $ 0:0:7X�6R   $
 	myAnimate��6d   $ X�6�   5      5      5      5      �� 5   
   
����  �$��50��6    $��50��6+   $
��Left=�67   z�5      T� 5      -   5        
myAnimate2��$ 0Q�5   9   $ 0Q�6?    5      :� 5       $# Rectangle.MouseLeftButtonDown��6   .[�5!      �� .��5"      �� .��5$      U� $
 
myAnimate2��6<   $ X�6_   $	 0:0:10D�6}    g� RepeatBehavior$ Forever��6�   .\�5&   "   ��  O� Value$ 0Q�67    O� KeyTime$ 0:0:0��6A   �� 5'   "   $	 350Q�67   $ 0:0:2��6C   �� 5(   "   $ 50Q�67   $ 0:0:7��6B   �� 5)   "   $	 200Q�67   $ 0:0:8��6C   5*      5+      5,      5-      5/      �� 50   
   
����  �$��50��6    $��50��6+   $
��Left=�67   z�51      T� 52      -   5        
myAnimate3��$ 0Q�52   9   $ 0Q�6?    54      :� 55      $# Rectangle.MouseLeftButtonDown��6   .[�56      �� .��57      �� .��59      U� $
 
myAnimate3��6<   $ X�6_   $	 0:0:10D�6}   $ Forever��6�   .\�5;   "   n� $ 0Q�69   $ 0:0:0��6C   n� 5<   "   $	 350Q�69   $ 0:0:2��6E   n� 5=   "   $ 50Q�69   $ 0:0:7��6D   n� 5>   "   $	 200Q�69   $ 0:0:8��6E   5?      5@      5A      5B      5D      �� 5E   
   
����  �$��50��6    $��50��6+   $
��Left=�67   z�5F      T� 5G      -   5        
myAnimate4��$ 0Q�5G   9   $ 0Q�6?    5I      :� 5J      $ Rectangle.Loaded��6   .[�5K      �� .��5L      �� .��5N      U� $
 
myAnimate4��6<   $ X�6_   $	 0:0:15D�6}   $ Forever��6�   .\�5P   "   �� $	 500Q�67   $ 0:0:7��6C    �� 	KeySpline$ 0.0,1.0 1.0,0.0��6S   �� 5Q   "   $	 200Q�67   $ 0:0:10��6C   $ 0.0,0.0 1.0,0.0��6T   �� 5R   "   $	 350Q�67   $ 0:0:15��6C   $ 0.25,0.5 0.75,1��6T   5S      5T      5U      5V      5X      �� 5Y   
   
����  �$��50��6    $��50��6+   $
��Left=�67   z�5Z      T� 5[      -   5        
myAnimate5��$ 0Q�5[   9   $ 0Q�6?    5]      :� 5^      $ Rectangle.Loaded��6   .[�5_      �� .��5`      �� .��5b      U� $
 
myAnimate5��6<   $ X�6_   $	 0:0:15D�6}   $ Forever��6�   .\�5d   "   n� $	 500Q�69   $ 0:0:7��6E   �� 5e   "   $	 200Q�67   $ 0:0:10��6C   �� 5f   "   $	 350Q�67   $ 0:0:15��6C   $ 0.25,0.5 0.75,1��6T   5g      5h      5i      5j      5l      5m      5n      