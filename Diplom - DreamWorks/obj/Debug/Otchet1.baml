   M S B A M L   `   `   `  ����E  ADreamsWork, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:DreamsWork
DreamsWork  5          DreamsWork.Otchet1   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      *localclr-namespace:DreamsWork     5        N� Title$S  MСредние расходы на атрибуты по агентствам��5	      .��5      �  � RowDefinitions 5   
   �� 5      $��50 �6   �� 5      $
��377* �6   .+�5   
   �� $S��MСредние расходы на атрибуты по агентствам��6   $
��Left=�6E   $��40 0 0 0q�6`   $��Center=�6r   $��15(�6�   6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ DGridAgencies��5         AutoGenerateColumns .     
IsReadOnly . $��1��6X   $��
40 0 40 40q�6e      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Агентства��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$	 100 6R   1  +System.Windows.Controls.DataGridBoundColumn   Binding 68   �� *Title+6`     5      $@ :Средние расходы на все атрибуты��6%   $
 auto 6h    6N   �� *Price+6w   4  .System.Windows.Controls.DataGridTemplateColumn  5      $
 auto 6)   	   CellTemplate	 5      �� 5      .R�5      �� $��BtnEdit��6r   -   5        $��5q�5   %   $	��175��60   $��30��6<   $��Center=�6H   $
��Edit��6c   6�   5      5      5      5      5      