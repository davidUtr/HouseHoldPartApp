   M S B A M L   `   `   `  ����H  DHouseHoldPart, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:HouseHoldPart.View.PagesHouseHoldPart.View.Pages  5      +    %HouseHoldPart.View.Pages.EmployeePage   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      8local&clr-namespace:HouseHoldPart.View.Pages     5      _ [MaterialDesignThemes.Wpf, Version=4.9.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5
        � Language$  ru-RU�5       N� Title$ Сотрудники��5      $
��1000��6   $	��471��6'    � 	Resources 5         ItemContextMenu m�Name��%�   &	        �� 5   
   .@�5      m� $ EditMenuItem��6I   -   5        $ ��Редактировать��5      6I   m� 5      $ DeleteMenuItem��6E   -   5        $��Удалить��5      6E   5      5      .��5      � .+�5   
   �� -   5         ��Name$ AddScheduleButton��5   $   $��Добавить��6   $
��Left=�6`   $��31��6{   $��	10,10,0,0q�6�   $	��Top=�6�   $	��120��6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ 
ScheduleDG��5   �   $��0,64,0,0q�6      
IsReadOnly . "   VerticalScrollBarVisibility$ Hidden=�69      AutoGenerateColumns .  	   ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$	 * 6{   ��5      �� 5      
 �� 
TargetType)  #System.Windows.Controls.DataGridRow"
  6   .�5      -   5        5         Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   MinWidth$	 150Q�6%      Header$ Имя��64      Width$ * 6A   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6K   �� *NameEmployee+  5      $ Фамилия��6%   -   5        EmployeeName��$	 150Q�5   M   $ * 6\    6f   �� *SurnameEmployee+  5      $ Должность��6%   $	 150Q�68   $ * 6G    6Q   �� *
PostName+  5      $' !Контактные данные��6%   $ * 6@   $	 150Q�6J    6Y   �� *	Contact+5       �� 5!   
   -   5         ��Name$ 
SearchText��5!   �   $
��Left=�6   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$% Поиск сотрудника��6R   $��36��6�   $��
311,10,0,0q�6�    �� TextWrapping$
 Wrap=�6�   $	��Top=�6�   $	��260��6�   $��20(�6�   �� 5"   
   -   5        $ DocumentButton��5"   %   $��Документы��6   $
��Left=�6[   $��31��6v   $��
162,10,0,0q�6�   $	��Top=�6�   $	��120��6�   5$      5%      