   M S B A M L   `   `   `  ����H  DHouseHoldPart, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:HouseHoldPart.View.PagesHouseHoldPart.View.Pages  5      ,    &HouseHoldPart.View.Pages.EquipmentPage   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      8local&clr-namespace:HouseHoldPart.View.Pages     5      _ [MaterialDesignThemes.Wpf, Version=4.9.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5
        � Language$  ru-RU�5       N� Title$ ScheduleEmployeePage��5      $
��1000��6$   $	��471��61    � 	Resources 5         ItemContextMenu m�Name��%�   &	        �� 5   
   .@�5      m� $ EditMenuItem��6I   -   5        $ ��Редактировать��5      6I   m� 5      $ DeleteMenuItem��6)   -   5        $��Удалить��5      6A   5      5      .��5      �  � ColumnDefinitions 5   
   �� 5      $
��419* �6   �� 5      $
��381* �6   .+�5   
   �� -   5         ��Name$ AddScheduleButton��5   $   $��Добавить��6   $
��Left=�6`   $��31��6{   $��	10,10,0,0q�6�   $	��Top=�6�   $	��120��6�   (  "System.Windows.Controls.DatePicker  5   
   -   5          Name$ 
SearchDate��5      $
��Left=�6_   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Дата��6|   $��38��6�   $	��159��6�   $��	177,8,0,0q�6�   $	��Top=�6�   $��16(�6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ EquipmentDG��5   �   $��0,64,0,0q�6   	   
IsReadOnly	 . "
   VerticalScrollBarVisibility$
 Hidden=�69      AutoGenerateColumns .     ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ * 6{   $��2��6�   ��5      �� 5       �� 
TargetType)  #System.Windows.Controls.DataGridRow"  6   .�5      -   5        5         Columns 5       0  *System.Windows.Controls.DataGridTextColumn  5!      ,  &System.Windows.Controls.DataGridColumn   MinWidth$	 150Q�6%      Header$ Дата поставки��64      Width$ * 6K   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6U   �� *PurchaseDate+ �� StringFormat$ 
{0:dd MMM}��  5"      $ Материал��6%   -   5        EmployeeName��$	 150Q�5"   N   $ * 6]    6g   �� *NameEquipment+  5#      $ Помещение��6%   -   5        FacilitiesName��$	 150Q�5#   P   $ * 6_    6i   �� *FacilitiesName+  5$      $ Количество��6%   $	 150Q�69   $ * 6H    6R   �� *Count+  5%      $ Стоимость��6%   $ * 68   $	 150Q�6B    6Q   �� *Cost+5'      �� 5(   
   $��2��6   $
��Left=�6)   $��
353,10,0,0q�6D    �� Orientation$ 
Horizontal=�6X   $	��Top=�6q   .+�5)      �� $��27��6   $
��Wrap=�6$   $��87��68   $��16(�6C   �� 6R    � Language$ ru-ru�6V   $�Поставщик��6g   �� 6z   $�:��6~   6�   �� 5*      -	   5         ��Name$ SuppliersSearchButton��5*   �   $��10,0,0,0q�6    �� DisplayMemberPath$ NameSupplier��6�    �� SelectedValuePath$ 
SupplierId��6�   $��36��6�   $ Поставщик��6�   $	��114��6  $��16(�6)  ��6d   �� *	Suppliers+6)  5+      �� 5,   
   $��1��6   $
��Left=�6%   $��
145,12,0,0q�6@   $ 
Horizontal=�6T   $	��Top=�6m   .+�5.      �� $��27��6   $
��Wrap=�6$   $��98��68   $��16(�6C   �� 6R   $ ru-ru�6V   $�Помещение��6g   �� 6z   $�:��6~   6�   �� 50      -
   5        $ FacilitiesSearchButton��50     $��10,0,0,0q�6   $ NameFacilities��6�   $ FacilitiesId��6�   $��36��6�   $! Место хранения��6�   $	��139��6'  $��16(�63  ��6d   �� *
Facilities+63  51      53      54      