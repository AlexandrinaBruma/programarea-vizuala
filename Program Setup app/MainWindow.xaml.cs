using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Program_Setup_app
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            String plan = "";
            if(fullPlan.IsChecked == true)
            {
                plan = "Full Plan";
            }
            else if (limitedPlan.IsChecked == true)
            {
                plan = "Limited Plan";
            }
            else if (customPlan.IsChecked == true)
            {
                plan = "Custom Plan";
            }
            String username = usernameTextBox.Text;
            String password = passwordTextBox.Text;
            String language = languageCombo.Text;
            String version = versionCombo.Text;

            planNameItem.Content = "Plan: " + plan;
            usernameItem.Content = "Username: " + username;
            languageItem.Content = "Language: " + language;
            selectedVersion.Content = "Version: " + version;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}