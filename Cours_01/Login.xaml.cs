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

namespace PremiereAppWPF
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();

            TextBlock textBlockTitle = new TextBlock();
            textBlockTitle.Text = " Informations personnelles";
            textBlockTitle.Margin = new Thickness(28, 15, 0, 0);

            MainLayout.Children.Add(textBlockTitle);


            Button btn = new Button();
            btn.Content = "Ok";


           // MainLayout.Children.Add(btn);

        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            e.Cancel = true;
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {

            // on suppose que le username et password sont corrects
            //this.Close();

        }
    }
}
