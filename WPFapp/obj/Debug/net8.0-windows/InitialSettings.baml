   M S B A M L   `   `   `  ����A  =WPFapp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:WPFappWPFapp  5   	       WPFapp.InitialSettings   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   &localclr-namespace:WPFapp     5   	     � Title$  
MainWindow��5   	   $	��500��6   $	��600��6)   $	��600��65   $	��500��6D   .��5
      � $��10q�6    � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6    � ColumnDefinitions 5   
   �� 5      $��* �6   .+�5   
   �� $��0��6   $��Center=�6"   $��Stretch=�6=   $��	0,10,0,10q�6[   .+�5      �� -   5        $��	lblGender��5      $��Select Gender:��6%   $��Center=�6>   $��16(�6[   �� 5       �� Orientation$ 
Horizontal=�6   $��Center=�62   .+�5      �� -   5        $��btnMale��5      $
��Male��6(   $��5q�67   $	��100��5      $��30��6(   $��Stretch=�5      $��Stretch=�67   �� 5      -   5        $��	btnFemale��5      $��Female��6*   $��5q�6;   $	��100��5       $��30��6(   $��Stretch=�5!      $��Stretch=�67   5"      5#      �� 5&   
   $��1��6   $��Center=�6"   $��Stretch=�6=   $��	0,10,0,10q�6[   .+�5'      �� -   5        $��lblLanguage��5'      $��Select Language:��6'   $��Center=�6B   $��16(�6_   �� 5(      $ 
Horizontal=�6   $��Center=�62   .+�5)      �� -   5        $��
btnEnglish��5)      $��English��6+   $��5q�6=   $	��100��5*      $��30��6(   $��Stretch=�5+      $��Stretch=�67   �� 5,      -   5        $��btnCroatian��5,      $��Croatian��6,   $��5q�6?   $	��100��5-      $��30��6(   $��Stretch=�5.      $��Stretch=�67   5/      50      �� 53   
   $��2��6   $��Center=�6"   $��Stretch=�6=   $��	0,10,0,10q�6[   .+�54      �� -   5        $��lblNationalTeam��54      $��Select Championship:��6+   $��Center=�6J   $��16(�6g   �� 55      -   5        $��cbChampionship��55      $��5q�6-   $	��150��56      $	��400��6&   $��30��65   $��Stretch=�57      $��Stretch=�65   58      �� 5;   
   $��3��6   $ 
Horizontal=�6"   $��Center=�6;   $��Center=�6X   $��	0,10,0,10q�6s   .+�5<      �� -	   5        $��btnBack��5<      $
��Back��6$   $��5q�63   ${�False��6T   $	��100��5=      $��30��6$   $��Stretch=�5>      $��Stretch=�63   �� 5?      -
   5        $��btnNext��5?      $
��Next��6$   $��5q�63   $	��100��5@      $��30��6$   $��Stretch=�5A      $��Stretch=�63   �� 5B      -   5        $��btnExit��5B      $
��Exit��6$   $��5q�63   $	��100��5C      $��30��6$   $��Stretch=�5D      $��Stretch=�63   5E      �� 5H   
   -   5        $��	lblErrMsg��5H      $��4��6   
���  ��$��0,20,0,0q�6?   $��Center=�5I      $��Center=�6-   $��14(�6H   5J      5K      