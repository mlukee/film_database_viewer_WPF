using Microsoft.Win32;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Windows;
using System.Windows.Media.Imaging;

namespace FilmDB
{
    public partial class AddMovieWindow : Window
    {
        public Movie SelectedMovie { get; private set; }
        public ObservableCollection<string> Genres { get; set; }
        private string tempImagePath;

        public AddMovieWindow(ViewModel vm)
        {
            InitializeComponent();
            LoadGenres();

            if (vm == null) // Insert new Movie
            {
                Movie m = new Movie("", "", "", "/assets/imdblogo.png", "", 2000, 90, 0);
                DataContext = m;
                SelectedMovie = m;
                tempImagePath = m.ImagePath;
                MovieDuration.Clear();
                MovieReleaseYear.Clear();
                StackPanelModalButtons.Visibility = Visibility.Visible;
            }
            else // Update Movie
            {
                StackPanelNoneModalButtons.Visibility = Visibility.Visible;
                DataContext = vm;
                SelectedMovie = vm.SelectedMovie!;
                tempImagePath = SelectedMovie.ImagePath;
                vm.PropertyChanged += ViewModel_PropertyChanged;
                CheckMovieGenres(vm.SelectedMovie!.Genres);
            }

            MovieRatingControl.RatingChanged += MovieRatingControl_RatingChanged;
        }

        private void LoadGenres()
        {
            var genresCollection = Properties.Settings.Default.MovieGenres;

            if (genresCollection != null)
            {
                Genres = new ObservableCollection<string>(genresCollection.Cast<string>()
                                                                           .Select(genre => genre.Trim())
                                                                           .OrderBy(genre => genre));
                GenresListBox.ItemsSource = Genres;
            }
        }

        private void CheckMovieGenres(string genres)
        {
            if (string.IsNullOrEmpty(genres)) return;

            GenresListBox.SelectedItems.Clear();
            var selectedGenresArray = genres.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                                             .Select(g => g.Trim())
                                             .ToList();

            foreach (var genre in Genres)
            {
                if (selectedGenresArray.Contains(genre))
                {
                    var index = Genres.IndexOf(genre);
                    if (index != -1)
                    {
                        GenresListBox.SelectedItems.Add(GenresListBox.Items[index]);
                    }
                }
            }
        }

        private void Ok_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(MovieTitle.Text) ||
                    string.IsNullOrWhiteSpace(MovieActors.Text) ||
                    string.IsNullOrWhiteSpace(MovieDirector.Text) ||
                    string.IsNullOrWhiteSpace(MovieReleaseYear.Text) ||
                    string.IsNullOrWhiteSpace(MovieDuration.Text) ||
                    string.IsNullOrEmpty(tempImagePath) ||
                    GenresListBox.SelectedItems.Count == 0 ||
                    SelectedMovie.Rating == 0)
                {
                    MessageBox.Show("Vsa polja morajo biti izpolnjena.");
                    return;
                }

                var selectedGenres = GenresListBox.SelectedItems
                    .Cast<string>()
                    .Select(g => g.Trim())
                    .ToList();

                SelectedMovie.Title = MovieTitle.Text;
                SelectedMovie.Actors = MovieActors.Text;
                SelectedMovie.Genres = string.Join(", ", selectedGenres);
                SelectedMovie.ImagePath = tempImagePath;
                SelectedMovie.Director = MovieDirector.Text;
                SelectedMovie.ReleaseYear = int.Parse(MovieReleaseYear.Text);
                SelectedMovie.Duration = double.Parse(MovieDuration.Text);
                DialogResult = true;
            }
            catch (FormatException)
            {
                MessageBox.Show("Letnica izdaje in dolžina filma morata biti v pravilnem formatu.");
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Close_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Update_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(MovieTitle.Text) ||
                    string.IsNullOrWhiteSpace(MovieActors.Text) ||
                    string.IsNullOrWhiteSpace(MovieDirector.Text) ||
                    string.IsNullOrWhiteSpace(MovieReleaseYear.Text) ||
                    string.IsNullOrWhiteSpace(MovieDuration.Text) ||
                    string.IsNullOrEmpty(tempImagePath) ||
                    GenresListBox.SelectedItems.Count == 0 ||
                    SelectedMovie.Rating == 0)
                {
                    MessageBox.Show("Vsa polja morajo biti izpolnjena.");
                    return;
                }

                var selectedGenres = GenresListBox.SelectedItems
                    .Cast<string>()
                    .Select(g => g.Trim())
                    .ToList();

                SelectedMovie.Title = MovieTitle.Text;
                SelectedMovie.Actors = MovieActors.Text;
                SelectedMovie.Genres = string.Join(", ", selectedGenres);
                SelectedMovie.Director = MovieDirector.Text;
                SelectedMovie.ReleaseYear = int.Parse(MovieReleaseYear.Text);
                SelectedMovie.Duration = double.Parse(MovieDuration.Text);
                SelectedMovie.Rating = MovieRatingControl.Rating;
                SelectedMovie.ImagePath = tempImagePath;

     

                Close();
            }
            catch (FormatException)
            {
                MessageBox.Show("Letnica izdaje in dolžina filma morata biti v pravilnem formatu.");
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BrowseImage_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Image files (*.jpg;*.jpeg;*.png)|*.jpg;*.jpeg;*.png",
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures)
            };

            if (openFileDialog.ShowDialog() == true)
            {
                string sourceFilePath = openFileDialog.FileName;
                string fileName = Path.GetFileName(sourceFilePath);
                string uniqueFileName = $"{Path.GetFileNameWithoutExtension(fileName)}_{DateTime.Now:yyyyMMddHHmmssfff}{Path.GetExtension(fileName)}";
                string assetsDirectory = Path.Combine(Environment.CurrentDirectory, "assets");

                if (!Directory.Exists(assetsDirectory))
                {
                    Directory.CreateDirectory(assetsDirectory);
                }

                string destinationPath = Path.Combine(assetsDirectory, uniqueFileName);
                File.Copy(sourceFilePath, destinationPath, true);
                tempImagePath = destinationPath;
                MovieImage.Source = new BitmapImage(new Uri(tempImagePath, UriKind.Absolute));
            }
        }

        private void ViewModel_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == nameof(ViewModel.SelectedMovie))
            {
                SelectedMovie = ((ViewModel)DataContext).SelectedMovie;
                CheckMovieGenres(SelectedMovie?.Genres);
            }
        }

        private void MovieRatingControl_RatingChanged(object sender, RatingChangedEventArgs e)
        {
            if (DataContext is Movie movie)
            {
                movie.Rating = e.NewRating;
                Debug.WriteLine($"Rating updated to: {movie.Rating}");
            }
        }
    }
}
