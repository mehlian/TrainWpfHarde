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
    /// Interaction logic for TextBoxes.xaml
    /// </summary>
    public partial class TextBoxes : UserControl
    {
        private string[] selectionItems = new string[] { "FireBird", "Asswe", "Ssak", "Kij" };
        public TextBoxes()
        {
            InitializeComponent();

        }

        //TODO: Sugestie podczas pisania
        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

            //var autoSuggestBox = (TextBox)sender;
            //var filter = selectionItems.Where(p => p.StartsWith(autoSuggestBox.Text)).ToArray();
            //if (filter.Length > 0)
            //{
            //    var a = autoSuggestBox.Text.Contains(filter.First()) ? autoSuggestBox.Text = filter.First() : autoSuggestBox.Text = autoSuggestBox.Text;
            //}

        }

        private void MyTextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            MyTextBox.Foreground = new SolidColorBrush(Colors.Black);
            if (String.IsNullOrWhiteSpace(MyTextBox.Text))
                MyTextBox.Text = "";
        }

        private void MyTextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            if (String.IsNullOrWhiteSpace(MyTextBox.Text))
                MyTextBox.Text = "Wprowadź tekst...";
            MyTextBox.Foreground = new SolidColorBrush(Colors.Gray);
        }
    }
}
