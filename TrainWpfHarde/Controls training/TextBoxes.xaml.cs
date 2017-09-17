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
        //TODO: Placeholder
        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            var autoSuggestBox = (TextBox)sender;
            var filter = selectionItems.Where(p => p.StartsWith(autoSuggestBox.Text)).ToArray();
            autoSuggestBox.Text = filter[0];
        }
    }
}
