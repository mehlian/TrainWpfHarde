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
    /// Interaction logic for ComboBoxes.xaml
    /// </summary>
    public partial class ComboBoxes : UserControl
    {
        public ComboBoxes()
        {
            InitializeComponent();
        }

        private void OnSelectionChanged(object sender, EventArgs e)
        {
            
            ComboBox comboBox = (ComboBox)sender;
            var item = (ComboBoxItem)comboBox.SelectedItem;

            // Bramka chroniąca przed dostępem do nieistniejącego jeszcze comboBoxa
            //if (item == null)
            //    return;
            // Alternatywnie - wystarczy dodać ? na końcu zmniennej
            // ? - null checker

            if (item?.Content is ComboBox)
            {
                var nestedComboBox = (ComboBox)item.Content;
                var nestedItem = (ComboBoxItem)nestedComboBox.SelectedItem;
                Status_Text.Text = nestedItem.Content.ToString();
            }
            else
            {
                Status_Text.Text = item?.Content.ToString();
            }

        }
    }
}
