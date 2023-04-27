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
    public sealed partial class Dosage_selon_w_c : Page
    {

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

        public double rapport_eau_ciment_dosage_selon_rapport_recette_1;
        public double rapport_eau_ciment_dosage_selon_rapport_recette_2;
        public double rapport_eau_ciment_dosage_selon_rapport_recette_3;
        public double rapport_eau_ciment_dosage_selon_rapport_recette_4;

        public Dosage_selon_w_c()
        {
            this.InitializeComponent();
        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            degre_de_saturation = NumberBoxSpinButton_Dosage_Cw_2.Value;
            masse_volumique_specifique_du_residu = NumberBoxSpinButton_Dosage_Cw_3.Value;
            teneur_en_eau_massique_du_residu = NumberBoxSpinButton_Dosage_Cw_4.Value;

            nombre_de_contenant_par_recette = NumberBoxSpinButton_Dosage_Cw__.Value;
            facteur_de_securite = NumberBoxSpinButton_Dosage_Cw_6.Value;

            pourcentage_massique_de_liant_recette_1 = NumberBoxSpinButton_Dosage_Cw_7.Value;
            rapport_eau_ciment_dosage_selon_rapport_recette_1 = NumberBoxSpinButton_Dosage_Cw__7.Value;



            pourcentage_massique_de_liant_recette_2 = NumberBoxSpinButton_Dosage_Cw_8.Value;
            rapport_eau_ciment_dosage_selon_rapport_recette_2 = NumberBoxSpinButton_Dosage_Cw__8.Value;

            pourcentage_massique_de_liant_recette_3 = NumberBoxSpinButton_Dosage_Cw_9.Value;
            rapport_eau_ciment_dosage_selon_rapport_recette_3 = NumberBoxSpinButton_Dosage_Cw__9.Value;


            pourcentage_massique_de_liant_recette_4 = NumberBoxSpinButton_Dosage_Cw_10.Value;
            rapport_eau_ciment_dosage_selon_rapport_recette_4 = NumberBoxSpinButton_Dosage_Cw__10.Value;
        }

        private void RadioButton_Checked_nombre_recette(object sender, RoutedEventArgs e)
        {
            RadioButton rb = sender as RadioButton;

            if (rb.Name == "un")
            {
                NumberBoxSpinButton_Dosage_Cw_8.IsEnabled = false;
                NumberBoxSpinButton_Dosage_Cw_9.IsEnabled = false;
                NumberBoxSpinButton_Dosage_Cw_10.IsEnabled = false;

                NumberBoxSpinButton_Dosage_Cw__8.IsEnabled = false;
                NumberBoxSpinButton_Dosage_Cw__9.IsEnabled = false;
                NumberBoxSpinButton_Dosage_Cw__10.IsEnabled = false;

            }
            else if (rb.Name == "deux")
            {
                NumberBoxSpinButton_Dosage_Cw_8.IsEnabled = true;
                NumberBoxSpinButton_Dosage_Cw_9.IsEnabled = false;
                NumberBoxSpinButton_Dosage_Cw_10.IsEnabled = false;

                NumberBoxSpinButton_Dosage_Cw__8.IsEnabled = true;
                NumberBoxSpinButton_Dosage_Cw__9.IsEnabled = false;
                NumberBoxSpinButton_Dosage_Cw__10.IsEnabled = false;


            }
            else if (rb.Name == "trois")
            {
                NumberBoxSpinButton_Dosage_Cw_8.IsEnabled = true;
                NumberBoxSpinButton_Dosage_Cw_9.IsEnabled = true;
                NumberBoxSpinButton_Dosage_Cw_10.IsEnabled = false;

                NumberBoxSpinButton_Dosage_Cw__8.IsEnabled = true;
                NumberBoxSpinButton_Dosage_Cw__9.IsEnabled = true;
                NumberBoxSpinButton_Dosage_Cw__10.IsEnabled = false;

            }

            else if (rb.Name == "quatre")
            {
                NumberBoxSpinButton_Dosage_Cw_7.IsEnabled = true;
                NumberBoxSpinButton_Dosage_Cw_8.IsEnabled = true;
                NumberBoxSpinButton_Dosage_Cw_9.IsEnabled = true;
                NumberBoxSpinButton_Dosage_Cw_10.IsEnabled = true;

                NumberBoxSpinButton_Dosage_Cw__7.IsEnabled = true;
                NumberBoxSpinButton_Dosage_Cw__8.IsEnabled = true;
                NumberBoxSpinButton_Dosage_Cw__9.IsEnabled = true;
                NumberBoxSpinButton_Dosage_Cw__10.IsEnabled = true;



            }
        }
    }
}
