   M S B A M L   `   `   `  ����H  DHouseHoldPart, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullM+clr-namespace:HouseHoldPart.View.EditWindowHouseHoldPart.View.EditWindow  5   	   6    0HouseHoldPart.View.EditWindow.EditEmployeeWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   =local+clr-namespace:HouseHoldPart.View.EditWindow     5   	   ` \Xceed.Wpf.Toolkit, Version=4.5.23158.14510, Culture=neutral, PublicKeyToken=ba83ff368b7563c64xctk)http://schemas.xceed.com/wpf/xaml/toolkit  5   	   _ [MaterialDesignThemes.Wpf, Version=4.9.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5	   
     � Title$+  %Изменить информацию��5
   	   $	��450��6%   $	��538��62    � 
ResizeMode$ CanMinimize=�6>    � WindowStartupLocation$ CenterScreen=�6W   .��5      � .+�5   
   �� -   5         ��Name$ PostCB��5   0   $��Center=�6    �� SelectedValuePath$ PostId��6@   $��34��6|   $��	0,285,0,0q�6�   $	��Top=�6�   $	��191��6�   $��16(�6�    �� SelectedValue 6[   �� *IdPost+��5      �� 5      .R�5      ��  �� Orientation$ 
Horizontal=�6!   .+�5      �� ��6$   �� *
PostName+5      5      5      �� 5   
   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$! Серия паспорта��6   $
��Left=�6i   $��33��6�   $��
50,131,0,0q�6�    �� TextWrapping$
 Wrap=�6�   $	��Top=�6�   $	��191��6�   $��16(�6�   ��6B   �� *SerialPasportEmployee+6�   �� 5   
   $! Номер паспорта��6   $
��Left=�6i   $��33��6�   $��286,131,0,0q�6�   $
 Wrap=�6�   $	��Top=�6�   $	��191��6�   $��16(�6�   ��6B   �� *NumberPasportEmployee+6�   %  Xceed.Wpf.Toolkit.MaskedTextBox  5   
   	   Mask$	 +9(999) 999 99 99��6   $! Номер телефона��6O   $
��Left=�6   $��33��6�   $��
50,211,0,0q�6�   $
 Wrap=�6�   $	��Top=�6�   $	��191��6�   $��16(�6�   ��66   �� *	Contact+6�   �� 5   
   $ 
Адрес��6   $
��Left=�6R   $��33��6m   $��286,211,0,0q�6y   $
 Wrap=�6�   $	��Top=�6�   $	��217��6�   $��16(�6�   ��69   �� *	Address+6�   �� 5   
   $! Имя сотрудника��6   $
��Left=�6`   $��33��6{   $��	50,52,0,0q�6�   $
 Wrap=�6�   $	��Top=�6�   $	��191��6�   $��16(�6�   ��6B   �� *NameEmployee+6�   �� 5   
   $) #Фамилия сотрудника��6   $
��Left=�6g   $��33��6�   $��
286,52,0,0q�6�   $
 Wrap=�6�   $	��Top=�6�   $	��191��6�   $��16(�6�   ��6F   �� *SurnameEmployee+6�   �� 5   
   -   5        
 ��Name$
 
SaveButton��5      $��Сохранить��6>   $��Center=�6R   $��40��6o   $��	0,352,0,0q�6{   $	��Top=�6�   $	��140��6�   �� 5   
   $
��Left=�6   $��25��6/   $��	50,22,0,0q�6;   $
��Wrap=�6N   $	��Top=�6b   $	��191��6z   $��16(�6�   $"��Имя сотрудника:��6�   �� 5   
   $
��Left=�6   $��25��6/   $��
286,17,0,0q�6;   $
��Wrap=�6O   $	��Top=�6c   $	��191��6{   $��16(�6�   �� 6�    � Language$ ru-ru�6�   $�Фамилия��6�   �� 6�   $� сотрудника:��6�   6�   �� 5    
   $
��Left=�6   $��25��6/   $��
50,101,0,0q�6;   $
��Wrap=�6O   $	��Top=�6c   $	��191��6{   $��16(�6�   �� 6�   $ ru-ru�6�   $!�Серия паспорта��6�   �� 6�   $�:��6�   6�   �� 5!   
   $
��Left=�6   $��25��6/   $��286,101,0,0q�6;   $
��Wrap=�6P   $	��Top=�6d   $	��191��6|   $��16(�6�   �� 6�   $ ru-ru�6�   $!�Номер паспорта��6�   �� 6�   $�:��6�   6�   �� 5"   
   $
��Left=�6   $��25��6/   $��
50,176,0,0q�6;   $
��Wrap=�6O   $	��Top=�6c   $	��191��6{   $��16(�6�   �� 6�   $ ru-ru�6�   $!�Номер телефона��6�   �� 6�   $�:��6�   6�   �� 5#   
   $
��Left=�6   $��25��6/   $��286,176,0,0q�6;   $
��Wrap=�6P   $	��Top=�6d   $	��191��6|   $��16(�6�   �� 6�   $ ru-ru�6�   $�
Адрес��6�   �� 6�   $�:��6�   6�   �� 5$   
   $��Center=�6   $��25��61   $��	0,255,0,0q�6=   $
��Wrap=�6P   $	��Top=�6d   $��93��6|   $��16(�6�   �� 6�   $ ru-ru�6�   $�Должность��6�   �� 6�   $�:��6�   6�   5*      5+      