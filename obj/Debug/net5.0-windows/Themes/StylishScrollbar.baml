   M S B A M L   `   `   `  ����W  SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089   ScrollThumbs  �� 
TargetType �� Property �� Value �� 
TargetType �Name ��Name �� CornerRadius �� Triggers P� Property	 P� Value
 �� 
TargetName � RowDefinitions ]�Name ]� Thumb n�Name ]� IncreaseRepeatButton ��Name J� Opacity ]� DecreaseRepeatButton P� 
SourceName  ButtonSelectBrush  	DarkBrush �� Angle�� 5      H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation       :x,http://schemas.microsoft.com/winfx/2006/xaml      5      %:	  &	        '�� C    �� 5      "  n�6!   .�5   
   ��  � �� 5      �� 5      " n�6"   .R�5      � $
 Grid��6   .+�5      �� $��Stretch=�6$   $��Stretch=�6B   $
��Auto��6^   $
��Auto��6k   
������ 6y   �� 5	      $ 
Rectangle1��6!   $ 5��65   $��Stretch=�6F   $��Stretch=�6d   $
��Auto��6�   $
��Auto��6�   #��z��6�   5
       5      P� 5       �@�Tag$	 
Horizontal��61   . �5      �� $
 
Rectangle1��6%    � ��$
 Auto��6N   �� 5      $
 
Rectangle1��6%    � ��$ 7��6O   5      5      5      5      �� 5      "  ��6'   .�5   
   ��  �@��IsFlicksEnabled$ false��63   �� 5   
    � �� �#8C8C8C6'   �� 5   
    � ��
 ���� 6'   �� 5   
    � ��$ 8��6"   �� 5   
    � �� 5      �� 5      " ��6"   .R�5      � $ GridRoot��6   $��8��6-   #��z��67    5      �� 5      $��0.00001* �6,   .+�5!      ]� $ 
PART_Track��6    $��0��64   $
��true��6A   $|�false��6\    5"      n� 5#   "   $ Thumb��6(   #��z��67   #���   6a    5%      �� 5&   "   $ PageUp��6/   $��ScrollBar.PageDownCommand��6?   $ 0Q�6c   $|�false��6o    5(      �� 5)   "   $ PageDown��6/   $��ScrollBar.PageUpCommand��6A   $ 0Q�6c   $|�false��6o   5+      5,       5-      P� 5.      $ Thumb��6"    �@J�IsMouseOver$
	 true��6L   . �5/      �� # �  6%   $
 Thumb��6Q    � ��6d   50      P� 51      $ Thumb��6"    �@n�
IsDragging$
	 true��6K   . �52      �� # �  6%   $
 Thumb��6I    � ��6\   53      P� 54       � {�$	 false��67   . �55      �� $
 Thumb��6%    � y�$ 	Collapsed=�6N   56      P� 57       �@��Orientation$	 
Horizontal=�69   . �58      �� $
 GridRoot��6%    �@�LayoutTransform 59   "   �� 5:   &   $	 -90Q�66   5<      �� 5=      $
 
PART_Track��6%    �@�LayoutTransform 5>   "   �� 5?   &   $	 -90Q�66   5A      �� 5B       � ��$
 Auto��66   �� 5C       � ��$ 8��67   �� 5D      $
 Thumb��6%    �@�Tag$ 
Horizontal��6G   �� 5E      $
 PageDown��6%    � ��$ ScrollBar.PageLeftCommand��6N   �� 5F      $
 PageUp��6%    � ��$  ScrollBar.PageRightCommand��6L   5G      5I      5K      5L      5M      