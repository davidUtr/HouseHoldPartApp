   M S B A M L   `   `   `  ����H  DHouseHoldPart, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullK*clr-namespace:HouseHoldPart.View.AddWindowHouseHoldPart.View.AddWindow  5   	   5    /HouseHoldPart.View.AddWindow.AddEquipmentWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   <local*clr-namespace:HouseHoldPart.View.AddWindow     5   	   _ [MaterialDesignThemes.Wpf, Version=4.9.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5	   	     � Language$  ru-RU�5   	    � Title$' !Добавить материал��5
   	   $	��450��6#   $	��506��60    � 
ResizeMode$ CanMinimize=�6<    � WindowStartupLocation$ CenterScreen=�6U   .��5      � .+�5   
   �� -   5         ��Name$ NameEquipmentText��5   L   $
��Left=�6   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Материал��6g   $��35��6�   $��	30,41,0,0q�6�    �� TextWrapping$
 Wrap=�6�   $	��Top=�6�   $	��166��6�   $��16(�6�    �� TextAlignment$ Center=�6�   ��6-   �� *NameEquipment+6�   �� 5   
   $
��Left=�6   $��26��6/   $��	10,10,0,0q�6;   $
��Wrap=�6N   $	��Top=�6b   $	��205��6z   $��16(�6�   $2��,Наименование материала:��6�    �� TextAlignment$ Center=�6�   �� 5   
   -   5        	 ��Name$	 SuppliersCB��5   V   
 �� DisplayMemberPath$
 NameSupplier��65    �� SelectedValuePath$ 
SupplierId��6k   $
��Left=�6�   $��35��6�   $��302,150,0,0q�6�   $	��Top=�6�   $	��166��6�   $��16(�6�   ��6   �� *	Suppliers+6�   �� 5   
   $
��Left=�6   $��26��6/   $��338,116,0,0q�6;   $
��Wrap=�6P   $	��Top=�6d   $��94��6|   $��16(�6�   $��Поставщик:��6�   (  "System.Windows.Controls.DatePicker  5   
   -   5          Name$ PurchaseDate��5   ;   $
��Left=�6Q   $��35��6l   $	��166��6x   $��
302,41,0,0q�6�   $	��Top=�6�   $��16(�6�      SelectedDate 6   �� *PurchaseDate+6�   �� 5   
   $
��Left=�6   $��26��6/   $��
324,10,0,0q�6;   $
��Wrap=�6O   $	��Top=�6c   $	��122��6{   $��16(�6�   �� 6�    � Language$ ru-ru�6�   $�Дата поставки��6�   �� 6�   $�:��6�   6�   �� 5   
   $
��Left=�6   $��26��6/   $��
10,116,0,0q�6;   $
��Wrap=�6O   $	��Top=�6c   $	��205��6{   $��16(�6�   $"��Место хранения:��6�   $ Center=�6�   �� 5   
   -   5        $	 FacilitiesCB��5   Y   $
 NameFacilities��66   $ FacilitiesId��6o   $
��Left=�6�   $��35��6�   $��
48,150,0,0q�6�   $	��Top=�6�   $	��128��6�   $��16(�6�   ��6   �� *
Facilities+5      �� 5   
   -   5        $ 	CountText��5      $
��Left=�6%   $ 20��6�   $��35��6�   $��
30,260,0,0q�6�   $
 Wrap=�6�   $	��Top=�6�   $	��166��6�   $��16(�6�   $ Center=�6  ��6@   �� *Count+6  �� 5   
   $
��Left=�6   $��26��6/   $��
10,228,0,0q�6;   $
��Wrap=�6O   $	��Top=�6c   $	��205��6{   $��16(�6�   $ Center=�6�   �� 6�   $ ru-ru�6�   $,�&Количество на складе��6�   �� 6�   $�:��6�   6�   �� 5   
   -   5         ��Name$ 
SaveButton��5   �   $��Сохранить��6   $��Center=�6%   $��40��6B   $��	0,335,0,0q�6N   $	��Top=�6a   $	��153��6y   6�   �� 5   
   -   5        $ CostText��5   >   $
��Left=�6P   $ 25000��6�   $��35��6�   $��302,260,0,0q�6�   $
 Wrap=�6�   $	��Top=�6�   $	��166��6�   $��16(�6  $ Center=�6  ��6k   �� *Cost+6  �� 5   
   $
��Left=�6   $��26��6/   $��282,228,0,0q�6;   $
��Wrap=�6P   $	��Top=�6d   $	��205��6|   $��16(�6�   $ Center=�6�   �� 6�   $ ru-ru�6�   $�Стоимость��6�   6�   5      5      