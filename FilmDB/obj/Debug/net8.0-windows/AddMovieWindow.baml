   M S B A M L   `   `   `  ����A  =FilmDB, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:FilmDBFilmDB  5   	       FilmDB.AddMovieWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   &localclr-namespace:FilmDB     5   	     � Title$  AddMovieWindow��5   	    � SizeToContent$ WidthAndHeight=�6     � 
ResizeMode$ NoResize=�6?    � WindowStartupLocation$ CenterOwner=�6U   .��5	      ��  �� Orientation$ Vertical=�6   .+�5
   
   �� $ 
Horizontal=�6   $��10q�6.   .+�5      �� $��Title: ��6   $	��100��6&   �� 5      -   5         ��Name$ 
MovieTitle��5      $	��200��6*   ��66   �� *SelectedMovie.Title+ �� Mode$ OneWay=�5      �� 5   
   $ 
Horizontal=�6   $��10q�6.   .+�5      �� $��Actors: ��6   $	��100��6'   �� 5      -   5        $ MovieActors��5      $	��200��6+   ��67   �� *SelectedMovie.Actors+$ OneWay=�5      �� 5   
   $ 
Horizontal=�6   $��10q�6.   .+�5      �� $��Genres: ��6   $	��100��6'   �� 5      -   5         ��Name$ GenresListBox��5      $	��200��6-   $	��100��69   $
��Auto=�6F    �� SelectionMode$ Multiple=�6v   5      �� 5   
   $ 
Horizontal=�6   $��10q�6.   .+�5      �� $��
Director: ��6   $	��100��6)   �� 5      -   5        $ MovieDirector��5      $	��200��6-   ��69   �� *SelectedMovie.Director+$ OneWay=�5      �� 5   
   $ 
Horizontal=�6   $��10q�6.   .+�5      �� $��Release Year: ��6   $	��100��6-   �� 5      -   5        $ MovieReleaseYear��5      $	��200��60   ��6<   �� *SelectedMovie.ReleaseYear+$ OneWay=�5      �� 5   
   $ 
Horizontal=�6   $��10q�6.   .+�5      �� $��
Duration: ��6   $	��100��6)   �� 5       -   5        $ MovieDuration��5       $	��200��6-   ��69   �� *SelectedMovie.Duration+$ OneWay=�5!      �� 5"   
   $ 
Horizontal=�6   $��Stretch=�6.   $��10q�6L   .+�5#      �� $��Movie Picture: ��6   $	��100��6.   $��Center=�6:   �� 5$      -   5        $ MovieImagePath��5$      $	��200��6.   	 �� 
IsReadOnly$
	 True��6:   $y�	Collapsed=�6�   ��6L   �� *SelectedMovie.ImagePath+
 �� UpdateSourceTrigger$
 PropertyChanged=�6�   �� 5%      -   5         ��Name$ 
MovieImage��5%      $��80��6(   $��80��63   $��Uniform=�6�   ��6?   �� *SelectedMovie.ImagePath+$
 PropertyChanged=�6�   �� 5&      -	   5        $��	Browse...��5&      $��Center=�6C   $��10,0,0,0q�6_   5'      �� 5(   
   $ 
Horizontal=�6   $��Center=�6.   $��10q�6I   .+�5*         FilmDB.RatingControl  -
   5          Name$ MovieRatingControl��5*   "   $
��Left=�6>   $��Center=�6Y      Rating 6t   �� *SelectedMovie.Rating+5+      �� 5,   
   -   5        $��StackPanelModalButtons��5,      $y�	Collapsed=�63   $ 
Horizontal=�6J   $��10q�6c   $��Right=�6o   .+�5-      �� -   5        $��OK��5-      $	��100��6"   $��0 0 10 0q�6.    �� 	IsDefault$
 True��6Q   �� 5.      $��Cancel��6   $	��100��6&    �� IsCancel$
 True��62   5/      �� 50   
   -   5        $ ��StackPanelNoneModalButtons��50      $y�	Collapsed=�67   $ 
Horizontal=�6N   $��10q�6g   $��Right=�6s   .+�51      �� -   5        $��Close��51      $	��100��6%   61   �� 52      -   5        $��Update��52      $	��100��6&   62   53      54      55      