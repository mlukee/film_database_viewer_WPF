using Microsoft.Win32;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Windows;
using System.Windows.Input;
using System.Xml.Serialization;

namespace FilmDB
{
    public class ViewModel : INotifyPropertyChanged
    {
        public ViewModel()
        {
            MovieList = new ObservableCollection<Movie>();
            MovieList.Add(new Movie("Kung Fu Panda 4", "Jack Black, Angelina Jolie, Dustin Hoffman", "Animation, Action, Comedy", "assets/imdblogo.png", "Jennifer Yuh Nelson", 2024, 95,4));

            MovieList.Add(new Movie("Kung Fu Panda 3",
            "Jack Black, Bryan Cranston, Dustin Hoffman",
                 "Animation, Action, Adventure",
                 "assets/imdblogo.png",
                "Alessandro Carloni",
                 2016,
                95,
                5
            ));

            MovieList.Add(new Movie("Kung Fu Panda 2", "Jack Black, Gary Oldman, Angelina Jolie",
                "Animation, Action, Adventure",
                 "assets/imdblogo.png",
                 "Jennifer Yuh Nelson",
                 2011,
                 90,
                 4
            ));

            MovieList.Add(new Movie("Kung Fu Panda 2", "Jack Black, Gary Oldman, Angelina Jolie",
                "Animation, Action, Adventure",
                 "assets/imdblogo.png",
                 "Jennifer Yuh Nelson",
                 2011,
                 90,
                 3
            ));

            TestCommand = new Command((obj) => { MessageBox.Show("AddElement executed"); });
            AddMovie = new Command(AddMovieCallback);
            DeleteMovie = new Command(DeleteMovieCallback);
            EditMovie = new Command(EditMovieCallback);
            FavouriteMovie = new Command(FavoriteMovieCallback);
            ExportMovies = new Command(ExportMoviesCallback);
            ImportMovies = new Command(ImportMoviesCallback);
            OpenSettingsWindow = new Command(OpenSettingsWindowCallback);
            ShowMovieDetailsOnDoubleClick = new Command(ShowMovieOnDoubleClick);
        }

        public ICommand TestCommand { get; private set; }
        public ICommand AddMovie { get; private set; }

        public ICommand DeleteMovie { get; private set; }

        public ICommand FavouriteMovie { get; private set; }

        public ICommand ShowMovieDetailsOnDoubleClick { get; private set; }

        public ICommand EditMovie { get; private set; }

        public ICommand ExportMovies { get; private set; }
        public ICommand ImportMovies { get; private set; }
        public ICommand OpenSettingsWindow { get; private set; }

        //public void AddElementCallback(object? obj)
        //{
        //    MessageBox.Show("AddElement executed");

        //    // v xaml namesto Click uporabis Command="{Binding TestCommand}"
        //}

        public event PropertyChangedEventHandler? PropertyChanged;

        public Movie? SelectedMovie
        {
            get { return selectedMovie; }
            set
            {
                selectedMovie = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(SelectedMovie)));
            }
        }

        private Movie? selectedMovie = null;

        public ObservableCollection<Movie> MovieList { get; private set; }
        public ObservableCollection<string> Genres { get; set; }
        public ObservableCollection<string> SelectedGenres { get; set; }

        public void AddMovieCallback(object? obj)
        {
            //var Movie = new Movie("Deadpool", "Actor`1", "Comedy, Action", "assets/imdblogo.png", "Director RAND", 2014, 94);
            //MovieList.Add(Movie);
            var wnd = new AddMovieWindow(null);
            //Tukaj se program ustaavi dokler se ne zapre okno
            if (wnd.ShowDialog() == true && wnd.SelectedMovie != null) // Movie dodas v seznam
            {
                //MessageBox.Show("AddMovie executed");
                MovieList.Add(wnd.SelectedMovie);
            }

            // v xaml namesto Click uporabis Command="{Binding TestCommand}"
        }

        private void OpenSettingsWindowCallback(object? obj)
        {
            if (settingsWindow != null) { return; }

            settingsWindow = new Settings();
            settingsWindow.Owner = Application.Current.MainWindow;

            settingsWindow.Closed += (sender, e) => settingsWindow = null;
            settingsWindow.ShowDialog();
        }

        public void DeleteMovieCallback(object? obj)
        {
            if (SelectedMovie != null)
            {
                if (MessageBox.Show("Are you sure you want to delete this movie?", "Delete movie", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                {
                    MovieList.Remove(SelectedMovie);
                    SelectedMovie = null;
                }
            }
            else
            {
                MessageBox.Show("No movie selected", "Delete movie", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        public void ShowMovieOnDoubleClick(object? obj)
        {
            if (SelectedMovie != null)
            {
                MessageBox.Show(SelectedMovie.ToString(), "Izbor filma");
            }
        }

        private AddMovieWindow? addMovieWindow = null;
        private Settings? settingsWindow = null;

        public void EditMovieCallback(object? obj)
        {
            if (SelectedMovie != null)
            {
                if (addMovieWindow != null) { return; }

                addMovieWindow = new AddMovieWindow(this);
                addMovieWindow.Owner = Application.Current.MainWindow;

                addMovieWindow.Closed += (sender, e) => addMovieWindow = null;
                addMovieWindow.Show();
            }
            else
            {
                MessageBox.Show("No movie selected", "Edit movie", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        private void FavoriteMovieCallback(object? obj)
        {
            if (SelectedMovie != null)
            {
                SelectedMovie.IsFavourite = !SelectedMovie.IsFavourite;
                SelectedMovie = null;
            }
        }

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private void ImportMoviesCallback(object? obj)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "XML files (*.xml)|*.xml",
                Title = "Import XML File"
            };

            if (openFileDialog.ShowDialog() == true)
            {
                using (var sr = new StreamReader(openFileDialog.FileName))
                {
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(ObservableCollection<Movie>));
                    if (xmlSerializer.Deserialize(sr) is ObservableCollection<Movie> movies)
                    {
                        MovieList.Clear();
                        foreach (var movie in movies)
                        {
                            MovieList.Add(movie);
                        }
                    }
                }
            }
        }

        private void ExportMoviesCallback(object? obj)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "XML files (*.xml)|*.xml",
                Title = "Export as XML File"
            };

            if (saveFileDialog.ShowDialog() == true)
            {
                using (var sw = new StreamWriter(saveFileDialog.FileName))
                {
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(ObservableCollection<Movie>));
                    xmlSerializer.Serialize(sw, MovieList);
                }
            }
        }
    }
}