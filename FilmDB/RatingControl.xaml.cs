using System;
using System.Windows;
using System.Windows.Controls;

namespace FilmDB
{
    public partial class RatingControl : UserControl
    {
        public static readonly DependencyProperty RatingProperty =
            DependencyProperty.Register("Rating", typeof(int), typeof(RatingControl), new PropertyMetadata(0, OnRatingChanged));

        public int Rating
        {
            get { return (int)GetValue(RatingProperty); }
            set { SetValue(RatingProperty, value); }
        }

        public RatingControl()
        {
            InitializeComponent();
        }

        private static void OnRatingChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var control = d as RatingControl;
            control?.UpdateRating((int)e.NewValue);
        }

        private void RatingComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (RatingComboBox.SelectedItem is ComboBoxItem selectedItem)
            {
                Rating = int.Parse(selectedItem.Content.ToString());
                RatingChanged?.Invoke(this, new RatingChangedEventArgs(Rating));
            }
        }

        private void UpdateRating(int rating)
        {
            foreach (ComboBoxItem item in RatingComboBox.Items)
            {
                if (int.Parse(item.Content.ToString()) == rating)
                {
                    RatingComboBox.SelectedItem = item;
                    break;
                }
            }
        }

        public event EventHandler<RatingChangedEventArgs> RatingChanged;
    }

    public class RatingChangedEventArgs : EventArgs
    {
        public int NewRating { get; }

        public RatingChangedEventArgs(int newRating)
        {
            NewRating = newRating;
        }
    }
}
