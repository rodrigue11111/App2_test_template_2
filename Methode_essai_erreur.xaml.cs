using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace App2_test_template_2
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Methode_essai_erreur : Page
    {
        public Methode_essai_erreur()
        {
            this.InitializeComponent();
        }

      


        private void Méthode_essai_erreur_SelectionChanged(NavigationView sender, NavigationViewSelectionChangedEventArgs args)
        {
            if (args.IsSettingsSelected)
            {

                contentFrame_methode_essai_erreur.Navigate(typeof(Dosage_selon_Cw));
            }
            else
            {
                NavigationViewItem item = args.SelectedItem as NavigationViewItem;
                switch (item.Tag.ToString())
                {
                    case "Information_sur_le_melange_essai_erreur":
                        contentFrame_methode_essai_erreur.Navigate(typeof(Information_sur_le_melange_methode_essai_erreur));
                        break;
                    case "Ajustement_pour_slump_melange_essai_erreur":
                        contentFrame_methode_essai_erreur.Navigate(typeof(Ajustement_pour_slump_melange_essai_erreur));
                        break;



                }



            }
        }
    }
}
