using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace FilmDB
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = new ViewModel();
            if (Properties.Settings.Default.MovieGenres != null)
            {
                foreach (var genre in Properties.Settings.Default.MovieGenres)
                {
                    FilterByGenre.Items.Add(genre);
                }
            }
            MovieRatingControl.RatingChanged += MovieRatingControl_RatingChanged;

        }

        private void IzhodItem_Click(object sender, RoutedEventArgs e)
        {
            if (sender is MenuItem)
            {
                if (MessageBox.Show("Ali res želite zapustiti aplikacijo?", "Izhod", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                {
                    Application.Current.Shutdown();
                }
            }
        }

        private void MoviesListView_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            var viewModel = DataContext as ViewModel;
            viewModel?.ShowMovieDetailsOnDoubleClick.Execute(null);
        }

        private void MovieRatingControl_RatingChanged(object sender, RatingChangedEventArgs e)
        {
            var viewModel = DataContext as ViewModel;
            if (viewModel?.SelectedMovie != null)
            {
                viewModel.SelectedMovie.Rating = e.NewRating;
            }
            else
            {
                MessageBox.Show("Napaka pri nastavljanju ocene filma. Niste izbrali nobenega filma!", "Napaka", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }

    /*
     * TextBox Name=TBDesck
     *
     * Textbox Text={Binding ElementName=TBDesck, Path=Text
     *
     *
     * Elementu v xaml das neko ime, potem pa v C# klices....[ime_elementa].DataContext = [ime_podatkovne_strukture]
     *
     */
}