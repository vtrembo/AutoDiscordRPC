   M S B A M L   `   `   `  ����I  EAutoDiscordRPC, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:AutoDiscordRPC.MVVM.ViewAutoDiscordRPC.MVVM.View  5      )    #AutoDiscordRPC.MVVM.View.CreateView   5      \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5      R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      8local&clr-namespace:AutoDiscordRPC.MVVM.View     5      .��5      �   � ColumnDefinitions  5   
   �� 5      $
��240* �6   �� 5      $
��240* �6   �� 5      $
��240* �6    � RowDefinitions 5   
   �� 5      $	��70* �6   �� 5      $	��50* �6   �� 5      $	��50* �6   �� 5      $	��50* �6   �� 5      $	��50* �6   �� 5      $	��50* �6   �� 5      $	��50* �6   �� 5      $	��50* �6   .+�5   
   � $��0��6   $��3��6     5      �� 5      �� 5      .+�5!      �� -   5        $��0��5!      $��Developer Portal��5"      $��18(�5#      $��SemiBold"�6#   $��20q�5$      $��0q�6!    � 	Resources 5'       �� 
TargetType �� Property �� Value��%_   '��       �� 5(      " ��6   .�5)      ��  �@��CornerRadius$ 10��69   5*      5+      ��5,      �� 5-      " ��6   .�5.      ��  � ��
 �����67   �� 5/       � �� 50      �� 51   "    �� 
TargetType" ��62   .R�52   &   ��  ��Name$ Border��6-   ���#5865F2._�53   *   �� $��Center=�6;   $��Center=�6X   54   '    �� Triggers 55   &   P� 56   *   	 P� Property	 �@J�IsMouseOver
 P� Value$

 True��6I   . �57   .   ��  �� 
TargetName$ Border��6[    � �� �#4752C4�� 58   .    � �� �#CFCFCF6K   59   +   5;   #   5=      5>      5@      �� 5B      $��1��6   $��Create Presence��5C      $��20q�5D      $��0q�6!   $��18(�5E      $��SemiBold"�6#    5G      ��%_   '��       �� 5H      " ��6   .�5I      ��  �@��CornerRadius$ 10��69   5J      5K      ��5L      �� 5M      " ��6   .�5N      ��  � ��
 �����67   �� 5O       � �� 5P      �� 5Q   "   " ��62   .R�5R   &   �� $ Border��6-   ���#3BA55D._�5S   *   �� $��Center=�6;   $��Center=�6X   5T   '    5U   &   P� 5V   *   	 �@J�IsMouseOver$

 True��6I   . �5W   .   �� $ Border��6[    � �� �#2D7D46�� 5X   .    � �� �#CFCFCF6K   5Y   +   5[   #   5]      5^      5`      5a      �� 5f   
   $��1��6   $��0��6   $��8q�6/   $��Presence Name��5g         ModernTextbox#��[  5h      �� 5i   
   $��1��6   $��1��6   $��8q�6/   $��Application ID��5j      #��[  5k      �� 5l   
   $��2��6   $��0��6   $��8q�6/   $��Description 1 (optional)��5m      #��[  5n      �� 5o   
   $��2��6   $��1��6   $��8q�6/   $��Description 2 (optional)��5p      #��[  5q      �� 5r   
   $��3��6   $��0��6   $��8q�6/   $!��Large Image Name (optional)��5s      #��[  5t      �� 5u   
   $��3��6   $��1��6   $��8q�6/   $!��Large Image Text (optional)��5v      #��[  5w      �� 5x   
   $��4��6   $��0��6   $��8q�6/   $!��Small Image Name (optional)��5y      #��[  5z      �� 5{   
   $��4��6   $��1��6   $��8q�6/   $!��Small Image Text (optional)��5|      #��[  5}      � 5~   
   $��5��6     5      �� 5�      $��65 �6#   �� 5�      $��* �6#   .+�5�      d� -   5         d�Name$ ToggleButton1��5�        ModernToggleButton#��[ 5�      $��5,0,-5,0q�5�   -   �� 5�      -   5         ��Name$ 
Button1URL��5�      $��1��5�      $��8q�6&   $��Button 1 URL��5�      ${�false��5�      #��[  5�      5�      �� 5�   
   -   5        $ Button1Text��5�      $��5��5�      $��1��6   $��8q�6/   $��Button 1 Text��5�      ${�false��5�      #��[  5�      � 5�   
   $��6��6     5�      �� 5�      $��65 �6#   �� 5�      $��* �6#   .+�5�      d� -   5        $ ToggleButton2��5�      #��[ 5�      $��5,0,-5,0q�5�   -   �� 5�      -   5        $ 
Button2URL��5�      $��1��5�      $��8q�6&   $��Button 2 URL��5�      ${�false��5�      #��[  5�      5�      �� 5�   
   -   5        $ Button2Text��5�      $��6��5�      $��1��6   $��8q�6/   ${�false��5�      $��Button 2 Text��5�      #��[  5�      �� 5�   
   $��7��6   $��2��5�       �� CornerRadius$ 10��5�      $��5q�5�      $��4q�5�      ���	#4C949494 J� Effect 5�      3  -System.Windows.Media.Effects.DropShadowEffect  5�         
BlurRadius$ 10Q�6#      Opacity$ 1Q�5�   #      ShadowDepth$ 1Q�5�   #      Color$ #292b2f��5�   #   ��5�      
� 5�       
� GradientOrigin$ 0.5,0.5&�5�       
� Center$ 0.5,0.5&�5�       
� RadiusX$ 1Q�5�       
� RadiusY$ 1Q�6!   ��5�      �  � Color$ #36393F��6'    � Offset$ 0Q�67   � 5�      $ #292b2f��6'   $ 1Q�67   5�      5�      � 5�   
   $��7��6     5�      �� 5�      $	��40* �6#   �� 5�      $
��120* �6#   �� 5�      $	��80* �6#   .+�5�      ��  5�       �� Triggers��%�  '��       �� 5�      " ��6   .�5�      ��  � ��$ 15,2,2,2q�63   �� 5�       � ��$ /Assets/infobox.png��63    5�      P� 5�      	 �@J�IsMouseOver$

 True��6=   . �5�   "   ��  � ��$ 13,0,0,0q�6;   �� 5�   "    � ��$ /Assets/infobox.png��6;   �� 5�   "    �@�ToolTip$; 5Presence will start automaticly with browsed exe file��6<   5�      5�      5�      5�      (� 5�      $��1��6   .��5�      �� $��Auto Feature��6   $��15(�5�      $��SemiBold"�5�      ���#CFCFCF5�      5�      d� 5�      -   5        $ ToggleButtonAuto��5�      $��2��5�      #��[ 5�      $��5,0,-5,0q�5�   0   5�      � 5�   
   $��7��6   $��1��6     5�      �� 5�      $	��100 �6#   �� 5�      $��* �6#   .+�5�      �� -	   5         ��Name$ BrowseButton��5�      $��0��5�      $��10,17q�5�        ModernButton#��[ 5�      �� 5�      $��1��6   ���#3E3D41$��
0,17,15,17q�5�      $ 10��5�      ._�5�      �� -
   5         ��Name$ BrowseLable��5�      $��Center=�5�      $��4,0,0,0q�5�      $��exe name��5�      $��SemiBold"�6,   
�������5�      5�      5�      �� 5  
   $��2��6   $��1��5     $��8��5     
�������$��20q�5     $ 20��5     ._�5     �� 
�������$��20q�5     $ 20��5	     ._�5     �� $��PREVIEW INCOMING��6   $��Center=�5     $��15(�5     5     5     5     5     