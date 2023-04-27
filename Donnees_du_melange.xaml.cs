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
using App2_test_template_2.Views;
using System.Threading.Tasks;


// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace App2_test_template_2
{

    public class Donnees_du_melange_resultats
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
    public sealed partial class Donnees_du_melange : Page
    {

        public List<Donnees_du_melange_resultats> Donnees_du_melange_resultats_list { get; set; }
        public Donnees_du_melange()
        {
            this.InitializeComponent();




            Donnees_du_melange_resultats_list = new List<Donnees_du_melange_resultats>


        {
            new Donnees_du_melange_resultats
            {
                 Parametres = "Pourcentage(%) massique de liant Bw% :", Recette_1 = Dosage_selon_Cw.pourcentage_massique_de_liant_recette_1,
                Recette_2 = Dosage_selon_Cw.pourcentage_massique_de_liant_recette_2,Recette_3=Dosage_selon_Cw.pourcentage_massique_de_liant_recette_3 , 
                Recette_4=Dosage_selon_Cw.pourcentage_massique_de_liant_recette_4
            },


            new Donnees_du_melange_resultats
            {
                 Parametres = "Pourcentage(%) volumique de liant Bv% :", Recette_1 = Dosage_selon_Cw.pourcentage_volumique_de_liant_Bv_valeur_new,
                Recette_2 = Dosage_selon_Cw.pourcentage_volumique_de_liant_Bv_valeur_recette_2_new,Recette_3=Dosage_selon_Cw.pourcentage_volumique_de_liant_Bv_valeur_recette_3_new ,
                Recette_4=Dosage_selon_Cw.pourcentage_volumique_de_liant_Bv_valeur_recette_4_new
            },

             new Donnees_du_melange_resultats
            {
                 Parametres = "Masse totale de rejet sec Mr-sec :", Recette_1 = Dosage_selon_Cw.masse_de_residu_sec_dans_le_remblai_valeur_new,
                Recette_2 = Dosage_selon_Cw.masse_de_residu_sec_dans_le_remblai_valeur_recette_2_new,Recette_3=Dosage_selon_Cw.masse_de_residu_sec_dans_le_remblai_valeur_recette_3_new , 
                 Recette_4=Dosage_selon_Cw.masse_de_residu_sec_dans_le_remblai_valeur_recette_4_new
            },


              new Donnees_du_melange_resultats
            {
                 Parametres = "Masse totale de liant Mb :", Recette_1 = Dosage_selon_Cw.masse_de_liant_total_dans_le_remblai_valeur_Mb_new,
                Recette_2 = Dosage_selon_Cw.masse_de_liant_total_dans_le_remblai_valeur_Mb_recette_2_new,Recette_3=Dosage_selon_Cw.masse_de_liant_total_dans_le_remblai_valeur_Mb_recette_3_new , 
                  Recette_4=Dosage_selon_Cw.masse_de_liant_total_dans_le_remblai_valeur_Mb_recette_4_new
            },


               new Donnees_du_melange_resultats
            {
                 Parametres = "Masse de rejet humide Mr-hum :", Recette_1 = Dosage_selon_Cw.masse_de_residu_humide_dans_le_remblai_valeur_new,
                Recette_2 = Dosage_selon_Cw.masse_de_residu_humide_dans_le_remblai_valeur_recette_2_new,Recette_3=Dosage_selon_Cw.masse_de_residu_humide_dans_le_remblai_valeur_recette_3_new , 
                   Recette_4=Dosage_selon_Cw.masse_de_residu_humide_dans_le_remblai_valeur_recette_4_new
            },



                new Donnees_du_melange_resultats
            {
                 Parametres = "Masse d'eau ajout Mw-aj :", Recette_1 = Dosage_selon_Cw.masse_eau_a_rajouter_valeur_new,
                Recette_2 = Dosage_selon_Cw.masse_eau_a_rajouter_valeur_recette_2_new,Recette_3=Dosage_selon_Cw.masse_eau_a_rajouter_valeur_recette_3_new ,
                   Recette_4=Dosage_selon_Cw.masse_eau_a_rajouter_valeur_recette_4_new
            },



                new Donnees_du_melange_resultats
            {  

                 Parametres = "Masse du "+InformationsPage.nom_liant_1+":", 
                    
                    Recette_1 = Dosage_selon_Cw.masse_du_ciment_1_dans_le_remblai_valeur_new,
                Recette_2 = Dosage_selon_Cw.masse_du_ciment_1_dans_le_remblai_valeur_recette_2_new,Recette_3=Dosage_selon_Cw.masse_du_ciment_1_dans_le_remblai_valeur_recette_3_new ,
                   Recette_4=Dosage_selon_Cw.masse_du_ciment_1_dans_le_remblai_valeur_recette_4_new
            },

                new Donnees_du_melange_resultats
            {
                 Parametres = "Masse du "+InformationsPage.nom_liant_2+":", Recette_1 = Dosage_selon_Cw.masse_du_ciment_2_dans_le_remblai_valeur_new,
                Recette_2 = Dosage_selon_Cw.masse_du_ciment_2_dans_le_remblai_valeur_recette_2_new,Recette_3=Dosage_selon_Cw.masse_du_ciment_2_dans_le_remblai_valeur_recette_3_new ,
                   Recette_4=Dosage_selon_Cw.masse_du_ciment_2_dans_le_remblai_valeur_recette_4_new
            },


                new Donnees_du_melange_resultats
            {
                 Parametres = "Masse du ciment "+InformationsPage.nom_liant_3+":", Recette_1 = Dosage_selon_Cw.masse_du_ciment_3_dans_le_remblai_valeur_new,
                Recette_2 = Dosage_selon_Cw.masse_du_ciment_3_dans_le_remblai_valeur_recette_2_new,Recette_3=Dosage_selon_Cw.masse_du_ciment_3_dans_le_remblai_valeur_recette_3_new ,
                   Recette_4=Dosage_selon_Cw.masse_du_ciment_3_dans_le_remblai_valeur_recette_4_new
            },


        };



        }

        class WriteAllLines
        {
            public static async Task ExampleAsync()
            {
                string[] lines =
                {
            "First line", "Second line", "Third line"
        };

                await File.WriteAllLinesAsync("WriteLines.txt", lines);
            }
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {

            



        }

        private async void Button_Click2(object sender, RoutedEventArgs e)
        {
            

        }
    }
}
