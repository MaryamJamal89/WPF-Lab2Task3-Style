   M S B A M L   `   `   `  ����F  BWPF02_Task1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:WPF02_Task1WPF02_Task1  5   	       WPF02_Task1.LogInScreen   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:WPF02_Task1     5   	     � Title$  LogInScreen��5   	   $	��450��6   $	��800��6*    � WindowStartupLocation$ CenterScreen=�66    � WindowState$ 	Maximized=�6[    � 	Resources 5	       �� Source�� 5
   
   $$ Lab2Task4_StyleDictionary.xaml?�6   %    .��5      �  � ColumnDefinitions 5   
   �� 5      �� 5      �� 5      �� 5       � RowDefinitions 5   
   �� 5      $��2* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   .+�5   
   �� -   5        $��profileBorder��5      $��0��5      $��0��5         MyBorderImgStyle#��[  5       ��5!      �� 5"       j� Stretch$
 Fill=�5#       �� ImageSource$w qD:\Privacy collector with the utmost confidentiality\Ma Collage\ITI\9Month\28- WPF\WPF02\WPF02_Task1\Images\3.jpg��5$      ._�5&      �� -   5        $��btnOne��5(        MyButtonImgStyle#��[ 5'      
������ 5+      5,      �� 5.   
   $��0��5/      $��1��50      #��[  51      ��52      �� 53      $
 Fill=�54      $w qD:\Privacy collector with the utmost confidentiality\Ma Collage\ITI\9Month\28- WPF\WPF02\WPF02_Task1\Images\4.jpg��55      ._�57      �� -   5        $��btnTwo��59      #��[ 58      
������ 5<      5=      �� 5?   
   $��0��5@      $��2��5A      #��[  5B      ��5C      �� 5D      $
 Fill=�5E      $w qD:\Privacy collector with the utmost confidentiality\Ma Collage\ITI\9Month\28- WPF\WPF02\WPF02_Task1\Images\2.jpg��5F      ._�5H      �� -   5        $��btnThree��5J      #��[ 5I      
������ 5M      5N      �� 5P   
   $��0��5Q      $��3��5R      #��[  5S      ��5T      �� 5U      $
 Fill=�5V      $w qD:\Privacy collector with the utmost confidentiality\Ma Collage\ITI\9Month\28- WPF\WPF02\WPF02_Task1\Images\1.jpg��5W      ._�5Y      �� -   5        $��btnFour��5[      #��[ 5Z      
������ 5^      5_      G� 5b   
   -   5        $��PasswordBox��5f      $��1��5c      $��1��5d      $��2��5e        MyPasswordBoxStyle#��[ 5g      5h      � 5j   
   $��2��5k      $��1��5l      $��2��5m      $	��300��5n      $��40��5o      .+�5p      �� $��Center=�5q      $��Center=�5r      $��20(�5s      $
��Bold"�5t      Login5u      �� 5v      -   5        $��Login��5x        MyButtonLoginStyle#��[ 5w      
������ 5z      5{      � 5~   
   $��3��5      $��0��5�      $��2��5�      $	��300��5�      $��40��5�      .+�5�      ��   MyTextBlockForgetStyle#��[ 5�      Forget Password5�   #   �� 5�      -   5        $��forget��5�        MyButtonForgetStyle#��[ 5�      
������ 5�      5�      � 5�   
   $��3��5�      $��3��5�      $	��150��5�      $��40��5�      .+�5�      �� #��[ 5�      
New User5�      �� 5�      -	   5        $��NewUser��5�      #��[ 5�      
������ 5�      5�      5�      5�      