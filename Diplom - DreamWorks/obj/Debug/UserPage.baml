   M S B A M L   `   `   `  ����E  ADreamsWork, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:DreamsWork
DreamsWork  5          DreamsWork.UserPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      *localclr-namespace:DreamsWork     5        N� Title$  UserPage��5	      .��5
      �  � RowDefinitions 5   
   �� 5      $
��377* �6   �� 5      $	��30* �6   �� 5      $	��30* �6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ DGridHolidays��5         AutoGenerateColumns .     
IsReadOnly .    Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Мероприятия��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6:   �� *Event+  5      $ Описание��6%    67   �� *Description+  5      $ Стоимость��6%    68   �� *Rate+5      �� 5   
   $��Тел:��6   $
��Left=�6    $��1��6;   $��	30,8,0,10q�6H   �� 5   
   $��iiipt@mail.ru��6   $��2��6)   $��129,8,601,10q�66   
���  ��6L   �� 5   
   $
��Mail��6   $��1��6    $��129,12,601,6q�6-   �� 5   
   $��+89125029712��6   
���  ��$��2��69   $
��Left=�6F   $��	30,8,0,10q�6a   5      5      