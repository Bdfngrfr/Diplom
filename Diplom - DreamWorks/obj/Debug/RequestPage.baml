   M S B A M L   `   `   `  ����E  ADreamsWork, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:DreamsWork
DreamsWork  5          DreamsWork.RequestPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      *localclr-namespace:DreamsWork     5        N� Title$  RequestPage��5	      .��5      �  � RowDefinitions 5   
   �� 5      $��50 �6   �� 5      $
��342* �6   �� 5      $	��58* �6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ DGridAgencies��5         AutoGenerateColumns .     
IsReadOnly . $��1��6X      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Id анматора��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$
 auto 6Z   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6:   �� *Id_Animator+6Z     5      $ Дата начала��6%   $
 auto 6[    6:   �� *Date_Holiday+6j     5      $ Время начала��6%   $
 auto 6Z    6;   �� *
Start_Time+6i     5      $ Гирлянда��6%   $
 auto 6S    67   �� *	Garland+6b     5      $) #Стоимость гирлянды��6%   $
 auto 6b    6A   �� *PriceGarland+6q     5      $ Фейерверк��6%   $	 100 6U    68   �� *
Firework+6c     5      $- 'Стоимость фейерверка��6%   $
 auto 6e    6C   �� *PriceFirework+6t     5      $ Хлопушка��6%   $
 auto 6R    67   �� *Petard+6a     5      $) #Стоимость хлопушки��6%   $
 auto 6a    6A   �� *PricePetard+6p     5      $ Мероприятие��6%   $
 auto 6T    6:   �� *Event+6c   5      5      5       