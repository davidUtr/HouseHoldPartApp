   M S B A M L   `   `   `  ����H  DHouseHoldPart, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:HouseHoldPart.ViewHouseHoldPart.View  5   	   #    HouseHoldPart.View.MainWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:HouseHoldPart.View     5   	   _ [MaterialDesignThemes.Wpf, Version=4.9.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	     � Title$  Главное меню��5	   	   $	��600��6   $
��1000��6+    � 
ResizeMode$ CanMinimize=�68    � WindowStartupLocation$ CenterScreen=�6Q   ���	#FF2196F3.��5
      � $	��600��6   .+�5   
   �� $��Center=�6   $��98��61   $	��Top=�6=   $
��1000��6U   ���	#FF2196F36b   �� 5   
   -   5         ��Name$ 
ExitButton��5   !   $��
Выйти��6   $
��Left=�6N   $��36��6i   $��
894,36,0,0q�6u   $	��Top=�6�   $��96��6�   �� 5   
   -   5         ��Name$ nameUserText��5   c   $
��Left=�6   $��57��6/   $��
734,35,0,0q�6;   $
��Wrap=�6O   $	��Top=�6y   $	��140��6�   $��18(�6�    �� TextAlignment$ Right=�6�   
�������6�    � 5   
   -   5          �Name$ 	MainFrame��5        � NavigationUIVisibility$ Hidden=�6#   $��
0,103,0,26q�6C   �� 5   
   -   5        $ ScheduleButton��5      $1��+Расписание сотрудников��6F   $
��Left=�6g   $��35��6�   $��	19,54,0,0q�6�   $	��Top=�6�   $	��197��6�   �� 5   
   -   5        $ EmployeeButton��5      $��Сотрудники��6F   $
��Left=�6[   $��35��6v   $��
234,54,0,0q�6�   $	��Top=�6�   $	��110��6�   �� 5   
   -   5        $ EquipmentButton��5   %   $��Материалы��6   $
��Left=�6\   $��35��6w   $��
363,54,0,0q�6�   $	��Top=�6�   $	��109��6�   �� 5   
   -   5        $ SuppliersButton��5      $��Поставщики��6H   $
��Left=�6]   $��35��6x   $��
493,54,0,0q�6�   $	��Top=�6�   $	��114��6�   �� 5   
   -   5        $ FacilitiesButton��5      $��Помещения��6J   $
��Left=�6^   $��35��6y   $��
628,54,0,0q�6�   $	��Top=�6�   $	��114��6�   5      5      