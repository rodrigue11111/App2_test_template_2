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
    public sealed partial class Ajustement_pour_slump_melange_essai_erreur : Page
    {
        // Ajusyement pour le slump

        public static double ajout_eau_additionnelle;
        public static double ajout_rejet_humide_additionnel;
        public static double ajout_agregat_sec_additionnel_co_mixing;
        public static double masse_volumique_specific_agregat_co_mixing;
        public static double teneur_en_eau_massique_agregat_co_mixing;
        public Ajustement_pour_slump_melange_essai_erreur()
        {
            this.InitializeComponent();
        }

        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            ajout_eau_additionnelle = NumberBoxSpinButton_Ajustement_pour_slump_1.Value;
            ajout_rejet_humide_additionnel = NumberBoxSpinButton_Ajustement_pour_slump_2.Value;
            ajout_agregat_sec_additionnel_co_mixing = NumberBoxSpinButton_Ajustement_pour_slump_3.Value;
            masse_volumique_specific_agregat_co_mixing = NumberBoxSpinButton_Ajustement_pour_slump_4.Value;
            teneur_en_eau_massique_agregat_co_mixing = NumberBoxSpinButton_Ajustement_pour_slump_5.Value;
        }
    }
}
