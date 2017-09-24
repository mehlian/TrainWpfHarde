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
    /// Interaction logic for AppMenus.xaml
    /// </summary>
    public partial class AppMenus : UserControl
    {
        public AppMenus()
        {
            InitializeComponent();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            MenuItem item = (MenuItem)sender;
            Status_Text.Text = "File: " + item.Header;
        }
        private void MenuItem_Click1(object sender, RoutedEventArgs e)
        {
            MenuItem item = (MenuItem)sender;
            Status_Text.Text = "Edit: " + item.Header;
        }
    }
}
