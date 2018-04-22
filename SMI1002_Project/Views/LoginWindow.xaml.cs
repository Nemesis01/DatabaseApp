using SMI1002_Project.Interfaces;
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

namespace SMI1002_Project.Views
{
    /// <summary>
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        public LoginWindow()
        {
            InitializeComponent();
        }

        private bool IsAuthenticate()
        {
            // Récupération du username et du password
            string username = TxtBoxUsername.Text;
            string password = TxtBoxPassword.Text;
            if (username.Equals(Constants.dbUserName) && password.Equals(Constants.dbPassword))
                return true;
            return false;
        }

        private void LaunchMainWindow()
        {
            // Ferneture de la fenêtre de connexion
            // Ouverture de la fenêtre principale
            this.Close();
            new MainWindow();
        }

        private void BtnConnection_Click(object sender, RoutedEventArgs e)
        {
            // si les informations de login sont correctes on affiche la fenêtre principale
            if (IsAuthenticate() == true)
                LaunchMainWindow();
            else
            {
                MessageBox.Show("Nom d'utilisateur ou Mot de passe invalide. Veuillez essayer de nouveau!",
                    Constants.AppName,
                    MessageBoxButton.OK,
                    MessageBoxImage.Error);
            }
        }
    }
}
