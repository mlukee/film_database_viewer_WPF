using System.ComponentModel;

namespace FilmDB
{
    [Serializable]
    public class Movie : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        private string title;
        private string actors;
        private string genres;
        private string imagePath;
        private string director;
        private bool isfavourite = false;
        private int releaseYear;
        private double duration; // Dolžina filma v minutah
        private int rating;

        public Movie()
        {
        }

        public Movie(string title, string actors, string genres, string imagePath, string director, int releaseYear, double duration, int rating)
            : this() // Call the parameterless constructor to ensure any defaults it sets are applied
        {
            Title = title;
            Actors = actors;
            Genres = genres;
            ImagePath = imagePath;
            Director = director;
            ReleaseYear = releaseYear;
            Duration = duration;
            Rating = rating;
        }

        public string Title
        {
            get => title;
            set
            {
                title = value;
                OnPropertyChanged(nameof(Title));
            }
        }

        public string Actors
        {
            get => actors;
            set
            {
                actors = value;
                OnPropertyChanged(nameof(Actors));
            }
        }

        public string Genres
        {
            get => genres;
            set
            {
                genres = value;
                OnPropertyChanged(nameof(Genres));
            }
        }

        public string ImagePath
        {
            get => imagePath;
            set
            {
                imagePath = value;
                OnPropertyChanged(nameof(ImagePath));
            }
        }

        public bool IsFavourite
        {
            get => isfavourite;
            set
            {
                isfavourite = value;
                OnPropertyChanged(nameof(IsFavourite));
            }
        }

        public string Director
        {
            get => director;
            set
            {
                director = value;
                OnPropertyChanged(nameof(Director));
            }
        }

        public int ReleaseYear
        {
            get => releaseYear;
            set
            {
                // https://www.studiobinder.com/blog/what-was-the-first-movie-ever-made/ [18.3.2024]
                if (value < 1878) // Leto izdaje prvega filma
                {
                    throw new ArgumentException("Letnica izdaje filma ni veljavna.");
                }
                releaseYear = value;
                OnPropertyChanged(nameof(ReleaseYear));
            }
        }

        public double Duration
        {
            get => duration;
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Dolžina filma mora biti večja od 0.");
                }
                duration = value;
                OnPropertyChanged(nameof(Duration));
            }
        }

        public int Rating
        {
            get => rating;
            set
            {
                rating = value;
                OnPropertyChanged(nameof(Rating));
            }
        }

        public override string ToString()
        {
            return $"{Title} Released:{ReleaseYear}, Actors: {Actors} , ...";
        }

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}