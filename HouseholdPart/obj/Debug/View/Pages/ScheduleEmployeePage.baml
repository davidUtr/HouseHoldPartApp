   M S B A M L   `   `   `  ����H  DHouseHoldPart, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:HouseHoldPart.View.PagesHouseHoldPart.View.Pages  5      3    -HouseHoldPart.View.Pages.ScheduleEmployeePage   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      8local&clr-namespace:HouseHoldPart.View.Pages     5      _ [MaterialDesignThemes.Wpf, Version=4.9.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5
        � Language$  ru-RU�5       N� Title$ ScheduleEmployeePage��5      $
��1000��6$   $	��471��61    � 	Resources 5         ItemContextMenu m�Name��%=  &	        �� 5   
   .@�5      m� $ EditMenuItem��6I   -   5        $ ��Редактировать��5      6I   m� 5      $ DeleteMenuItem��6E   -   5        $��Удалить��5      6E   m� 5      $ CopyMenuItem��6F   -   5        $��Копировать��5      6F   5      5      .��5      � .+�5   
   �� -   5         ��Name$ AddScheduleButton��5   $   $��Добавить��6   $
��Left=�6_   $��31��6z   $��	10,10,0,0q�6�   $	��Top=�6�   $	��120��6�   (  "System.Windows.Controls.DatePicker  5   
   -   5          Name$ 
SearchDate��5      $
��Left=�6^   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Дата��6{   $��38��6�   $	��159��6�   $��	177,8,0,0q�6�   $	��Top=�6�   $��20(�6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ 
ScheduleDG��5   �   $��0,64,0,0q�6      
IsReadOnly . "	   VerticalScrollBarVisibility$	 Hidden=�69   
   AutoGenerateColumns
 .     ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ * 6{   ��5      �� 5       �� 
TargetType)  #System.Windows.Controls.DataGridRow"  6   .�5      -   5        5         Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   MinWidth$	 150Q�6%      Header$ Дата��64      Width$ * 6B   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6L   �� *Date+ �� StringFormat$ 
{0:dd MMM}��  5      $# Ф.И.О сотрудника��6%   -   5        EmployeeName��$	 150Q�5   V   $ * 6e    6o   �� *EmployeeName+  5      $* $Начало рабочего дня��6%   $	 150Q�6B   $ * 6Q    6[   �� *	TimeStart+  5       $( "Конец рабочего дня��6%   $ * 6A   $	 150Q�6K    6Z   �� *	TimeEnd+5"      �� 5#   
   -	   5         ��Name$ 
SearchText��5#   k   $
��Left=�6   $% Поиск сотрудника��6-   $��36��6_   $��
384,10,0,0q�6�    �� TextWrapping$
 Wrap=�6�   $	��Top=�6�   $	��260��6�   $��20(�6�   5%      5&      