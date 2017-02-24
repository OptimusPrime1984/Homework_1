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

namespace HelloWorldUpdated
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        bool isTextboxFilled = false;
        bool isPasswordFilled = false;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void uxName_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (uxName.Text.Length > 0)
            {
                isTextboxFilled = true;
            }
            setButton();
        }

        private void uxPassword_PasswordChanged(object sender, RoutedEventArgs e)
        {
            if (uxPassword.Password.Length > 0)
            {
                isPasswordFilled = true;
            }
            setButton();
        }

        private void setButton()
        {
            if(isPasswordFilled && isTextboxFilled)
            {
                uxSubmit.IsEnabled = true;
            }
        }
    }
}
