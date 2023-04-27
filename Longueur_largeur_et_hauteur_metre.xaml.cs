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
    public sealed partial class Longueur_largeur_et_hauteur_metre : Page
    {

        public static double longueur_m=0;
        public static double largeur_m=0;
        public static double hauteur_m=0;
        public Longueur_largeur_et_hauteur_metre()
        {
            this.InitializeComponent();
        }

        private void btn1_longueur_largeur_hauteur_metre_Click(object sender, RoutedEventArgs e)
        {
            longueur_m = NumberBoxSpinButton_Longueur_Largeur_et_hauteur_metre_1.Value;
            largeur_m = NumberBoxSpinButton_Longueur_Largeur_et_hauteur_metre_2.Value;
            hauteur_m = NumberBoxSpinButton_Longueur_Largeur_et_hauteur_metre_3.Value;

        }
    }
}
