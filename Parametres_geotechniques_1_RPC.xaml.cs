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

    public class Parametres_geotechniques_1
    {
        //public int PersonId { get; set; }
        //public int DepartmentId { get; set; }
        public string Parametres { get; set; }
        public double Recette_1 { get; set; }
        public double Recette_2 { get; set; }

        public double Recette_3 { get; set; }

        public double Recette_4 { get; set; }


        

    }
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Parametres_geotechniques_1_RPC : Page
    {
        public List<Parametres_geotechniques_1> Parametres_geotechniques_1_list { get; set; }
        public Parametres_geotechniques_1_RPC()
        {
            this.InitializeComponent();



            Parametres_geotechniques_1_list = new List<Parametres_geotechniques_1>


        {
            new Parametres_geotechniques_1
            {
                  Parametres = "Pourcentage(%) massique de liant Bw%", Recette_1 = Dosage_selon_Cw.pourcentage_massique_de_liant_recette_1,
                Recette_2 = Dosage_selon_Cw.pourcentage_massique_de_liant_recette_2,Recette_3=Dosage_selon_Cw.pourcentage_massique_de_liant_recette_3 ,
                Recette_4=Dosage_selon_Cw.pourcentage_massique_de_liant_recette_4
            },

        };

            

        }
    }
}
