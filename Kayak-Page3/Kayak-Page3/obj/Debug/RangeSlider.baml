   M S B A M L   `   `   `  ����F  BKayak-Page3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:DesignInControlDesignInControl  5      !    DesignInControl.RangeSlider   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      Dec5http://schemas.microsoft.com/expression/2010/controls     5      /localclr-namespace:DesignInControl     5      -   5          >�Name$
  root��5
       � UseLayoutRounding .  � 	Resources 5         RepeatButtonControlTemplate �� 
TargetType  
ThumbStyle �� 
TargetType �� Property �� Value'  !System.Windows.VisualStateManager   VisualStateGroups%  System.Windows.VisualStateGroup   States   System.Windows.VisualState	   
Storyboard
 g� Duration	 W� To �� TargetProperty �� 
TargetName ��Name J� Opacity  SliderStyle �Name ]�Name ]� IncreaseRepeatButton ��Name ]� DecreaseRepeatButton ]� Thumb n�Name��%�  &	        &	 2     &	     7   7   7  �� 5   
   " ��6>   .R�5      � 5      �� 5   
   " n�6#   .�5      ��  � �� 5      �� 5      " n�6&   .R�5      �  5        5   "   CommonStates��. 5   &     
Normal��62     5   &   	MouseOver��.	 5   *   �� .��5   .   W� $
 0D�6>   $ 1X�6K   $ (UIElement.Opacity)�6R   $ BackgroundOver��6�   5   +   5   '     5   &   Pressed��.	 5   *   �� .��5   .   W� $
 0D�6>   $ 1X�6K   $ (UIElement.Opacity)�6R   $ BackgroundOver��6�   5    +   5!   '     5"   &   Disabled��62   5#   #   .+�5%      �� $ 
Background��6%   #��z��69   #��z��6c   #��z��6�   �� 5&      $ BackgroundOver��6%   #��z��6=   #��z��6g   #��z��6�   $ 0Q�6�   5'      5(      5*      5+      �� 5,   
   " ��6$   .�5-      ��  � �� 5.      �� 5/      " ��6&   .R�50      � $
 Root��6   .+�51      � $ HorizontalTemplate��6#   .+�52   "   ]� $ 
PART_Track��6(    53   &   �� 54   *   $4 .HorizontalTrackLargeChangeIncreaseRepeatButton��67   8��  6o    56   &   �� 57   *   $4 .HorizontalTrackLargeChangeDecreaseRepeatButton��67   8�� 6o    59   &   n� 5:   *   $ HorizontalThumb��60   $��18��6I   ��. $��10��6f   8�� 
���   �
���   �$��1q�6�   5<   #   5=      5>      5?      5A      5B      5C      .��5E      � -   5        $ 
LayoutRoot��5E      
�������.+�5F   
   �� -   5        $ progressBorder��5F      
��� ���$��1q�6=   �� 5G   
   -   5         ��Name$ LowerSlider��5G      #��[ 5K       � Minimum 5H      ��  �� RelativeSource ��  �� AncestorType$ local:RangeSliderL� �� Path$ Minimum� �� Mode$ TwoWay=� � Maximum 5I      ��  �� $ local:RangeSliderL�$ Maximum�$ TwoWay=� � Value 5J      ��  �� $ local:RangeSliderL�$ 
LowerValue�$ TwoWay=�5K      �� 5L   
   -   5        $ UpperSlider��5L      #��[ 5P       5M      ��  �� $ local:RangeSliderL�$ Minimum�$ TwoWay=� 5N      ��  �� $ local:RangeSliderL�$ Maximum�$ TwoWay=� 5O      ��  �� $ local:RangeSliderL�$ 
UpperValue�$ TwoWay=�5P      5Q      5R      