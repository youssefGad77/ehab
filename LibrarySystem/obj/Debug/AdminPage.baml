   M S B A M L   `   `   `  ����H  DLibrarySystem, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:LibrarySystemLibrarySystem  5          LibrarySystem.AdminPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      -localclr-namespace:LibrarySystem     5        N� Title$  	AdminPage��5	       N� 
Background
 �����.��5      �  � RowDefinitions 5   
   �� 5      �� 5      �� 5      .+�5   
   �� $��
Admin Page��6   $��33(�6%   $��Arial Rounded MT Bold)�63   $��279,0,279,97q�6V   �� 5   
   $��	Book ID :��6   $��22(�6$   $
��Bold"�62   $��31,69,636,28q�6D   �� 5   
   -   5        $��txtId��5      $��31��6   $��144,79,458,40q�6+   �� 5   
   $��Title :��6   $��22(�6"   $
��Bold"�60   $��371,73,296,24q�6B   �� 5   
   -   5        $��txtTitle��5      $��31��6"   $��453,84,149,35q�6.   �� 5   
   $��Author :��6   $��22(�6#   $
��Bold"�61   $��31,146,636,101q�6C   $��2��6[   �� 5   
   -   5        $��	txtAuthor��5      $��31��6#   $��144,4,458,115q�6/   $��1��6F   �� 5   
   $��Genre :��6   $��22(�6"   $
��Bold"�60   $��367,147,300,100q�6B   $��2��6[   �� 5   
   -   5        $��txtGenre��5      $��31��6"   $��453,8,149,111q�6.   $��1��6E   �� 5   
   $��Availability :��6   $��22(�6)   $
��Bold"�67   $��19,60,636,37q�6I   $��1��6_   �� 5   
   -   5        $��txtAvailable��5      $��31��6&   $��171,68,431,51q�62   $��1��6I   �� 5   
   -   5        $	��Add��5      $��20(�6   $
��Bold"�6-   
���   �
�������$��438,68,279,40q�6f   $��1��6}   6�   �� 5   
   -   5        $��Delete��5      $��20(�6"   $
��Bold"�60   
���   �
�������$��526,68,180,40q�6i   $��1��6�   6�   �� 5   
   -   5        $��Update��5      $��20(�6"   $
��Bold"�60   
���   �
�������$��625,68,81,40q�6i   $��1��6   6�   &   System.Windows.Controls.DataGrid  5   
   -	   5        $��BooksDataGrid��5      $��1��6(   $��	0,129,0,0q�65   $��2��6H   5       5!      