using System;
using System.Windows;
using System.Windows.Input;

namespace csharp_wpf_orderpanel.Views
{
    public partial class AuthorizationWindow : Window
    {
        public AuthorizationWindow()
        {
            InitializeComponent();
        }

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
                this.DragMove();
        }

        private void authorizationLoginButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void authorizationCancelButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}