   M S B A M L   `   `   `  ����C  ?WPF_CRUD, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:WPF_CRUDWPF_CRUD  5   	       WPF_CRUD.MainWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:WPF_CRUD     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5
      � 
������� � RowDefinitions 5   
   �� 5      6   �� 5      6   �� 5      6   �� 5      6   �� 5      6   �� 5      6    � ColumnDefinitions 5   
   �� 5      6!   �� 5      6!   �� 5      6!   �� 5      6!   �� 5      6!   �� 5      6!   .+�5   
   �� $��24(�6   $��SemiBold"�6"   $��2��68   $��2��6H   $��Center=�6\   $��Center=�6y   Notes6�   �� 5   
   -   5         ��Name$ Note_ListView��5      $��2��6*   $��0��67   $��6��6G   $��20q�6[   $��4��6g    �� View 5      �� 5      .P�5       �� $��Title��6%    �� Width$	 100��6[    �� DisplayMemberBinding 64   �� *Title+6[   �� 5!      $��Content��6%   $	 200��6_    66   �� *	Content+6_   �� 5"      $��Category��6%   $	 100��6a    67   �� *
Category+6a   �� 5#      $��CreationDate��6%   $	 180��6i    6;   �� *CreationDate+6i   �� 5$      $��ModificationDate��6%   $	 180��6q    6?   �� *ModificationDate+6q   5%      5'      �� 5(   
   -   5         ��Name$ NoteCreate_Button��5(      $��1��6,   $��1��69   $��Medium"�6I   $��Create note��6]   $��20q�6s   
�������6�   �� 5)   
   -   5        $ NoteRead_Button��5)      $��1��6*   $��2��67   $��Medium"�6G   $��	Read note��6[   $��20q�6o   
�������6�   �� 5*   
   -   5        $ NoteUpdate_Button��5*      $��1��6,   $��3��69   $��Medium"�6I   $��Update note��6]   $��20q�6s   
�������6�   �� 5+   
   -   5        $ NoteDelete_Button��5+      $��1��6,   $��4��69   $��Medium"�6I   $��Delete note��6]   $��20q�6s   
�������6�   �� 5,   
   $��8(�6   $��SemiBold"�6!   $��5��67   $��5��6G   $��4q�6T   $��Right=�6_   $��Bottom=�6{   Patryk Penczek6�   5-      5.      