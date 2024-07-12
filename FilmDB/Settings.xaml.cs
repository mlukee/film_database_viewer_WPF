using System.Windows;

namespace FilmDB
{
    /// <summary>
    /// Interaction logic for Settings.xaml
    /// </summary>
    public partial class Settings : Window
    {
        public Settings()
        {
            InitializeComponent();
            LoadGenresFromSettings();
        }

        private void LoadGenresFromSettings()
        {
            GenreListBox.Items.Clear();

            var genresCollection = Properties.Settings.Default.MovieGenres;
            if (genresCollection != null)
            {
                foreach (var genre in genresCollection)
                {
                    GenreListBox.Items.Add(genre);
                }
            }
        }

        private void AddGenreButton_Click(object sender, RoutedEventArgs e)
        {
            string newGenre = GenreInputTextBox.Text.Trim();
            if (!string.IsNullOrEmpty(newGenre))
            {
                if (Properties.Settings.Default.MovieGenres == null)
                {
                    Properties.Settings.Default.MovieGenres = new System.Collections.Specialized.StringCollection();
                }
                if (!Properties.Settings.Default.MovieGenres.Contains(newGenre))
                {
                    Properties.Settings.Default.MovieGenres.Add(newGenre);
                    SortAndUpdateGenresListBox();
                    GenreInputTextBox.Clear();
                }
            }
        }

        private void UpdateGenreButton_Click(object sender, RoutedEventArgs e)
        {
            if (GenreListBox.SelectedItem != null)
            {
                string updatedGenre = GenreInputTextBox.Text.Trim();
                if (!string.IsNullOrEmpty(updatedGenre) && !Properties.Settings.Default.MovieGenres.Contains(updatedGenre))
                {
                    int selectedIndex = GenreListBox.SelectedIndex;
                    // Update the genre directly in the StringCollection
                    Properties.Settings.Default.MovieGenres[selectedIndex] = updatedGenre;
                    SortAndUpdateGenresListBox(); // Sort and update the list
                    GenreInputTextBox.Clear();
                }
            }
        }

        private void RemoveGenreButton_Click(object sender, RoutedEventArgs e)
        {
            if (GenreListBox.SelectedItem != null)
            {
                int selectedIndex = GenreListBox.SelectedIndex;
                Properties.Settings.Default.MovieGenres.RemoveAt(selectedIndex);
                Properties.Settings.Default.Save();
                GenreListBox.Items.RemoveAt(selectedIndex);
                GenreInputTextBox.Clear();
            }
        }

        private void SortAndUpdateGenresListBox()
        {
            var genresCollection = Properties.Settings.Default.MovieGenres;

            var sortedGenres = genresCollection.Cast<string>().OrderBy(g => g).ToList();

            genresCollection.Clear();
            foreach (var genre in sortedGenres)
            {
                genresCollection.Add(genre);
            }

            Properties.Settings.Default.Save();

            // Now, update the ListBox
            GenreListBox.Items.Clear();
            foreach (var genre in sortedGenres)
            {
                GenreListBox.Items.Add(genre);
            }
        }
    }
}