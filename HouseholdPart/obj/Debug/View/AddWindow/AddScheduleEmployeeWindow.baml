   M S B A M L   `   `   `  ����H  DHouseHoldPart, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullK*clr-namespace:HouseHoldPart.View.AddWindowHouseHoldPart.View.AddWindow  5   	   9!clr-namespace:HouseHoldPart.ModelHouseHoldPart.Model  5
      <    6HouseHoldPart.View.AddWindow.AddScheduleEmployeeWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   <local*clr-namespace:HouseHoldPart.View.AddWindow     5   	   4locals!clr-namespace:HouseHoldPart.Model     5
      ` \Xceed.Wpf.Toolkit, Version=4.5.23158.14510, Culture=neutral, PublicKeyToken=ba83ff368b7563c64xctk)http://schemas.xceed.com/wpf/xaml/toolkit  5   	   _ [MaterialDesignThemes.Wpf, Version=4.9.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	     � Language$  ru-RU�5   	    � Title$/ )Добавление расписания��5   	   $	��516��6'   $	��392��64    � 
ResizeMode$ CanMinimize=�6@    � WindowStartupLocation$ CenterScreen=�6Y    � 	Resources 5      3   -HouseHoldPart.Model.TimeSpanToStringConverter   TimeSpanToStringConverter��%   &	          5   
   6+   5      .��5      � .+�5   
   �� $��Center=�6   $��	5,120,0,0q�62    �� Orientation$ Vertical=�6E   $	��Top=�6\   $	��225��6t   .+�5      �� $��31��6   $
��Wrap=�6$   $	��103��68   $��14(�6D   �� 6S   $�Дата��6W   �� 6e    � Language$ ru-ru�6i   $� и время��6z   6�   (  "System.Windows.Controls.DatePicker  5      -   5          Name$
 Date��5      )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Дата��6'   $��41��6x   $	��110��6�   $��14(�6�   	   SelectedDate	 6M   �� *Date+
 �� Mode$
 TwoWay=�6�   �� 5      $ 
Horizontal=�6   $	��160��62   .+�5      %  Xceed.Wpf.Toolkit.MaskedTextBox  -   5          Name$ TimeText��5   �   $��15q�6%      Mask$ 00:00��61   $��26��6�    �� TextWrapping$
 Wrap=�6�   $' !Время (час,мин,сек)��6�   $��40��6�   $��14(�6  ��6>   �� *	TimeStart+ �� 	Converter# [  6  �� 5      $	�� - ��6   $��38��6'   $��24(�63     5      -   5        $ TimeEndText��5   �   $��15q�6%   $ 00:00��61   $��26��6�   $
 Wrap=�6�   $' !Время (час,мин,сек)��6�   $��40��6�   $��14(�6  ��6>   �� *	TimeEnd+# [  6  5      �� 5      $��31��6   $
��Wrap=�6$   $3��-Фамилия и имя сотрудника��68   $	��186��6X   $��14(�6d   �� 5      -   5         ��Name$ EmployeeName��5      $ Фамилия и имя��6-    �� SelectedValuePath$ 
EmployeeId��6^   $��32��6�   $	��174��6�   $��14(�6�    �� SelectedValue 6}   �� *
IdEmployee+��5      �� 5      .R�5      �� $ 
Horizontal=�6%   .+�5      �� ��6(   �� *NameEmployee+�� 5       $�� ��6(   �� 5!      ��6(   �� *SurnameEmployee+5"      5#      5%      5&      �� 5'   
   $��Center=�6   $��79��61   $
��Wrap=�6=   $	��Top=�6Q   $	��230��6i   $��0,19,0,0q�6u   $��28(�6�   $
��Bold"�6�    �� TextAlignment$ Center=�6�   �� 6�   $ ru-ru�6�   $�Добавление ��6�   �� 6�   $�расписания��6�   6  �� 5(   
   -   5         ��Name$ 
SaveButton��5(   @   $��Сохранить��6,   $
��Left=�6U   $��42��6p   $��116,406,0,0q�6|   $	��Top=�6�   $	��166��6�   5*      5+      