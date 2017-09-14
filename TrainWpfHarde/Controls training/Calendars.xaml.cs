using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TrainWpfHarde
{
    /// <summary>
    /// Interaction logic for Calendars.xaml
    /// </summary>
    public partial class Calendars : UserControl
    {
        public Calendars()
        {
            InitializeComponent();
        }

        private void Calendar_SelectedDatesChanged(object sender, SelectionChangedEventArgs e)
        {
            var calendar = sender as Calendar;

            // ... See if a date is selected. 

            if (calendar.SelectedDate.HasValue)
            {
                // ... Display SelectedDate in Title. 
                DateTime date = calendar.SelectedDate.Value;
                Status_Text.Text = date.ToShortDateString();
            }
        }

        private void Calendar_MouseLeave(object sender, MouseEventArgs e)
        {
            calendar1.Background = new SolidColorBrush(Colors.Red);
        }
    }
}
