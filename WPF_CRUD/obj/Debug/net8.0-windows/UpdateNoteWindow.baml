   M S B A M L   `   `   `  ����C  ?WPF_CRUD, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:WPF_CRUDWPF_CRUD  5   	       WPF_CRUD.UpdateNoteWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:WPF_CRUD     5   	     � Title$  CreateNoteWindow��5   	   $	��450��6"   $	��800��6/   .��5	      � 
������� � RowDefinitions 5
   
   �� 5      6   �� 5      6   �� 5      6   �� 5      6   �� 5      6   �� 5      6    � ColumnDefinitions 5   
   �� 5      6!   �� 5      6!   �� 5      6!   �� 5      6!   �� 5      6!   �� 5      6!   .+�5   
   �� $��24(�6   $��SemiBold"�6"   $��1��68   $��2��6H   $��Center=�6\   Update Note6�   �� 5   
   $��Title��6   $��1��6    $��1��6-   $	��top=�6=   $��14(�6U   $��0 4 0 0q�6c   $��SemiBold"�6t   6�   �� 5   
   -   5         ��Name$ NewNoteTitle_TextBox��5      $��1��60   $��1��6=   $��0 32 0 0q�6M   $��4��6_   $��1��6s   
�������
���   �5   :   �� 5   
   $��Category��6   $��2��6#   $��1��60   $	��top=�6@   $��14(�6X   $��0 4 0 0q�6f   $��SemiBold"�6w   6�   �� 5    
   -   5        $ NewNoteCategory_TextBox��5       $��2��63   $��1��6@   $��0 32 0 0q�6P   $��4��6b   $��1��6v   
�������
���   �5!   2   �� 5"   
   $��Content��6   $��3��6"   $��1��6/   $	��top=�6?   $��14(�6W   $��0 4 0 0q�6e   $��SemiBold"�6v   6�   �� 5#   
   -   5        $ NewNoteContent_TextBox��5#      $��3��62   $��1��6?   $��0 32 0 0q�6O   $��4��6a   $��2��6u   
�������
���   �5$   2   �� 5%   
   -   5         ��Name$ Close��5%      $
��Exit��6    $��20q�6/   $��3��6;   $��5��6K   $��Medium"�6X   
��� ���6�   �� 5&   
   -   5        $ Create��5&      $
��Save��6!   $��20q�60   $��4��6<   $��5��6L   $��Medium"�6Y   
��� � �6�   5'      5(      