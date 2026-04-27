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
using System.Windows.Shapes;

namespace WPF_App1
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void sendBtn_Click(object sender, RoutedEventArgs e)
        {
            var answer = (ComboBoxItem)combo1.SelectedItem;
            if (answer.Content.ToString().Equals("Windows Presentation Foundation"))
            {
                MessageBox.Show("Felicitari!");
                
            }
            else
            {
                MessageBox.Show("Mai Incearca!");
            }
        }

        private void nextBtn_Click(object sender, RoutedEventArgs e)
        {
            Page1 page1 = new Page1();
            
        }
    }
}
