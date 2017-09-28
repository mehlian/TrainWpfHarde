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
using TrainWpfHarde.Controls_training.BusinessLogic;

namespace TrainWpfHarde
{
    /// <summary>
    /// Interaction logic for BindingExample.xaml
    /// </summary>
    public partial class BindingExample : UserControl
    {

        public BindingExample()
        {

            InitializeComponent();
            this.DataContext = new VM();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var button = (Button)sender;
            var content = (Image)button.Content;

            Status_Text.Text = content.Source.ToString();
                //button.Content.ToString() ;
        }

        private void ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var item = (ListView)sender;
            var ece = (Book)item.SelectedItem;
            Status_Text.Text = ece.Title;
        }
    }
}
