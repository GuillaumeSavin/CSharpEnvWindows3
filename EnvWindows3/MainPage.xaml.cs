using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// Pour plus d'informations sur le modèle d'élément Page vierge, consultez la page https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace EnvWindows3
{
    /// <summary>
    /// Une page vide peut être utilisée seule ou constituer une page de destination au sein d'un frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        String sexe;
        String age;

        public MainPage()
        {
            this.InitializeComponent();
        }

        private void Sexe_Changed(object sender, RoutedEventArgs e)
        {
            if((bool)RadioHomme.IsChecked)
            {
                sexe = "Homme";
            }
            if((bool)RadioFemme.IsChecked)
            {
                sexe = "Femme";
            }
        }

        private void Age_Changed(object sender, RoutedEventArgs e)
        {
            if ((bool)RadioMineur.IsChecked)
            {
                age = "Mineur";
            }
            if ((bool)RadioMajeur.IsChecked)
            {
                age = "Majeur";
            }
        }

        private void BoutonValider_Click(object sender, RoutedEventArgs e)
        {
            LoginStatusDialog(sexe, age);
        }

        private async void LoginStatusDialog(String sexeRentré, String ageRentré)
        {
            String content;

            content = "Votre sexe est : " + sexeRentré + " et votre age est : " + ageRentré;
                     
            ContentDialog dialog = new ContentDialog
            {
                Title = "Exercice 3",
                Content = content,
                CloseButtonText = "OK"
            };

            ContentDialogResult result = await dialog.ShowAsync();
        }
    }
}
