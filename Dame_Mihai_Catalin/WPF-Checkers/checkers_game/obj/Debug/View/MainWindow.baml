   M S B A M L   `   `   `  ����H  Dcheckers_game, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:checkers_game.ViewModelcheckers_game.ViewModel  5   	       checkers_game.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   7local%clr-namespace:checkers_game.ViewModel     5   	     � Title$  WPF Checkers��5   	   $	��800��6   $	��800��6+   $	��800��6;   $
��1000��6K   $
��1000��6X   $
��1000��6h   ��5	      �� 5
   
    �� ImageSource$3 -/checkers_game;component/Resources/fundal.jpg��6   6S    � DataContext 5      '  !checkers_game.ViewModel.VMBinding  5   
    � 	Resources 5       �� 
TargetType �� Property �� Value   WindowBackgroundBrush � Offset � Color  side_grid_BackgroundBrush��%�  '��       '�� H     '�� �     &	  ~    &	 %    �� 5   
   " ��6   .�5      ��  � ��$ 70(�6)   5      �� 5   
   " ��6   .�5      ��  � ��$ 20(�6)   �� 5       � ��$ Georgia)�6+   �� 5       � ��$ DemiBold"�6+   5      �� 5   
   " ��6   .�5      ��  � ��$ 20(�6)   �� 5       � ��$ Georgia)�6+   �� 5       � ��$ DemiBold"�6+   5      �� 5    
   .��5!      � $ 0Q�6   $ White��6&   � 5"      $ .5Q�6   $ DarkGray��6'   � 5#      $ 1Q�6   $ 
WhiteSmoke��6&   5$      �� 5&   
   .��5'      � $ 0Q�6   $ White��6&   � 5(      $ .5Q�6   $ DarkGray��6'   � 5)      $ 1Q�6   $ 
WhiteSmoke��6&   5*      5/      .��52      � -   5        	 �Name$	 	Container��52      $
��Left=�6   $	��906��69   
 � ColumnDefinitions
 53   
   �� 54      $
��169* �6   �� 55      $	��29* �6   .+�57   
   � -   5        $	 Board��57      $��	0,0,121,1q�6   $��2��62   
 59      �� 5:      $��* �6#   �� 5;      $��* �6#   �� 5<      $��* �6#   �� 5=      $��* �6#   �� 5>      $��* �6#   �� 5?      $��* �6#   �� 5@      $��* �6#   �� 5A      $��* �6#    � RowDefinitions 5F      �� 5G      $��* �6    �� 5H      $��* �6    �� 5I      $��* �6    �� 5J      $��* �6    �� 5K      $��* �6    �� 5L      $��* �6    �� 5M      $��* �6    �� 5N      $��* �6    .+�5Q      �� -   5         ��Name$ b1��5Q   +   
�����p�$��0��6R   $��0��6c   ��5R      �� 5S       j� Stretch$
 Fill=�6i    6!   �� *ImageSource+ �� UpdateSourceTrigger$ PropertyChanged=�6i   5U      �� 5V      -   5        $ b2��5V   +   
�����p�$��2��6R   $��0��6c   ��5W      �� 5X      $
 Fill=�6i    6!   �� *ImageSource+$ PropertyChanged=�6i   5Z      �� 5[      -   5        $ b3��5[   +   
�����p�$��4��6R   $��0��6c   ��5\      �� 5]      $
 Fill=�6i    6!   �� *ImageSource+$ PropertyChanged=�6i   5_      �� 5`      -   5        $ b4��5`   +   
�����p�$��6��6R   $��0��6c   ��5a      �� 5b      $
 Fill=�6i    6!   �� *ImageSource+$ PropertyChanged=�6i   5d      �� 5f      -   5        $ b5��5f   +   
�����p�$��1��6R   $��1��6c   ��5g      �� 5h      $
 Fill=�6i    6!   �� *ImageSource+$ PropertyChanged=�6i   5j      �� 5k      -   5        $ b6��5k   +   
�����p�$��3��6R   $��1��6c   ��5l      �� 5m      $
 Fill=�6i    6!   �� *ImageSource+$ PropertyChanged=�6i   5o      �� 5p      -	   5        $ b7��5p   +   
�����p�$��5��6R   $��1��6c   ��5q      �� 5r      $
 Fill=�6i    6!   �� *ImageSource+$ PropertyChanged=�6i   5t      �� 5u      -
   5        $ b8��5u   +   
�����p�$��7��6R   $��1��6c   ��5v      �� 5w      $
 Fill=�6i    6!   �� *ImageSource+$ PropertyChanged=�6i   5y      �� 5{      -   5        $ b9��5{   +   
�����p�$��0��6R   $��2��6c   ��5|      �� 5}      $
 Fill=�6i    6!   �� *ImageSource+$ PropertyChanged=�6i   5      �� 5�      -   5        $	 b10��5�   +   
�����p�$��2��6S   $��2��6d   ��5�      �� 5�      $
 Fill=�6i    6!   �� *ImageSource+$ PropertyChanged=�6i   5�      �� 5�      -   5        $	 b11��5�   +   
�����p�$��4��6S   $��2��6d   ��5�      �� 5�      $
 Fill=�6i    6!   �� *ImageSource+$ PropertyChanged=�6i   5�      �� 5�      -   5        $	 b12��5�   +   
�����p�$��6��6S   $��2��6d   ��5�      �� 5�      $
 Fill=�6i    6!   �� *ImageSource+$ PropertyChanged=�6i   5�      �� 5�      -   5        $	 b13��5�   +   
�����p�$��1��6S   $��3��6d   ��5�      �� 5�      $
 Fill=�6i    6!   �� *ImageSource+$ PropertyChanged=�6i   5�      �� 5�      -   5        $	 b14��5�   +   
�����p�$��3��6S   $��3��6d   ��5�      �� 5�      $
 Fill=�6i    6!   �� *ImageSource+$ PropertyChanged=�6i   5�      �� 5�      -   5        $	 b15��5�   +   
�����p�$��5��6S   $��3��6d   ��5�      �� 5�      $
 Fill=�6i    6!   �� *ImageSource+$ PropertyChanged=�6i   5�      �� 5�      -   5        $	 b16��5�   +   
�����p�$��7��6S   $��3��6d   ��5�      �� 5�      $
 Fill=�6i    6!   �� *ImageSource+$ PropertyChanged=�6i   5�      �� 5�      -   5        $	 b17��5�   +   
�����p�$��0��6S   $��4��6d   ��5�      �� 5�      $
 Fill=�6i    6!   �� *ImageSource+$ PropertyChanged=�6i   5�      �� 5�      -   5        $	 b18��5�   +   
�����p�$��2��6S   $��4��6d   ��5�      �� 5�      $
 Fill=�6i    6!   �� *ImageSource+$ PropertyChanged=�6i   5�      �� 5�      -   5        $	 b19��5�   +   
�����p�$��4��6S   $��4��6d   ��5�      �� 5�      $
 Fill=�6i    6!   �� *ImageSource+$ PropertyChanged=�6i   5�      �� 5�      -   5        $	 b20��5�   +   
�����p�$��6��6S   $��4��6d   ��5�      �� 5�      $
 Fill=�6i    6!   �� *ImageSource+$ PropertyChanged=�6i   5�      �� 5�      -   5        $	 b21��5�   +   
�����p�$��1��6S   $��5��6d   ��5�      �� 5�      $
 Fill=�6i    6!   �� *ImageSource+$ PropertyChanged=�6i   5�      �� 5�      -   5        $	 b22��5�   +   
�����p�$��3��6S   $��5��6d   ��5�      �� 5�      $
 Fill=�6i    6!   �� *ImageSource+$ PropertyChanged=�6i   5�      �� 5�      -   5        $	 b23��5�   +   
�����p�$��5��6S   $��5��6d   ��5�      �� 5�      $
 Fill=�6i    6!   �� *ImageSource+$ PropertyChanged=�6i   5�      �� 5�      -   5        $	 b24��5�   +   
�����p�$��7��6S   $��5��6d   ��5�      �� 5�      $
 Fill=�6i    6!   �� *ImageSource+$ PropertyChanged=�6i   5�      �� 5�      -   5        $	 b25��5�   +   
�����p�$��0��6S   $��6��6d   ��5�      �� 5�      $
 Fill=�6i    6!   �� *ImageSource+$ PropertyChanged=�6i   5�      �� 5�      -   5        $	 b26��5�   +   
�����p�$��2��6S   $��6��6d   ��5�      �� 5�      $
 Fill=�6i    6!   �� *ImageSource+$ PropertyChanged=�6i   5�      �� 5�      -   5        $	 b27��5�   +   
�����p�$��4��6S   $��6��6d   ��5�      �� 5�      $
 Fill=�6i    6!   �� *ImageSource+$ PropertyChanged=�6i   5�      �� 5�      -   5        $	 b28��5�   +   
�����p�$��6��6S   $��6��6d   ��5�      �� 5�      $
 Fill=�6i    6!   �� *ImageSource+$ PropertyChanged=�6i   5�      �� 5�      -   5        $	 b29��5�   +   
�����p�$��1��6S   $��7��6d   ��5�      �� 5�      $
 Fill=�6i    6!   �� *ImageSource+$ PropertyChanged=�6i   5�      �� 5�      -    5        $	 b30��5�   +   
�����p�$��3��6S   $��7��6d   ��5�      �� 5�      $
 Fill=�6i    6!   �� *ImageSource+$ PropertyChanged=�6i   5�      �� 5�      -!   5        $	 b31��5�   +   
�����p�$��5��6S   $��7��6d   ��5�      �� 5�      $
 Fill=�6i    6!   �� *ImageSource+$ PropertyChanged=�6i   5�      �� 5�      -"   5        $	 b32��5�   +   
�����p�$��7��6S   $��7��6d   ��5�      �� 5�      $
 Fill=�6i    6!   �� *ImageSource+$ PropertyChanged=�6i   5�      5�      �� 5�   
   -#   5        $��Instructiunile  jocului��5�      $
��Bold"�63   $
��Left=�6\   $��32,552,-72,0q�6w   $	��Top=�6�   $	��173��6�   $��79��6�   $��16(�6�   $��1��6�    5�      ��%^   '��       �� 5�      " ��6   .�5�      ��  �@��CornerRadius$ 5��65   5�      5�      5      �� 5  
   -$   5         ��Name$
 data��5     $
��Bold"�6    $��21��62   $��32,494,-72,0q�6>    �� TextWrapping$
 Wrap=�6T   $��TextBox��6h   $	��Top=�6w   $��1��6�   6�   �� 5  
   -%   5        $��
Statistici��5     $
��Bold"�6<   $��20(�6N   $��1��6\   $
��Left=�6l   $��32,401,-72,0q�6�   $	��Top=�6�   $	��173��6�   $��38��6�   �� 5  
   -&   5        $ jucator��5     $��1��6#   $
��Left=�63   $��32��6N   $��32,259,-72,0q�6Z   $
 Wrap=�6p   $��TextBox��6�   $	��Top=�6�   $	��173��6�   5     5     