   M S B A M L   `   `   `  ����A  =FilmDB, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:FilmDBFilmDB  5   	       FilmDB.MainWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   &localclr-namespace:FilmDB     5   	     � Title$  
MainWindow��5   	   $	��700��6   $
��1250��6,    � 	Resources 5	      #   FilmDB.RatingToStarsConverter   RatingToStarsConverter��%   &	          5
   
   6'   5      .��5      ]� .+�5   
   o� $	��Top=�6   $	��Top=�6$   .@�5      m� $��Datoteka��6   .@�5      m� -   5        $��Izhod��5      6*   m� 5      $��Uvozi��6    m� Command 6*   �� *ImportMovies+m� 5      $��Izvozi��6    6+   �� *ExportMovies+5      m� 5      $��Filmi��6   .@�5      m� $��Dodaj��6    6*   �� *
AddMovie+m� 5      $��Odstrani��6    6-   �� *DeleteMovie+m� 5      $��Uredi��6    6*   �� *	EditMovie+5      m� 5      $��Orodja��6   .@�5      m� $��
Nastavitve��6    6/   �� *OpenSettingsWindow+5      5      �� 5   
   $��Bottom=�6   .@�5      �� -   5         ��Name$ statusBarItem��5      $��Ready��63   5       �� 5"   
   $	��Top=�6    �� Orientation$ 
Horizontal=�6*   $	��Top=�6C   .+�5#      �� $��assets/imdblogo.png��6   $��50��61   $��	10,0,10,0q�6=   �� 5$      $ 
Horizontal=�6   $��0,0,10,0q�62   .+�5%      �� $	��5,0q�6   $	��200��6'   $��Center=�63   $��Search for movies...��6N   �� 5&      $"��assets/icons/search_icon.png��6   $��20��6>   $��20��6I   $��Center=�6U   5'      �� 5)      -   5         ��Name$ FilterByGenre��5)      $	��5,0q�6.   $	��150��6;   $��Center=�6G    �� SelectedIndex$ 0��6b   .@�5*      �� $��Select Genre��6   ${�False��66   5+      5,      � 5.   
    � ColumnDefinitions 5/      �� 50      $��* �6#   �� 51      $��2* �6#    � RowDefinitions 53      �� 54      $��* �6    �� 56      $
��Auto �6    .+�59      �� -   5        	 ��Name$	 MoviesListView��59      $��0��6Q   ��6/   �� *	MovieList+
 �� SelectedItem
 6a   �� *SelectedMovie+��5:      �� 5;      .R�5=      ��  ��Name$ Border��6!    �� Padding$ 10q�61   
������ ._�5>      �� $ 
Horizontal=�6)   $��10q�6B   .+�5?   "   �� $��50��6E   $��50��6P   $��5q�6\   ��6(   �� *	ImagePath+6\   �� 5@   "   $ Vertical=�6-   $��10q�6D   .+�5A   &   �� $
��Bold"�6G   ��60   �� *Title+6G   �� 5B   &   $��Italic$�6J   ��60   �� *
Director+6J   �� 5C   &   $ 
Horizontal=�61   .+�5D   *   �� $��	Released:��60   $
��Bold"�6D   �� 5E   *   $��Center=�6Q   ��64   �� *ReleaseYear+6Q   5F   '   �� 5G   &   $ 
Horizontal=�61   .+�5H   *   �� $��	Duration:��60   $
��Bold"�6D   �� 5I   *   $��Center=�6N   ��64   �� *
Duration+6N   �� 5J   *   $
�� min��60   5K   '   �� 5L   &   $ 
Horizontal=�61   .+�5M   *   �� $��Actors:��60   $
��Bold"�6B   �� 5N   *   $��Center=�6L   ��64   �� *Actors+6L   5O   '   �� 5P   &   $ 
Horizontal=�61   .+�5Q   *   �� $��Genres:��60   $
��Bold"�6B   �� 5R   *   $��Center=�6L   ��64   �� *Genres+6L   5S   '   �� 5T   &   $ 
Horizontal=�61   .+�5U   *   �� $��Rating:��60   $
��Bold"�6B   �� 5V   *   ��67   �� *Rating+ �� 	Converter# [  ��5W   .   �� 5X   2   .R�5Y   6   �� $ 
Horizontal=�6A   5Z   3   ��5\   .   �� 5]   2   .R�5^   6   �� $��20��6O   $��20��6Z   $��2q�6f   ��6<   �� 6f   5_   3   5a   +   5b   '   5c   #   5d      5e       �� Triggers 5f      �� 5g       �� Value$
 True��6J    �� Binding 6*   �� *IsFavourite+.a�5i   "   ��  �� 
TargetName$ Border��6)    �� Property � �� �� Value
 �����6S   5j      5l      5n      � 5q      $��1��6   $��10q�6#    5r      �� 5s      $
��Auto �6$   �� 5t      $��* �6$   �� 5u      $
��Auto �6$   .+�5w      �� $��1��6   .+�5x      �� $
��Bold"�6D   $��18(�6V   $��Center=�6d   ��6   �� *SelectedMovie.Title+6d   �� 5y      $	��150��6G   $	��150��6T   $��0��6`   $
��Left=�6m   ��6   �� *SelectedMovie.ImagePath+6m   �� 5z      $ 
Horizontal=�6!   .+�5{      �� $��	Director:��6    $
��Bold"�64   �� 5|      $��Italic$�6K   ��6    �� *SelectedMovie.Director+6K   5}      �� 5~      $ 
Horizontal=�6!   .+�5      �� $��	Released:��6    $
��Bold"�64   �� 5�      ��6    �� *SelectedMovie.ReleaseYear+5�      �� 5�      $ 
Horizontal=�6!   .+�5�      �� $��	Duration:��6    $
��Bold"�64   �� 5�      $��Center=�6L   ��6$   �� *SelectedMovie.Duration+6L   �� 5�      $
�� min��6    5�      �� 5�      $ 
Horizontal=�6!   .+�5�      �� $��Actors:��6    $
��Bold"�62   �� 5�      $��Center=�6J   ��6$   �� *SelectedMovie.Actors+6J   5�      �� 5�      $ 
Horizontal=�6!   .+�5�      �� $��Genres:��6    $
��Bold"�62   �� 5�      $��Center=�6J   ��6$   �� *SelectedMovie.Genres+6J   5�      �� 5�      $ 
Horizontal=�6!   .+�5�      �� $��Rating:��6    $
��Bold"�62   �� 5�      ��6'   �� *SelectedMovie.Rating+# [  ��5�      �� 5�   "   .R�5�   &   �� $ 
Horizontal=�61   5�   #   ��5�      �� 5�   "   .R�5�   &   �� $��20��6?   $��20��6J   $��2q�6V   ��6,   �� 6V   5�   #   5�      5�      5�      5�      �� 5�      $��2��6   $��5q�6"   $
��Left=�6-   ��6H   �� *FavouriteMovie+.��5�      �� $ 
Horizontal=�6   $��Center=�66   $��Center=�6Q   .+�5�      �� $ ��assets/icons/like_icon.png��6   $��15��6@   $��15��6K   �� 5�      -   5         ��Name$ FavouriteMovieBtnTxt��5�       $��Add to Favorites��6>   $��Center=�6V   $��Center=�6q   $��2,0,0,0q�6�   5�      5�         FilmDB.RatingControl  5�      -   5          Name$ MovieRatingControl��5�   "   $��2��6>   $��5q�6K   $	��100��6V   $��Right=�6b      Rating 6~   �� *SelectedMovie.Rating+ �� Mode$ TwoWay=�5�      5�      5�      