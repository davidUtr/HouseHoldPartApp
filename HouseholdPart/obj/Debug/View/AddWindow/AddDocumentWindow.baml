   M S B A M L   `   `   `  ����H  DHouseHoldPart, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullK*clr-namespace:HouseHoldPart.View.AddWindowHouseHoldPart.View.AddWindow  5   	   4    .HouseHoldPart.View.AddWindow.AddDocumentWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   <local*clr-namespace:HouseHoldPart.View.AddWindow     5   	   _ [MaterialDesignThemes.Wpf, Version=4.9.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	     � Title$'  !ДобавитЬ документ��5	   	   $	��417��6#   $	��262��60    � 
ResizeMode$ CanMinimize=�6<   .��5
      � .+�5   
   �� -   5         ��Name$ documentIdText��5   /   $��Center=�6   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$	 №��6G   $��29��6j   $��0,40,0,0q�6v    �� TextWrapping$
 Wrap=�6�   $	��Top=�6�   $��31��6�   $��16(�6�   �� 5   
   -   5        $ documentNameText��5   /   $��Center=�6   $) #Название документа��6I   $��29��6}   $��0,96,0,0q�6�   $
 Wrap=�6�   $	��Top=�6�   $	��167��6�   $��16(�6�   �� 5   
   -   5         ��Name$ EmployeeName��5   0   $��Center=�6    �� SelectedValuePath$ 
EmployeeId��6H   $ Сотрудник��6�   $��34��6�   $��	0,149,0,0q�6�   $	��Top=�6�   $	��166��6�   $��16(�6�    �� SelectedValue 6g   �� *
EmployeeId+��5      �� 5      .R�5      ��  �� Orientation$ 
Horizontal=�6!   .+�5      �� ��6$   �� *NameEmployee+�� 5      $�� ��6$   �� 5      ��6$   �� *SurnameEmployee+5      5      5      �� 5   
   -   5        	 ��Name$	 AttachDocumentButton��5   /   $+��%Прикрепить документ��6   $��Center=�6p   $��33��6�   $��	0,225,0,0q�6�   $	��Top=�6�   $	��190��6�   �� 5   
   -   5        $	 
SaveButton��5   [   $��Сохранить��6   $��Center=�6%   $��30��6o   $��	0,314,0,0q�6{   $	��Top=�6�   $	��121��6�   �� 5   
   -   5        
 ��Name$
 addedDocumentPanel��5   ,   $y�	Collapsed=�6   $ 
Horizontal=�6H   $
��Left=�6a   $	��Top=�6|   $��
42,263,0,0q�6�   $	��172��6�   .+�5      �� -   5         ��Name$ addedDocumentName��5      $�� ��63   $��Center=�6;   $	��100��6V   �� 5      -   5        $��X��5      $��5,0,0,0q�6!   ���	#FFF12323���	#FFF12323$��25��6�   $��41��6�   $��12(�6�   5      5      5      