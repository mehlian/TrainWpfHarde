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
    /// Interaction logic for XamlDialogs.xaml
    /// </summary>
    public partial class XamlDialogs : UserControl
    {
        public XamlDialogs()
        {
            InitializeComponent();
        }

        private void ShowMessageBox_Click(object sender, RoutedEventArgs e)
        {
            string msgtext = "Click any button";
            string txt = "My Title";
            MessageBoxButton button = MessageBoxButton.YesNoCancel;
            MessageBoxResult result = MessageBox.Show(msgtext, txt, button);

            switch (result)
            {
                case MessageBoxResult.None:
                    break;
                case MessageBoxResult.OK:
                    break;
                case MessageBoxResult.Cancel:
                    Status_Text.Text = "Selected Cancel";
                    break;
                case MessageBoxResult.Yes:
                    Status_Text.Text = "Selected Yes";
                    break;
                case MessageBoxResult.No:
                    Status_Text.Text = "Selected No";
                    break;
                default:
                    break;
            }
        }
    }
}
