   M S B A M L   `   `   `  ����H  DHouseHoldPart, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:HouseHoldPart.ViewHouseHoldPart.View  5   	   '    !HouseHoldPart.View.DocumentWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:HouseHoldPart.View     5   	   _ [MaterialDesignThemes.Wpf, Version=4.9.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	     � Title$'  !Список документов��5	   	   $	��450��6#   $	��327��60    � 
ResizeMode$ CanMinimize=�6<    � WindowStartupLocation$ CenterScreen=�6U    � 	Resources 5
         ItemContextMenu m�Name��%�   &	        �� 5   
   .@�5      m� $ EditMenuItem��6I   -   5        $ ��Редактировать��5      6I   m� 5      $ DeleteMenuItem��6E   -   5        $��Удалить��5      6E   5      5      .��5      � .+�5   
   �� -   5         ��Name$ ListDoc��5   %   $��0,82,0,0q�6   $��Disabled=�66   $��Center=�6l   $	��307��6�   ��5      �� 5       �� 
TargetType" ��6   .�5      -   5        5      ��5      �� 5      .R�5      ��  �� Orientation$ Vertical=�6!   .+�5      �� $��16(�6B   $
��Bold"�6P   ��6$   �� *EmployeeName+6P   �� 5      $��14(�6B   ��6$   �� *DocumentName+6B   �� 5      $�� ��6$   �� 5       ��Name$ 
OpenDocBtn��6<   -   5        $%��Открыть документ��5   !   6P   5      5       5"      �� 5#   
   -   5        	 ��Name$	 SearchButton��5#      )  #MaterialDesignThemes.Wpf.HintAssist
   Hint$
 Поиск по Ф.И.О��6O   $
��Left=�6   $��29��6�   $��	19,17,0,0q�6�    �� TextWrapping$
 Wrap=�6�   $	��Top=�6�   $	��129��6�   $��16(�6�   �� 5$   
   -   5        $��DocAddButton��5$   $   $��Добавить��6   $
��Left=�6T   $��29��6o   $��
174,17,0,0q�6{   $	��Top=�6�   $	��117��6�    J� RenderTransformOrigin$ 0.5,0.5&�6�   z�5%      V� 5&      .~�5'      �� �� 5(      �� 5)       �� Angle$ 0.274Q�6&   T� 5*      5+      5-      5/      50      