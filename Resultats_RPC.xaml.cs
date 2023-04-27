using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using System.Windows;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using App2_test_template_2.Views;


// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace App2_test_template_2
{

    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    /// 

    //public class Department
    //{
    //    public int DepartmentId { get; set; }
    //    public string DepartmentName { get; set; }
    //}

    //public class Person
    //{
    //    public int PersonId { get; set; }
    //    public int DepartmentId { get; set; }
    //    public string Nom_du_résidu { get; set; }
    //    public string Nom_Operateur { get; set; }
    //    public string Quantité_moulée { get; set; }

    //    public double Cw { get; set; }

    //    public string Date_de_melange { get; set; }

        
    //}


    public sealed partial class Resultats_RPC : Page
    {










        //Informations generales(Les separer par tab)



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
        public static double A_m;

        // variables pour calculs pour tous les cas 
        //recette1
        public static double teneur_en_eau_massique_remblai_valeur;
        public static double indice_des_vides_valeur;
        public static double poids_specific_valeur;
        public static double masse_volumique_seche_remblai_valeur;
        public static double poids_volumique_sec_valeur;
        public static double pourcentage_solide_volumique_valeur;
        public static double pourcentage_volumique_de_liant_Bv_valeur;
        public static double masse_volumique_totale_valeur;
        public static double poids_volumique_total_valeur;
        public static double volume_contenant_valeur;
        public static double volume_total_de_remblai_valeur;
        public static double volume_de_solide_du_remblai_valeur;
        public static double volume_des_vides_valeur;
        public static double compacite_du_remblai_valeur;
        public static double porosite_du_remblai_valeur;
        public static double volume_des_rejets_dans_le_remblai_valeur_Vr;
        public static double volume_du_liant_dans_le_remblai_valeur;
        public static double volume_eau_dans_remblai_valeur;
        public static double masse_de_residu_sec_dans_le_remblai_valeur;
        public static double masse_de_residu_humide_dans_le_remblai_valeur;
        public static double masse_de_liant_total_dans_le_remblai_valeur_Mb;
        public static double masse_du_ciment_1_dans_le_remblai_valeur;
        public static double masse_du_ciment_2_dans_le_remblai_valeur;
        public static double masse_du_ciment_3_dans_le_remblai_valeur;
        public static double masse_eau_total_dans_le_remblai_valeur;
        public static double masse_eau_dans_le_residu_humide_valeur;
        public static double rapport_eau_sur_ciment_valeur;
        public static double masse_eau_a_rajouter_valeur;
        public static double teneur_en_eau_volumique_valeur;





        // Recette 2



        public double teneur_en_eau_volumique_valeur_recette_2;
        public double masse_eau_a_rajouter_valeur_recette_2;
        public double rapport_eau_sur_ciment_valeur_recette_2;
        public double masse_eau_dans_le_residu_humide_valeur_recette_2;
        public double masse_eau_total_dans_le_remblai_valeur_recette_2;
        public double masse_du_ciment_3_dans_le_remblai_valeur_recette_2;
        public double masse_du_ciment_2_dans_le_remblai_valeur_recette_2;
        public double masse_du_ciment_1_dans_le_remblai_valeur_recette_2;
        public double masse_de_liant_total_dans_le_remblai_valeur_Mb_recette_2;
        public double masse_de_residu_humide_dans_le_remblai_valeur_recette_2;
        public double masse_de_residu_sec_dans_le_remblai_valeur_recette_2;
        public double volume_eau_dans_remblai_valeur_recette_2;
        public double volume_du_liant_dans_le_remblai_valeur_recette_2;
        public double volume_des_rejets_dans_le_remblai_valeur_Vr_recette_2;
        public double porosite_du_remblai_valeur_recette_2;
        public double compacite_du_remblai_valeur_recette_2;
        public double volume_des_vides_valeur_recette_2;
        public double volume_de_solide_du_remblai_valeur_recette_2;
        public double volume_total_de_remblai_valeur_recette_2;
        public double volume_contenant_valeur_recette_2;
        public double poids_volumique_total_valeur_recette_2;
        public double masse_volumique_totale_valeur_recette_2;
        public double pourcentage_volumique_de_liant_Bv_valeur_recette_2;
        public double pourcentage_solide_volumique_valeur_recette_2;
        public double poids_volumique_sec_valeur_recette_2;
        public double masse_volumique_seche_remblai_valeur_recette_2;
        public double indice_des_vides_valeur_recette_2;
        public double poids_specific_remblai_valeur_recette_2;
        public double masse_volumique_remblai_valeur_recette_2;



        // Recette 3




        public double teneur_en_eau_volumique_valeur_recette_3;
        public double masse_eau_a_rajouter_valeur_recette_3;
        public double rapport_eau_sur_ciment_valeur_recette_3;
        public double masse_eau_dans_le_residu_humide_valeur_recette_3;
        public double masse_eau_total_dans_le_remblai_valeur_recette_3;
        public double masse_du_ciment_3_dans_le_remblai_valeur_recette_3;
        public double masse_du_ciment_2_dans_le_remblai_valeur_recette_3;
        public double masse_du_ciment_1_dans_le_remblai_valeur_recette_3;
        public double masse_de_liant_total_dans_le_remblai_valeur_Mb_recette_3;
        public double masse_de_residu_humide_dans_le_remblai_valeur_recette_3;
        public double masse_de_residu_sec_dans_le_remblai_valeur_recette_3;
        public double volume_eau_dans_remblai_valeur_recette_3;
        public double volume_du_liant_dans_le_remblai_valeur_recette_3;
        public double volume_des_rejets_dans_le_remblai_valeur_Vr_recette_3;
        public double porosite_du_remblai_valeur_recette_3;
        public double compacite_du_remblai_valeur_recette_3;
        public double volume_des_vides_valeur_recette_3;
        public double volume_de_solide_du_remblai_valeur_recette_3;
        public double volume_total_de_remblai_valeur_recette_3;
        public double volume_contenant_valeur_recette_3;
        public double poids_volumique_total_valeur_recette_3;
        public double masse_volumique_totale_valeur_recette_3;
        public double pourcentage_volumique_de_liant_Bv_valeur_recette_3;
        public double pourcentage_solide_volumique_valeur_recette_3;
        public double poids_volumique_sec_valeur_recette_3;
        public double masse_volumique_seche_remblai_valeur_recette_3;
        public double indice_des_vides_valeur_recette_3;
        public double poids_specific_remblai_valeur_recette_3;
        public double masse_volumique_remblai_valeur_recette_3;


        // Recette 4




        public double teneur_en_eau_volumique_valeur_recette_4;
        public double masse_eau_a_rajouter_valeur_recette_4;
        public double rapport_eau_sur_ciment_valeur_recette_4;
        public double masse_eau_dans_le_residu_humide_valeur_recette_4;
        public double masse_eau_total_dans_le_remblai_valeur_recette_4;
        public double masse_du_ciment_3_dans_le_remblai_valeur_recette_4;
        public double masse_du_ciment_2_dans_le_remblai_valeur_recette_4;
        public double masse_du_ciment_1_dans_le_remblai_valeur_recette_4;
        public double masse_de_liant_total_dans_le_remblai_valeur_Mb_recette_4;
        public double masse_de_residu_humide_dans_le_remblai_valeur_recette_4;
        public double masse_de_residu_sec_dans_le_remblai_valeur_recette_4;
        public double volume_eau_dans_remblai_valeur_recette_4;
        public double volume_du_liant_dans_le_remblai_valeur_recette_4;
        public double volume_des_rejets_dans_le_remblai_valeur_Vr_recette_4;
        public double porosite_du_remblai_valeur_recette_4;
        public double compacite_du_remblai_valeur_recette_4;
        public double volume_des_vides_valeur_recette_4;
        public double volume_de_solide_du_remblai_valeur_recette_4;
        public double volume_total_de_remblai_valeur_recette_4;
        public double volume_contenant_valeur_recette_4;
        public double poids_volumique_total_valeur_recette_4;
        public double masse_volumique_totale_valeur_recette_4;
        public double pourcentage_volumique_de_liant_Bv_valeur_recette_4;
        public double pourcentage_solide_volumique_valeur_recette_4;
        public double poids_volumique_sec_valeur_recette_4;
        public double masse_volumique_seche_remblai_valeur_recette_4;
        public double indice_des_vides_valeur_recette_4;
        public double poids_specific_remblai_valeur_recette_4;
        public double masse_volumique_remblai_valeur_recette_4;



        //public List<Department> Departments { get; set; }
        //public List<Person> Persons { get; set; }




        public Resultats_RPC()
        {
            this.InitializeComponent();



            // = InformationsPage.identification_du_residu;
            // Recettes.Cw = Dosage_selon_Cw.pourcentage_solide_massique_fixe;
            // Recettes.Nom_operateur = InformationsPage.nom_operateur;
            // Recettes.Nom_projet = InformationsPage.nom_du_projet;
            // Recettes.Date_melange = InformationsPage.date_de_melange;
            // Informations.Add(new Information
            // {
            //     Nom_residu = InformationsPage.identification_du_residu,
            //      Cw = Dosage_selon_Cw.pourcentage_solide_massique_fixe,
            //      Date_melange = InformationsPage.date_de_melange
            // });

        //    Departments = new List<Department>
        //{
        //    new Department {DepartmentId = 1, DepartmentName = "R&D"},
        //    new Department {DepartmentId = 2, DepartmentName = "Finance"},
        //    new Department {DepartmentId = 3, DepartmentName = "IT"}
        //};

        //    Persons = new List<Person>
        //{
        //    new Person
        //    {
        //         Nom_du_résidu = InformationsPage.identification_du_residu, Nom_Operateur = InformationsPage.nom_operateur,
        //        Quantité_moulée = "Network Administrator",Cw=Dosage_selon_Cw.pourcentage_solide_massique_fixe , Date_de_melange=InformationsPage.date_de_melange
        //    },
           
        //};
        }







        private void Resultats_RPC_SelectionChanged(NavigationView sender, NavigationViewSelectionChangedEventArgs args)
        {
            if (args.IsSettingsSelected)
            {

                contentFrame_Resultats_RPC.Navigate(typeof(Dosage_selon_Cw));
            }
            else
            {
                NavigationViewItem item = args.SelectedItem as NavigationViewItem;
                switch (item.Tag.ToString())
                {

                    case "Donnees_du_melange":
                        contentFrame_Resultats_RPC.Navigate(typeof(Donnees_du_melange));
                        break;


                    case "Information_sur_le_melange_Resultats_RPC":
                        contentFrame_Resultats_RPC.Navigate(typeof(Information_sur_le_melange_Resultats_RPC));
                        break;
                    case "Parametres_geotechniques_1_RPC":
                        contentFrame_Resultats_RPC.Navigate(typeof(Parametres_geotechniques_1_RPC));
                        break;



                    case "Parametres_geotechniques_2_RPC":
                        contentFrame_Resultats_RPC.Navigate(typeof(Parametres_geotechniques_2_RPC));
                        break;

                    case "Parametres_geotechniques_3_RPC":
                        contentFrame_Resultats_RPC.Navigate(typeof(Parametres_geotechniques_3_RPC));
                        break;


                }



            }
        }

       
    }

    


}

