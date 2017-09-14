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
    /// Interaction logic for Buttons.xaml
    /// </summary>
    public partial class Buttons : UserControl
    {
        public Buttons()
        {
            InitializeComponent();
        }

        void OnClick1(object sender, RoutedEventArgs e)
        {
            button1.Foreground = new SolidColorBrush(Colors.Blue);

            Status_Text.Text = "On Hover click event occurs.";
        }

        void OnClick2(object sender, RoutedEventArgs e)
        {
            button2.Foreground = new SolidColorBrush(Colors.Green);
            Status_Text.Text = "On Press click event occurs.";
        }

        void OnClick3(object sender, RoutedEventArgs e)
        {
            button1.Foreground = new SolidColorBrush(Colors.Green);
            button2.Foreground = new SolidColorBrush(Colors.Blue);
            Status_Text.Text = "On Release click event occurs.";
        }

        void OnDragOver(object sender, DragEventArgs e)
        {
            button4.Background = new SolidColorBrush(Colors.AliceBlue);
            Status_Text.Text = "On Drag Over";
        }

        private void OnDrop(object sender, DragEventArgs e)
        {
            button5.Background = new SolidColorBrush(Colors.AliceBlue);
            Status_Text.Text = "On Drop";
        }

        private void OnMouseEnter(object sender, MouseEventArgs e)
        {
            Mouse.OverrideCursor = Cursors.Wait;
            button5.Background = new SolidColorBrush(Colors.AliceBlue);
            Status_Text.Text = "On Mouse Enter";
        }

        private void OnMouseLeave(object sender, MouseEventArgs e)
        {
            Mouse.OverrideCursor = Cursors.Arrow;
            button5.Background = new SolidColorBrush(Colors.AliceBlue);
            Status_Text.Text = "On Mouse Leave";
            
        }


    }
}
