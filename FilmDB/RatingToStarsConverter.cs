using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Media.Imaging;

namespace FilmDB
{
    public class RatingToStarsConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is int rating)
            {
                var stars = new List<BitmapImage>();
                for (int i = 1; i <= 5; i++)
                {
                    var uri = i <= rating
                        ? new Uri("pack://application:,,,/assets/icons/filled_star_icon.png")
                        : new Uri("pack://application:,,,/assets/icons/star_icon.png");

                    stars.Add(new BitmapImage(uri));
                }
                return stars;
            }
            return null;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
