   M S B A M L   `   `   `  ����H  DHouseHoldPart, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullK*clr-namespace:HouseHoldPart.View.AddWindowHouseHoldPart.View.AddWindow  5   	   5    /HouseHoldPart.View.AddWindow.AddSuppliersWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   <local*clr-namespace:HouseHoldPart.View.AddWindow     5   	   _ [MaterialDesignThemes.Wpf, Version=4.9.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   
   ` \Xceed.Wpf.Toolkit, Version=4.5.23158.14510, Culture=neutral, PublicKeyToken=ba83ff368b7563c64xctk)http://schemas.xceed.com/wpf/xaml/toolkit  5   	     � Title$+  %Добавить поставщика��5
   	   $	��450��6%   $	��383��62    � 
ResizeMode$ CanMinimize=�6>    � WindowStartupLocation$ CenterScreen=�6W    � 	Resources 5       �� 
TargetType)  #MaterialDesignThemes.Wpf.HintAssist �� Property �� Value �� Triggers �� Binding	 �� ElementName
 �� Path �� Value��%5  '��       �� 5   
   FmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  6.   " ��6   .�5      ��  �@ Hint$ Описание��6?   �� 5       � ��$	 137��6'   �� 5       � ��$ 	0,217,0,0q�6'   �� 5       �@��TextWrapping$
 Wrap=�6-   �� 5       � ��$	 363��6&   �� 5       � ��$ 14(�6)   �� 5       �@J�OpacityMask
 �   �6,    5      �� 5       6   �� $	 	myTextBox��$
 	IsFocused� True6X   .a�5      ��  � ��$ 2q�68   5      5      5      .��5      � .+�5   
   �� $
��Left=�6   $��29��6/   $��	89,23,0,0q�6;   $
��Wrap=�6N   $	��Top=�6b   $	��179��6z   $��16(�6�   �� 6�   $�Название орг��6�   �� 6�    � Language$ ru-ru�6�   $�а��6�   �� 6�   $�н��6�   �� 6�   $ ru-ru�6�   $�и��6�   �� 6�   $�зации:��6  6  �� 5   
   -   5         ��Name$ NameSupplierText��5      $
��Left=�6,      Hint$- 'Название организации��6e   $��31��6�   $��	89,52,0,0q�6�    �� TextWrapping$
 Wrap=�6�   $	��Top=�6�   $	��179��6�   $��14(�6�    �� TextAlignment$ Center=�6   ��6G   �� *NameSupplier+6   �� 5   
   $
��Left=�6   $��29��6/   $��
112,95,0,0q�6;   $
��Wrap=�6O   $	��Top=�6c   $	��133��6{   $��16(�6�   �� 6�   $ ru-ru�6�   $!�Номер телефона��6�   �� 6�   $�:��6�   6�   %  Xceed.Wpf.Toolkit.MaskedTextBox  5   
   -   5          Name$ 	PhoneText��5   S   $
��Left=�68   $- 'Название организации��6f   $��31��6�   $��
89,124,0,0q�6�   $
 Wrap=�6�   $	��Top=�6�   $	��179��6�   $��14(�6�   $ Center=�6  ��6   �� *	Contact+6  �� 5    
   $
��Left=�6   $��29��6/   $��134,173,0,0q�6;   $
��Wrap=�6P   $	��Top=�6d   $��90��6|   $��16(�6�   $��Описание:��6�   �� 5!   
   -   5        $ Comments��5!      $
��Left=�6>   $ Описание��6Y   $��76��6�   $��
36,207,0,0q�6�   $
 Wrap=�6�   $	��Top=�6�   $	��285��6�   $��14(�6�    J� OpacityMask
 �   ���6$   �� *
Comments+6�   �� 5"   
   -   5         ��Name$ 
SaveButton��5"   %   $��Сохранить��6   $
��Left=�6S   $��35��6n   $��112,334,0,0q�6z   $	��Top=�6�   $	��123��6�   5$      5%      