   M S B A M L   `   `   `  ����E  ADreamsWork, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:DreamsWork
DreamsWork  5          DreamsWork.ManagerPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      *localclr-namespace:DreamsWork     5        N� Title$  ManagerPage��5	      .��5      �  � RowDefinitions 5   
   �� 5      $
��377* �6   �� 5      $��50 �6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ DGridHolidays��5         AutoGenerateColumns .     
IsReadOnly .    Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Фамилия��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6T   1  +System.Windows.Controls.DataGridBoundColumn   Binding 66   �� *	FirstName+6`     5      $ Имя��6%   $	 150 6O    62   �� *
LastName+6]     5      $ Пароль��6%   $ * 6R    65   �� *
Password+6^     5      $ 
Почта��6%   $ * 6M    64   �� *Mail+6Y     5      $ Роль��6%   $ * 6L    63   �� *Role+6X   5      �� 5   
   -   5        $��
BtnOtchet1��5   I   $��
Сумма��6   $��1��6!   $
��Left=�6.   $	��175��6t   $��30��6�   $��10 0 0 0q�6�   6�   �� 5   
   -   5        $��Request��5   K   $��Заявки��6   $��1��6"   $��Right=�6/   $	��175��6p   $��30��6|   $��0 0 10 0q�6�   6�   5      5      