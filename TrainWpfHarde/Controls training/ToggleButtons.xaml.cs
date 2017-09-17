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
    /// Interaction logic for ToggleButtons.xaml
    /// </summary>
    public partial class ToggleButtons : UserControl
    {
        public ToggleButtons()
        {
            InitializeComponent();
        }

        private void MyToggleButton_Click(object sender, RoutedEventArgs e)
        {
            Status_Text.Text = MyToggleButton.IsChecked.ToString();
        }
    }
}
