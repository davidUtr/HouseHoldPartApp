   M S B A M L   `   `   `  ����H  DHouseHoldPart, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:HouseHoldPart.ViewHouseHoldPart.View  5   	   $    HouseHoldPart.View.EntryWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:HouseHoldPart.View     5   	   _ [MaterialDesignThemes.Wpf, Version=4.9.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   -   5          � Title$  Авторизация��5
   	   $	��534��64   $	��510��6A    � 
ResizeMode$ CanMinimize=�6M    � WindowStartupLocation$ CenterScreen=�6f    � Icon$ /Icon/children.ico��6�   .��5      � .+�5   
   �� $
��Left=�6   $	��127��6+   $��
167,59,0,0q�68   $	��Top=�6L   $	��126��6d   �� 5   
   $
��Left=�6   $	��135��6+   $��
188,24,0,0q�68   $	��Top=�6L   $	��144��6d   $��/Icon/children.png��6p   �� 5   
   -   5        $��	LoginText��5      $��Center=�6$   $��44��6A   $��	0,241,0,0q�6M    �� TextWrapping$
 Wrap=�6`   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ 
Логин��6t   $	��Top=�6�   $	��348��6�   $��24(�6�   �� 5   
   -   5         ��Name$ TextPasswordInput��5   R   $y�Hidden=�6   $ Пароль��6'   $��Center=�6m   $��47��6�   $��	0,320,0,0q�6�   $	��Top=�6�   $	��348��6�   $��24(�6�   G� 5   
   -   5         G�Name$ PasswordInput��5   p   $ Пароль��6F   $��Center=�6�   $��48��6�   $��	0,320,0,0q�6�   $	��Top=�6�   $	��348��6�   $��24(�6�   �� 5   
   -   5         ��Name$ LoginButton��5      $��
Войти��6@   $��Center=�6P   $��46��6m   $��	0,425,0,0q�6y   $	��Top=�6�   $	��161��6�   �� 5   
   -   5        	 ��Name$	 SavePass��5   .   $%��Запомнить пароль��6   $
��Left=�6@   $��33��6[   $��
61,373,0,0q�6g   $	��Top=�6{   $	��187��6�   $��18(�6�   
�������
�������6�   d� 5   
   -   5        
 d�Name$
 PasswordCheck��5   ?   $
��Left=�6   $��24��63   $	��Top=�6�   $��48��6�   $��371,332,0,0q�6�   �� 5   
   -   5         � Cursor$
 Hand��5      $
��Left=�6:   $��33��6U   $��351,432,0,0q�6a   $	��Top=�6v   $��35��6�   $��/Icon/helpinfo_104306.png��6�    J� RenderTransformOrigin$ 0.432,0.516&�6�    J� Opacity$	 0.6Q�6�   5      5      