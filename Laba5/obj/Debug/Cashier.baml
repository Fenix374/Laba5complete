   M S B A M L   `   `   `  ����@  <Laba5, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:Laba5Laba5  5   	       Laba5.Cashier   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   %localclr-namespace:Laba5     5   	     � Title$  Cashier��5   	   $	��450��6   $	��800��6&   .��5	      �� .@�5
   
   �� -   5         ��Name$
 bill��5
      ��5      �� 5       �� Orientation$ 
Horizontal=�6   .+�5      �� $	��5,5q�6    Печать чека6:   5      ��5      � 5      -   5         �Name$
 grid��5      .+�5      &   System.Windows.Controls.DataGrid  -   5          Name$ dataGridAllCheck��5         AutoGenerateColumns .     Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ ID��61      FontSize$ 12Q�6=   1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 6K   �� *Games.game_id+  5      $ Игра��61   $ 12Q�6?   	 6M   �� *Games.title+  5      $ Цена��61   $ 12Q�6?   	 6M   �� *Games.price+  5      $ Дата выхода��61   $ 12Q�6F   	 6T   �� *Games.release_year+  5      $ Рейтинг��61   $ 12Q�6B   	 6P   �� *Games.avarage_rating+5      � 5      $��1��6   
 � ColumnDefinitions
 5      �� 5      $	��47* �6/   �� 5       $
��747* �6/    � RowDefinitions 5"      �� 5#      $��5* �6,   �� 5%      $��1* �6,   .+�5'      �� -   5         ��Name$ 	loginback��5'   !   $��в логин��64   
���   �
�������$��1��6�   $��584,0,10,290q�6�   �� 5(      -   5        $ 
filebutton��5(   !   $��В файл��65   
����  �
�������$��2��6�   $��	0,330,0,0q�6�   $��2��6�   5)      5*      5,      �� 5.   
   $��Чеки��6   .��5/      � .+�50      �� -   5         ��Name$ txtReceipts��50       �� TextWrapping$
 Wrap=�6/    �� AcceptsReturn . $��10q�6X   51      52      53      55      