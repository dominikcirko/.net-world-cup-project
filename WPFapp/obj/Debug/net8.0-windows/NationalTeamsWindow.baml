   M S B A M L   `   `   `  ����A  =WPFapp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:WPFappWPFapp  5   	        WPFapp.NationalTeamsWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   &localclr-namespace:WPFapp     5   	     � Title$  NationalTeamsWindow��5   	   $	��450��6%   $	��800��62   $	��600��5	   	   $	��400��6   $
��1000��5
   	   $	��700��6   .��5      � $��20q�6    � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $
��Auto �6    � ColumnDefinitions 5   
   �� 5      $��1* �6   �� 5      $��2* �6   .+�5   
   �� $��Chosen National Team:��6   $
��Bold"�60   $��0��6B   $��0��6O   $��Center=�6_   $��0,0,10,0q�6z   $��Stretch=�6�   �� 5   
   -   5        $��lblChosenNationalTeam��5      $��0��6-   $��1��6:   $��Center=�6J   $��16(�6e   
����  �$��Stretch=�6�   �� 5   
   $��Select Opposing Team:��6   $
��Bold"�60   $��1��6B   $��0��6O   $��Center=�6_   $��0,0,10,0q�6z   $��Stretch=�6�   �� 5    
   -   5        $��cbOpposingTeam��5       $��1��6)   $��1��66   $��Center=�6F   $��Stretch=�6a   6   �� 5#   
   $��Match Result:��6   $
��Bold"�6(   $��2��6:   $��0��6G   $��Center=�6W   $��0,0,10,0q�6r   $��Stretch=�6�   �� 5$   
   -   5        $��lblMatchResult��5$      $��2��6&   $��1��63   $��Center=�6C   $��16(�6^   
��� d �$��Stretch=�6�   �� 5'   
   $��3��6   $��2��6"    �� Orientation$ 
Horizontal=�66   $��Center=�6O   $��Center=�6l   $��0,20,0,0q�6�   .+�5(      �� -   5        $��btnViewTeamDetails��5(      $��View Team Details��6/   $��0,0,10,0q�6l   $	��100��6~   $��Stretch=�6�   �� 5)      -   5        $��btnNext��5)      $
��Next��6$   $��0,0,0,0q�6I   $	��100��6Z   $��Stretch=�6i   5*      5+      5,      