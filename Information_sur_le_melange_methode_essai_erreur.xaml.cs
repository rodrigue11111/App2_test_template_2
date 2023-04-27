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
    public sealed partial class Information_sur_le_melange_methode_essai_erreur : Page
    {



        public static double pourcentage_solide_massique_fixe;
        public static double degre_de_saturation;
        public static double masse_volumique_specifique_du_residu;
        public static double teneur_en_eau_massique_du_residu;
        public static double nombre_de_recette_de_melange;
        public static double nombre_de_contenant_par_recette;
        public static double facteur_de_securite;
        public static double pourcentage_massique_de_liant_recette_1;
        public static double pourcentage_massique_de_liant_recette_2;
        public static double pourcentage_massique_de_liant_recette_3;
        public static double pourcentage_massique_de_liant_recette_4;







        public Information_sur_le_melange_methode_essai_erreur()
        {
            this.InitializeComponent();
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            pourcentage_solide_massique_fixe = NumberBoxSpinButton_Information_methode_essai_erreur_1.Value;
            degre_de_saturation = NumberBoxSpinButton_Information_methode_essai_erreur_2.Value;
            masse_volumique_specifique_du_residu = NumberBoxSpinButton_Information_methode_essai_erreur_3.Value;
            teneur_en_eau_massique_du_residu = NumberBoxSpinButton_Information_methode_essai_erreur_4.Value;

            nombre_de_contenant_par_recette = NumberBoxSpinButton_Information_methode_essai_erreur_6.Value;
            facteur_de_securite = NumberBoxSpinButton_Information_methode_essai_erreur_7.Value;
            pourcentage_massique_de_liant_recette_1 = NumberBoxSpinButton_Information_methode_essai_erreur_8.Value;
            pourcentage_massique_de_liant_recette_2 = NumberBoxSpinButton_Information_methode_essai_erreur_9.Value;
            pourcentage_massique_de_liant_recette_3 = NumberBoxSpinButton_Information_methode_essai_erreur_10.Value;
            pourcentage_massique_de_liant_recette_4 = NumberBoxSpinButton_Information_methode_essai_erreur_11.Value;

        }

        private void RadioButton_Checked_nombre_recette(object sender, RoutedEventArgs e)
        {
            RadioButton rb = sender as RadioButton;

            if (rb.Name == "un")
            {
                NumberBoxSpinButton_Information_methode_essai_erreur_9.IsEnabled = false;
                NumberBoxSpinButton_Information_methode_essai_erreur_10.IsEnabled = false;
                NumberBoxSpinButton_Information_methode_essai_erreur_11.IsEnabled = false;
            }
            else if (rb.Name == "deux")
            {
                NumberBoxSpinButton_Information_methode_essai_erreur_9.IsEnabled = true;
                NumberBoxSpinButton_Information_methode_essai_erreur_10.IsEnabled = false;
                NumberBoxSpinButton_Information_methode_essai_erreur_11.IsEnabled = false;
            }
            else if (rb.Name == "trois")
            {
                NumberBoxSpinButton_Information_methode_essai_erreur_9.IsEnabled = true;
                NumberBoxSpinButton_Information_methode_essai_erreur_10.IsEnabled = true;
                NumberBoxSpinButton_Information_methode_essai_erreur_11.IsEnabled = false;
            }

            else if (rb.Name == "quatre")
            {
                NumberBoxSpinButton_Information_methode_essai_erreur_8.IsEnabled = true;
                NumberBoxSpinButton_Information_methode_essai_erreur_9.IsEnabled = true;
                NumberBoxSpinButton_Information_methode_essai_erreur_10.IsEnabled = true;
                NumberBoxSpinButton_Information_methode_essai_erreur_11.IsEnabled = true;
            }

        }
    }
}
