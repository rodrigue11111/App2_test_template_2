using App2_test_template_2.Views;
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
    public sealed partial class Dosage_selon_Cw : Page


    {
       



        public double masse_volumique_eau = 1;
        public double g = 9.81;
        public double g_new = 9.81;
        public static double nombre_de_contenants;
        public static double nombre_de_contenants_new;

        public string Informations = "Informations générales";

        //Informations generales(Les separer par tab)



        public  static double pourcentage_solide_massique_fixe;
        public static  double degre_de_saturation;
        public static double masse_volumique_specifique_du_residu;
        public static double teneur_en_eau_massique_du_residu;
        public static double nombre_de_recette_de_melange;
        public static double nombre_de_contenant_par_recette;
        public static double facteur_de_securite;
        public static double facteur_de_securite_new;

        public static double pourcentage_massique_de_liant_recette_1;
        public static double pourcentage_massique_de_liant_recette_2;
        public static double pourcentage_massique_de_liant_recette_3;
        public static double pourcentage_massique_de_liant_recette_4;
        public static double A_m;

        // variables pour calculs pour tous les cas 
        //recette1

        public static double pourcentage_volumique_de_liant_Bv_valeur;

        public static double teneur_en_eau_massique_remblai_valeur;
        public static double indice_des_vides_valeur;
        public static double indice_des_vides_valeur_new;


        public static double poids_specific_valeur;
        public static double masse_volumique_seche_remblai_valeur;
        public static double poids_volumique_sec_valeur;
        public static double poids_volumique_sec_valeur_new;

        public static double pourcentage_solide_volumique_valeur;
        public static double pourcentage_volumique_de_liant_Bv_valeur_new;
        public static double masse_volumique_totale_valeur;
        public static double poids_volumique_total_valeur;
        public static double poids_volumique_total_valeur_new;

        public static double volume_contenant_valeur;
        public static double volume_contenant_valeur_new;

        public static double volume_total_de_remblai_valeur;
        public static double volume_de_solide_du_remblai_valeur;
        public static double volume_des_vides_valeur;
        public static double compacite_du_remblai_valeur;
        public static double compacite_du_remblai_valeur_new;

        public static double porosite_du_remblai_valeur;
        public static double porosite_du_remblai_valeur_new;

        public static double volume_des_rejets_dans_le_remblai_valeur_Vr;
        public static double volume_des_rejets_dans_le_remblai_valeur_Vr_new;

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



        

        public static double volume_du_liant_dans_le_remblai_valeur_new;
        public static double volume_eau_dans_remblai_valeur_new;
        public static double masse_de_residu_sec_dans_le_remblai_valeur_new;
        public static double masse_de_residu_humide_dans_le_remblai_valeur_new;
        public static double masse_de_liant_total_dans_le_remblai_valeur_Mb_new;
        public static double masse_du_ciment_1_dans_le_remblai_valeur_new;
        public static double masse_du_ciment_2_dans_le_remblai_valeur_new;
        public static double masse_du_ciment_3_dans_le_remblai_valeur_new;
        public static double asse_eau_total_dans_le_remblai_valeur_new;
        public static double masse_eau_dans_le_residu_humide_valeur_new;
        public static double masse_eau_a_rajouter_valeur_new;
        public static double teneur_en_eau_volumique_valeur_new;
        public static double masse_eau_total_dans_le_remblai_valeur_new;
        public static double masse_volumique_remblai_valeur_new;
        public static double rapport_eau_sur_ciment_valeur_new;

        public static double teneur_en_eau_massique_remblai_valeur_new;
        public static double masse_volumique_seche_remblai_valeur_new;
        public static double pourcentage_solide_volumique_valeur_new;
        public static double masse_volumique_totale_valeur_new;
        public static double volume_total_de_remblai_valeur_new;
        public static double volume_de_solide_du_remblai_valeur_new;
        public static double volume_des_vides_valeur_new;


        // Recette 2



        public static double indice_des_vides_valeur_recette_2_new;
        public static double poids_volumique_sec_valeur_recette_2_new;
        public static double pourcentage_volumique_de_liant_Bv_valeur_recette_2_new;
        public static double poids_volumique_total_valeur_recette_2_new;
        public static double compacite_du_remblai_valeur_recette_2_new;
        public static double porosite_du_remblai_valeur_recette_2_new;
        public static double volume_des_rejets_dans_le_remblai_valeur_Vr_recette_2_new;

        public static double volume_du_liant_dans_le_remblai_valeur_recette_2_new;
        public static double volume_eau_dans_remblai_valeur_recette_2_new;
        public static double masse_de_residu_sec_dans_le_remblai_valeur_recette_2_new;
        public static double masse_de_residu_humide_dans_le_remblai_valeur_recette_2_new;
        public static double masse_de_liant_total_dans_le_remblai_valeur_Mb_recette_2_new;
        public static double masse_du_ciment_1_dans_le_remblai_valeur_recette_2_new;
        public static double masse_du_ciment_2_dans_le_remblai_valeur_recette_2_new;
        public static double masse_du_ciment_3_dans_le_remblai_valeur_recette_2_new;
        public static double asse_eau_total_dans_le_remblai_valeur_recette_2_new;
        public static double masse_eau_dans_le_residu_humide_valeur_recette_2_new;
        public static double masse_eau_a_rajouter_valeur_recette_2_new;
        public static double teneur_en_eau_volumique_valeur_recette_2_new;
        public static double masse_eau_total_dans_le_remblai_valeur_recette_2_new;
        public static double masse_volumique_remblai_valeur_recette_2_new;
        public static double rapport_eau_sur_ciment_valeur_recette_2_new;
        public static double poids_specific_liant_valeur_recette_2_new;
        public static double poids_specific_remblai_valeur_recette_2_new;
        public static double volume_contenant_valeur_recette_2_new;
        public static double teneur_en_eau_massique_remblai_valeur_recette_2_new;
        public static double masse_volumique_seche_remblai_valeur_recette_2_new;
        public static double pourcentage_solide_volumique_valeur_recette_2_new;
        public static double masse_volumique_totale_valeur_recette_2_new;
        public static double volume_total_de_remblai_valeur_recette_2_new;
        public static double volume_de_solide_du_remblai_valeur_recette_2_new;
        public static double volume_des_vides_valeur_recette_2_new;






        public static double teneur_en_eau_volumique_valeur_recette_2;
        public static double masse_eau_a_rajouter_valeur_recette_2;
        public static double rapport_eau_sur_ciment_valeur_recette_2;
        public static double masse_eau_dans_le_residu_humide_valeur_recette_2;
        public static double masse_eau_total_dans_le_remblai_valeur_recette_2;
        public static double masse_du_ciment_3_dans_le_remblai_valeur_recette_2;
        public static double masse_du_ciment_2_dans_le_remblai_valeur_recette_2;
        public static double masse_du_ciment_1_dans_le_remblai_valeur_recette_2;
        public static double masse_de_liant_total_dans_le_remblai_valeur_Mb_recette_2;
        public static double masse_de_residu_humide_dans_le_remblai_valeur_recette_2;
        public static double masse_de_residu_sec_dans_le_remblai_valeur_recette_2;
        public static double volume_eau_dans_remblai_valeur_recette_2;
        public static double volume_du_liant_dans_le_remblai_valeur_recette_2;
        public static double volume_des_rejets_dans_le_remblai_valeur_Vr_recette_2;
        public static double porosite_du_remblai_valeur_recette_2;
        public static double compacite_du_remblai_valeur_recette_2;
        public static double volume_des_vides_valeur_recette_2;
        public static double volume_de_solide_du_remblai_valeur_recette_2;
        public static double volume_total_de_remblai_valeur_recette_2;
        public static double volume_contenant_valeur_recette_2;
        public static double poids_volumique_total_valeur_recette_2;
        public static double masse_volumique_totale_valeur_recette_2;
        public static double pourcentage_volumique_de_liant_Bv_valeur_recette_2;
        public static double pourcentage_solide_volumique_valeur_recette_2;
        public static double poids_volumique_sec_valeur_recette_2;
        public static double masse_volumique_seche_remblai_valeur_recette_2;
        public static double indice_des_vides_valeur_recette_2;
        public static double poids_specific_remblai_valeur_recette_2;
        public static double masse_volumique_remblai_valeur_recette_2;




        // Recette 3





        public static double indice_des_vides_valeur_recette_3_new;
        public static double poids_volumique_sec_valeur_recette_3_new;
        public static double pourcentage_volumique_de_liant_Bv_valeur_recette_3_new;
        public static double poids_volumique_total_valeur_recette_3_new;
        public static double compacite_du_remblai_valeur_recette_3_new;
        public static double porosite_du_remblai_valeur_recette_3_new;
        public static double volume_des_rejets_dans_le_remblai_valeur_Vr_recette_3_new;

        public static double volume_du_liant_dans_le_remblai_valeur_recette_3_new;
        public static double volume_eau_dans_remblai_valeur_recette_3_new;
        public static double masse_de_residu_sec_dans_le_remblai_valeur_recette_3_new;
        public static double masse_de_residu_humide_dans_le_remblai_valeur_recette_3_new;
        public static double masse_de_liant_total_dans_le_remblai_valeur_Mb_recette_3_new;
        public static double masse_du_ciment_1_dans_le_remblai_valeur_recette_3_new;
        public static double masse_du_ciment_2_dans_le_remblai_valeur_recette_3_new;
        public static double masse_du_ciment_3_dans_le_remblai_valeur_recette_3_new;
        public static double asse_eau_total_dans_le_remblai_valeur_recette_3_new;
        public static double masse_eau_dans_le_residu_humide_valeur_recette_3_new;
        public static double masse_eau_a_rajouter_valeur_recette_3_new;
        public static double teneur_en_eau_volumique_valeur_recette_3_new;
        public static double masse_eau_total_dans_le_remblai_valeur_recette_3_new;
        public static double masse_volumique_remblai_valeur_recette_3_new;
        public static double rapport_eau_sur_ciment_valeur_recette_3_new;
        public static double poids_specific_liant_valeur_recette_3_new;
        public static double poids_specific_remblai_valeur_recette_3_new;
        public static double volume_contenant_valeur_recette_3_new;
        public static double teneur_en_eau_massique_remblai_valeur_recette_3_new;
        public static double masse_volumique_seche_remblai_valeur_recette_3_new;
        public static double pourcentage_solide_volumique_valeur_recette_3_new;
        public static double masse_volumique_totale_valeur_recette_3_new;
        public static double volume_total_de_remblai_valeur_recette_3_new;
        public static double volume_de_solide_du_remblai_valeur_recette_3_new;
        public static double volume_des_vides_valeur_recette_3_new;








        public static double teneur_en_eau_volumique_valeur_recette_3;
        public static double masse_eau_a_rajouter_valeur_recette_3;
        public static double rapport_eau_sur_ciment_valeur_recette_3;
        public static double masse_eau_dans_le_residu_humide_valeur_recette_3;
        public static double masse_eau_total_dans_le_remblai_valeur_recette_3;
        public static double masse_du_ciment_3_dans_le_remblai_valeur_recette_3;
        public static double masse_du_ciment_2_dans_le_remblai_valeur_recette_3;
        public static double masse_du_ciment_1_dans_le_remblai_valeur_recette_3;
        public static double masse_de_liant_total_dans_le_remblai_valeur_Mb_recette_3;
        public static double masse_de_residu_humide_dans_le_remblai_valeur_recette_3;
        public static double masse_de_residu_sec_dans_le_remblai_valeur_recette_3;
        public static double volume_eau_dans_remblai_valeur_recette_3;
        public static double volume_du_liant_dans_le_remblai_valeur_recette_3;
        public static double volume_des_rejets_dans_le_remblai_valeur_Vr_recette_3;
        public static double porosite_du_remblai_valeur_recette_3;
        public static double compacite_du_remblai_valeur_recette_3;
        public static double volume_des_vides_valeur_recette_3;
        public static double volume_de_solide_du_remblai_valeur_recette_3;
        public static double volume_total_de_remblai_valeur_recette_3;
        public static double volume_contenant_valeur_recette_3;
        public static double poids_volumique_total_valeur_recette_3;
        public static double masse_volumique_totale_valeur_recette_3;
        public static double pourcentage_volumique_de_liant_Bv_valeur_recette_3;
        public static double pourcentage_solide_volumique_valeur_recette_3;
        public static double poids_volumique_sec_valeur_recette_3;
        public static double masse_volumique_seche_remblai_valeur_recette_3;
        public static double indice_des_vides_valeur_recette_3;
        public static double poids_specific_remblai_valeur_recette_3;
        public static double masse_volumique_remblai_valeur_recette_3;


        // Recette 4







        public static double indice_des_vides_valeur_recette_4_new;
        public static double poids_volumique_sec_valeur_recette_4_new;
        public static double pourcentage_volumique_de_liant_Bv_valeur_recette_4_new;
        public static double poids_volumique_total_valeur_recette_4_new;
        public static double compacite_du_remblai_valeur_recette_4_new;
        public static double porosite_du_remblai_valeur_recette_4_new;
        public static double volume_des_rejets_dans_le_remblai_valeur_Vr_recette_4_new;

        public static double volume_du_liant_dans_le_remblai_valeur_recette_4_new;
        public static double volume_eau_dans_remblai_valeur_recette_4_new;
        public static double masse_de_residu_sec_dans_le_remblai_valeur_recette_4_new;
        public static double masse_de_residu_humide_dans_le_remblai_valeur_recette_4_new;
        public static double masse_de_liant_total_dans_le_remblai_valeur_Mb_recette_4_new;
        public static double masse_du_ciment_1_dans_le_remblai_valeur_recette_4_new;
        public static double masse_du_ciment_2_dans_le_remblai_valeur_recette_4_new;
        public static double masse_du_ciment_3_dans_le_remblai_valeur_recette_4_new;
        public static double asse_eau_total_dans_le_remblai_valeur_recette_4_new;
        public static double masse_eau_dans_le_residu_humide_valeur_recette_4_new;
        public static double masse_eau_a_rajouter_valeur_recette_4_new;
        public static double teneur_en_eau_volumique_valeur_recette_4_new;
        public static double masse_eau_total_dans_le_remblai_valeur_recette_4_new;
        public static double masse_volumique_remblai_valeur_recette_4_new;
        public static double rapport_eau_sur_ciment_valeur_recette_4_new;
        public static double poids_specific_liant_valeur_recette_4_new;
        public static double poids_specific_remblai_valeur_recette_4_new;
        public static double volume_contenant_valeur_recette_4_new;
        public static double teneur_en_eau_massique_remblai_valeur_recette_4_new;
        public static double masse_volumique_seche_remblai_valeur_recette_4_new;
        public static double pourcentage_solide_volumique_valeur_recette_4_new;
        public static double masse_volumique_totale_valeur_recette_4_new;
        public static double volume_total_de_remblai_valeur_recette_4_new;
        public static double volume_de_solide_du_remblai_valeur_recette_4_new;
        public static double volume_des_vides_valeur_recette_4_new;






        public static double teneur_en_eau_volumique_valeur_recette_4;
        public static double masse_eau_a_rajouter_valeur_recette_4;
        public static double rapport_eau_sur_ciment_valeur_recette_4;
        public static double masse_eau_dans_le_residu_humide_valeur_recette_4;
        public static double masse_eau_total_dans_le_remblai_valeur_recette_4;
        public static double masse_du_ciment_3_dans_le_remblai_valeur_recette_4;
        public static double masse_du_ciment_2_dans_le_remblai_valeur_recette_4;
        public static double masse_du_ciment_1_dans_le_remblai_valeur_recette_4;
        public static double masse_de_liant_total_dans_le_remblai_valeur_Mb_recette_4;
        public static double masse_de_residu_humide_dans_le_remblai_valeur_recette_4;
        public static double masse_de_residu_sec_dans_le_remblai_valeur_recette_4;
        public static double volume_eau_dans_remblai_valeur_recette_4;
        public static double volume_du_liant_dans_le_remblai_valeur_recette_4;
        public static double volume_des_rejets_dans_le_remblai_valeur_Vr_recette_4;
        public static double porosite_du_remblai_valeur_recette_4;
        public static double compacite_du_remblai_valeur_recette_4;
        public static double volume_des_vides_valeur_recette_4;
        public static double volume_de_solide_du_remblai_valeur_recette_4;
        public static double volume_total_de_remblai_valeur_recette_4;
        public static double volume_contenant_valeur_recette_4;
        public static double poids_volumique_total_valeur_recette_4;
        public static double masse_volumique_totale_valeur_recette_4;
        public static double pourcentage_volumique_de_liant_Bv_valeur_recette_4;
        public static double pourcentage_solide_volumique_valeur_recette_4;
        public static double poids_volumique_sec_valeur_recette_4;
        public static double masse_volumique_seche_remblai_valeur_recette_4;
        public static double indice_des_vides_valeur_recette_4;
        public static double poids_specific_remblai_valeur_recette_4;
        public static double masse_volumique_remblai_valeur_recette_4;
































        public  double pourcentage_massique_de_liant_recette_pour_calcul_dans_fonction;
        public  double masse_volumique_S_liant_valeur;


        public double poids_specific_liant_valeur;
        public static double poids_specific_liant_valeur_new;




        public  double poids_specific_remblai_valeur;
        public static double poids_specific_remblai_valeur_new;


        public  double masse_volumique_remblai_valeur;

        public static double nombre_de_ciment_pour_liant;






        // InfornationsPage

        public static double masse_volumique_specifique_du_ciment_1;
        public static double masse_volumique_specifique_du_ciment_2;
        public static double masse_volumique_specifique_du_ciment_3;



        public static double fraction_ciment_1;
        public static double fraction_ciment_2;
        public static double fraction_ciment_3;



        public static double section;
        public static double hauteur;

        public static double section_in;
        public static double hauteur_section_in;

        public static double Rayon_m;
        public static double hauteur_m;

        public static double Rayon_in;
        public static double hauteur_in;

        public static double longueur_m;
        public static double largeur_m;
        public static double hauteur_paralelipipede_m;

        public static double longueur_in;
        public static double largeur_in;
        public static double hauteur_paralelipipede_in;






        public static double masse_volumique_specifique_aggregat = 0;
        public static double rapport_eau_ciment_dosage_selon_rapport_recette_1 = -99;
        public static double rapport_eau_ciment_dosage_selon_rapport_recette_2 = -99;
        public static double rapport_eau_ciment_dosage_selon_rapport_recette_3 = -99;
        public static double rapport_eau_ciment_dosage_selon_rapport_recette_4 = -99;









        // calcul initiaux

        public object calcul_initiaux_1(ref double teneur_en_eau_massique_remblai_valeur, ref double indice_des_vides_valeur, 
            
            ref double poids_specific_valeur, ref double masse_volumique_seche_remblai_valeur, ref double poids_volumique_sec_valeur,
            ref double pourcentage_solide_volumique_valeur, ref double pourcentage_volumique_de_liant_Bv_valeur, ref double masse_volumique_totale_valeur, 
            ref double poids_volumique_total_valeur, ref double volume_contenant_valeur, ref double volume_total_de_remblai_valeur, ref double volume_de_solide_du_remblai_valeur,
            ref double volume_des_vides_valeur, ref double compacite_du_remblai_valeur, ref double porosite_du_remblai_valeur, ref double volume_des_rejets_dans_le_remblai_valeur_Vr, 
            ref double volume_du_liant_dans_le_remblai_valeur, ref double volume_eau_dans_remblai_valeur, ref double masse_de_residu_sec_dans_le_remblai_valeur, ref double masse_de_residu_humide_dans_le_remblai_valeur,
            ref double masse_de_liant_total_dans_le_remblai_valeur_Mb, ref double masse_du_ciment_1_dans_le_remblai_valeur, ref double masse_du_ciment_2_dans_le_remblai_valeur, ref double masse_du_ciment_3_dans_le_remblai_valeur, 
            ref double masse_eau_total_dans_le_remblai_valeur, ref double masse_eau_dans_le_residu_humide_valeur, ref double rapport_eau_sur_ciment_valeur, ref double masse_eau_a_rajouter_valeur, ref double teneur_en_eau_volumique_valeur, 
            ref double pourcentage_massique_de_liant_recette_1, ref double masse_volumique_S_liant_valeur, ref double poids_specific_liant_valeur, ref double masse_volumique_remblai_valeur, ref double poids_specific_remblai_valeur,
            ref double section, ref double hauteur, ref double masse_volumique_specifique_du_ciment_1, ref double masse_volumique_specifique_du_ciment_2, ref double masse_volumique_specifique_du_ciment_3, ref double fraction_ciment_1,
            ref double fraction_ciment_2, ref double fraction_ciment_3, ref double masse_volumique_eau, ref double masse_volumique_specifique_du_residu, ref double pourcentage_solide_massique_fixe, ref double g, ref double nombre_de_contenants, 
            ref double degre_de_saturation, ref double facteur_de_securite, ref double Rayon_m, ref double hauteur_m, ref double Rayon_in, ref double hauteur_in, ref double longueur_m, ref double largeur_m, ref double hauteur_paralelipipede_m, 
            ref double longueur_in, ref double largeur_in, ref double hauteur_paralelipipede_in, ref double section_in, ref double hauteur_section_in)
        {


            pourcentage_massique_de_liant_recette_pour_calcul_dans_fonction = pourcentage_massique_de_liant_recette_1;




            masse_volumique_S_liant_valeur = masse_volumique_S_liant_fonction(masse_volumique_S_liant_valeur, masse_volumique_specifique_du_ciment_1, masse_volumique_specifique_du_ciment_2, masse_volumique_specifique_du_ciment_3, fraction_ciment_1, fraction_ciment_2, fraction_ciment_3);




            poids_specific_liant_valeur_new = poids_specific_liant_fonction(masse_volumique_S_liant_valeur, masse_volumique_eau, poids_specific_liant_valeur_new);





            masse_volumique_remblai_valeur_new = masse_volumique_remblai_fonction(pourcentage_massique_de_liant_recette_1, masse_volumique_specifique_du_residu, masse_volumique_S_liant_valeur, masse_volumique_remblai_valeur_new);





            poids_specific_remblai_valeur_new = poids_specific_remblai_fonction(masse_volumique_remblai_valeur_new, masse_volumique_eau, poids_specific_remblai_valeur_new);

           

            teneur_en_eau_massique_remblai_valeur_new = teneur_en_eau_massique_remblai_fonction(pourcentage_solide_massique_fixe, teneur_en_eau_massique_remblai_valeur_new);




            indice_des_vides_valeur_new = indice_des_vides_fonction(degre_de_saturation, teneur_en_eau_massique_remblai_valeur_new, indice_des_vides_valeur_new, poids_specific_remblai_valeur_new);





            masse_volumique_seche_remblai_valeur_new = masse_volumique_seche_remblai_fonction(masse_volumique_remblai_valeur_new, masse_volumique_seche_remblai_valeur_new, indice_des_vides_valeur_new);





            poids_volumique_sec_valeur_new = poids_volumique_sec_fonction(poids_volumique_sec_valeur_new, g_new, masse_volumique_seche_remblai_valeur_new);




            pourcentage_solide_volumique_valeur_new = pourcentage_solide_volumique_fonction(pourcentage_solide_volumique_valeur_new, masse_volumique_seche_remblai_valeur_new, masse_volumique_remblai_valeur_new);



            pourcentage_volumique_de_liant_Bv_valeur_new = pourcentage_volumique_de_liant_Bv_fonction(ref pourcentage_volumique_de_liant_Bv_valeur_new, pourcentage_massique_de_liant_recette_1, masse_volumique_specifique_du_residu, masse_volumique_S_liant_valeur, masse_volumique_specifique_aggregat);



            masse_volumique_totale_valeur_new = masse_volumique_totale_remblai_fonction(masse_volumique_totale_valeur_new, masse_volumique_seche_remblai_valeur_new, teneur_en_eau_massique_remblai_valeur_new);





            poids_volumique_total_valeur_new = poids_volumique_total_fonction(poids_volumique_total_valeur_new, g_new, masse_volumique_totale_valeur_new);


            volume_contenant_valeur_new = volume_contenant_fonction(volume_contenant_valeur_new, section, hauteur, Rayon_m, hauteur_m, Rayon_in, hauteur_in, longueur_m, largeur_m, hauteur_paralelipipede_m, longueur_in, largeur_in, hauteur_paralelipipede_in, section_in, hauteur_section_in);


            


            volume_total_de_remblai_valeur_new = volume_total_de_rembla_fonction(volume_total_de_remblai_valeur_new, nombre_de_contenant_par_recette, facteur_de_securite_new, volume_contenant_valeur_new);


            // MsgBox(volume_total_de_remblai_valeur)


            volume_de_solide_du_remblai_valeur_new = volume_de_solide_du_remblai_fonction(volume_de_solide_du_remblai_valeur_new, pourcentage_solide_volumique_valeur_new, volume_total_de_remblai_valeur_new);





            volume_des_vides_valeur_new = volume_des_vides_fonctions(volume_des_vides_valeur_new, volume_total_de_remblai_valeur_new, volume_de_solide_du_remblai_valeur_new);



            compacite_du_remblai_valeur_new = compacite_du_remblai_fonction(compacite_du_remblai_valeur_new, volume_des_vides_valeur_new, volume_total_de_remblai_valeur_new);



            porosite_du_remblai_valeur_new = porosite_du_remblai_fonction(compacite_du_remblai_valeur_new, volume_des_vides_valeur_new, volume_total_de_remblai_valeur_new);




            volume_des_rejets_dans_le_remblai_valeur_Vr_new = volume_de_solide_du_remblai_valeur_new;


            // volume_des_rejets_dans_le_remblai_valeur_Vr = volume_des_rejets_dans_le_remblai_fonction(volume_des_rejets_dans_le_remblai_valeur_Vr, volume_de_solide_du_remblai_valeur, pourcentage_volumique_de_liant_Bv_valeur)

            // MsgBox(volume_des_rejets_dans_le_remblai_valeur_Vr)



            volume_du_liant_dans_le_remblai_valeur_new = volume_du_liant_dans_le_remblai_fonction(volume_du_liant_dans_le_remblai_valeur_new, pourcentage_volumique_de_liant_Bv_valeur_new, volume_des_rejets_dans_le_remblai_valeur_Vr_new);




            volume_eau_dans_remblai_valeur_new = volume_eau_dans_remblai_fonction(volume_eau_dans_remblai_valeur_new, degre_de_saturation, volume_des_vides_valeur_new);


           



            // calculs complementaires ( Cw%)
            // Composante rejets 

            masse_de_residu_sec_dans_le_remblai_valeur_new = masse_de_residu_sec_dans_le_remblai_fonction(masse_de_residu_sec_dans_le_remblai_valeur_new, masse_volumique_specifique_du_residu, volume_des_rejets_dans_le_remblai_valeur_Vr_new);
            // MsgBox(masse_de_residu_sec_dans_le_remblai_valeur)



            masse_de_residu_humide_dans_le_remblai_valeur_new = masse_de_residu_humide_dans_le_remblai_fonction(masse_de_residu_humide_dans_le_remblai_valeur_new, masse_de_residu_sec_dans_le_remblai_valeur_new, pourcentage_solide_massique_fixe);
            // MsgBox(masse_de_residu_humide_dans_le_remblai_valeur)



            // Composante liant

            masse_de_liant_total_dans_le_remblai_valeur_Mb_new = masse_de_liant_total_dans_le_remblai_function(masse_de_liant_total_dans_le_remblai_valeur_Mb_new, masse_volumique_S_liant_valeur, volume_du_liant_dans_le_remblai_valeur_new);




            masse_du_ciment_1_dans_le_remblai_valeur_new = masse_du_ciment_1_dans_le_remblai_fonction(masse_du_ciment_1_dans_le_remblai_valeur_new, fraction_ciment_1, masse_de_liant_total_dans_le_remblai_valeur_Mb_new);



            masse_du_ciment_2_dans_le_remblai_valeur_new = masse_du_ciment_2_dans_le_remblai_fonction(masse_du_ciment_2_dans_le_remblai_valeur_new, fraction_ciment_2, masse_de_liant_total_dans_le_remblai_valeur_Mb_new);



            masse_du_ciment_3_dans_le_remblai_valeur_new = masse_du_ciment_3_dans_le_remblai_fonction(masse_du_ciment_3_dans_le_remblai_valeur_new, fraction_ciment_3, masse_de_liant_total_dans_le_remblai_valeur_Mb_new);



            // Composante eau de melange

            masse_eau_total_dans_le_remblai_valeur_new = masse_eau_total_dans_le_remblai_fonction(masse_eau_total_dans_le_remblai_valeur_new, masse_de_residu_sec_dans_le_remblai_valeur_new, masse_du_ciment_1_dans_le_remblai_valeur_new, masse_du_ciment_2_dans_le_remblai_valeur_new, masse_du_ciment_3_dans_le_remblai_valeur_new, pourcentage_solide_massique_fixe);

            // MsgBox(masse_eau_total_dans_le_remblai_valeur)



            masse_eau_dans_le_residu_humide_valeur_new = masse_eau_dans_le_residu_humide_fonction(masse_de_residu_humide_dans_le_remblai_valeur_new, masse_de_residu_sec_dans_le_remblai_valeur_new, masse_eau_dans_le_residu_humide_valeur_new);

            // MsgBox(masse_eau_dans_le_residu_humide_valeur)

            if (rapport_eau_ciment_dosage_selon_rapport_recette_1 == -99)
                rapport_eau_sur_ciment_valeur_new = rapport_eau_sur_ciment_fonction(masse_eau_total_dans_le_remblai_valeur_new, masse_de_liant_total_dans_le_remblai_valeur_Mb_new, rapport_eau_sur_ciment_valeur_new);
            else
                rapport_eau_sur_ciment_valeur_new = rapport_eau_ciment_dosage_selon_rapport_recette_1;

            masse_eau_a_rajouter_valeur_new = masse_eau_a_rajouter_fonction(masse_eau_total_dans_le_remblai_valeur_new, masse_de_residu_humide_dans_le_remblai_valeur_new, masse_de_residu_sec_dans_le_remblai_valeur_new, masse_eau_a_rajouter_valeur_new);







            teneur_en_eau_volumique_valeur_new = teneur_en_eau_volumique_fonction(porosite_du_remblai_valeur_new, degre_de_saturation, teneur_en_eau_volumique_valeur_new);


            return default;


               












        }


       


        public object calcul_initiaux_2(ref double teneur_en_eau_volumique_valeur_recette_2, ref double masse_eau_a_rajouter_valeur_recette_2, ref double rapport_eau_sur_ciment_valeur_recette_2, ref double masse_eau_dans_le_residu_humide_valeur_recette_2, ref double masse_eau_total_dans_le_remblai_valeur_recette_2, ref double masse_du_ciment_3_dans_le_remblai_valeur_recette_2, ref double masse_du_ciment_2_dans_le_remblai_valeur_recette_2, ref double masse_du_ciment_1_dans_le_remblai_valeur_recette_2, ref double masse_de_liant_total_dans_le_remblai_valeur_Mb_recette_2, ref double masse_de_residu_humide_dans_le_remblai_valeur_recette_2, ref double masse_de_residu_sec_dans_le_remblai_valeur_recette_2, ref double volume_eau_dans_remblai_valeur_recette_2, ref double volume_du_liant_dans_le_remblai_valeur_recette_2, ref double volume_des_rejets_dans_le_remblai_valeur_Vr_recette_2, ref double porosite_du_remblai_valeur_recette_2, ref double compacite_du_remblai_valeur_recette_2, ref double volume_des_vides_valeur_recette_2, ref double volume_de_solide_du_remblai_valeur_recette_2, ref double volume_total_de_remblai_valeur_recette_2, ref double volume_contenant_valeur_recette_2, ref double poids_volumique_total_valeur_recette_2, ref double masse_volumique_totale_valeur_recette_2, ref double pourcentage_volumique_de_liant_Bv_valeur_recette_2, ref double pourcentage_solide_volumique_valeur_recette_2, ref double poids_volumique_sec_valeur_recette_2, ref double masse_volumique_seche_remblai_valeur_recette_2, ref double indice_des_vides_valeur_recette_2, ref double poids_specific_remblai_valeur_recette_2, ref double masse_volumique_remblai_valeur_recette_2, ref double masse_volumique_S_liant_valeur, ref double masse_volumique_specifique_du_ciment_1, ref double masse_volumique_specifique_du_ciment_2, ref double masse_volumique_specifique_du_ciment_3, ref double fraction_ciment_1, ref double fraction_ciment_2, ref double fraction_ciment_3, ref double poids_specific_liant_valeur, ref double masse_volumique_eau, ref double pourcentage_massique_de_liant_recette_2, ref double masse_volumique_specifique_du_residu, ref double pourcentage_solide_massique_fixe, ref double teneur_en_eau_massique_remblai_valeur, ref double degre_de_saturation, ref double g, ref double poids_volumique_sec_valeur, ref double section, ref double hauteur, ref double nombre_de_contenants, ref double facteur_de_securite, ref double Rayon_m, ref double hauteur_m, ref double Rayon_in, ref double hauteur_in, ref double longueur_m, ref double largeur_m, ref double hauteur_paralelipipede_m, ref double longueur_in, ref double largeur_in, ref double hauteur_paralelipipede_in, ref double section_in, ref double hauteur_section_in)
        {


            pourcentage_massique_de_liant_recette_pour_calcul_dans_fonction = pourcentage_massique_de_liant_recette_2;



            masse_volumique_S_liant_valeur = masse_volumique_S_liant_fonction(masse_volumique_S_liant_valeur, masse_volumique_specifique_du_ciment_1, masse_volumique_specifique_du_ciment_2, masse_volumique_specifique_du_ciment_3, fraction_ciment_1, fraction_ciment_2, fraction_ciment_3);


            poids_specific_liant_valeur_new = poids_specific_liant_fonction(masse_volumique_S_liant_valeur, masse_volumique_eau, poids_specific_liant_valeur_new);


            masse_volumique_remblai_valeur_recette_2_new = masse_volumique_remblai_fonction(pourcentage_massique_de_liant_recette_2, masse_volumique_specifique_du_residu, masse_volumique_S_liant_valeur, masse_volumique_remblai_valeur_recette_2_new);

            poids_specific_remblai_valeur_recette_2_new = poids_specific_remblai_fonction(masse_volumique_remblai_valeur_recette_2_new, masse_volumique_eau, poids_specific_remblai_valeur_recette_2_new);

            teneur_en_eau_massique_remblai_valeur_recette_2_new = teneur_en_eau_massique_remblai_fonction(pourcentage_solide_massique_fixe, teneur_en_eau_massique_remblai_valeur_recette_2_new);//teneur_en_eau_massique_remblai_valeur_new

            indice_des_vides_valeur_recette_2_new = indice_des_vides_fonction(degre_de_saturation, teneur_en_eau_massique_remblai_valeur_recette_2_new, indice_des_vides_valeur_recette_2_new, poids_specific_remblai_valeur_recette_2_new);

            masse_volumique_seche_remblai_valeur_recette_2_new = masse_volumique_seche_remblai_fonction(masse_volumique_remblai_valeur_recette_2_new, masse_volumique_seche_remblai_valeur_recette_2_new, indice_des_vides_valeur_recette_2_new);//indice_des_vides_valeur_recette_2_new;

            poids_volumique_sec_valeur_recette_2_new = poids_volumique_sec_fonction(poids_volumique_sec_valeur_recette_2_new, g_new, masse_volumique_seche_remblai_valeur_recette_2_new);//

            pourcentage_solide_volumique_valeur_recette_2_new = pourcentage_solide_volumique_fonction(pourcentage_solide_volumique_valeur_recette_2_new, masse_volumique_seche_remblai_valeur_recette_2_new, masse_volumique_remblai_valeur_recette_2_new);

            pourcentage_volumique_de_liant_Bv_valeur_recette_2_new = pourcentage_volumique_de_liant_Bv_fonction(ref pourcentage_volumique_de_liant_Bv_valeur_recette_2_new, pourcentage_massique_de_liant_recette_2, masse_volumique_specifique_du_residu, masse_volumique_S_liant_valeur, masse_volumique_specifique_aggregat);

            masse_volumique_totale_valeur_recette_2_new = masse_volumique_totale_remblai_fonction(masse_volumique_totale_valeur_recette_2_new, masse_volumique_seche_remblai_valeur_recette_2_new, teneur_en_eau_massique_remblai_valeur_recette_2_new);

            poids_volumique_total_valeur_recette_2_new = poids_volumique_total_fonction(poids_volumique_total_valeur_recette_2_new, g_new, masse_volumique_totale_valeur_recette_2_new);

            volume_contenant_valeur_recette_2_new = volume_contenant_fonction(volume_contenant_valeur_recette_2_new, section, hauteur, Rayon_m, hauteur_m, Rayon_in, hauteur_in, longueur_m, largeur_m, hauteur_paralelipipede_m, longueur_in, largeur_in, hauteur_paralelipipede_in, section_in, hauteur_section_in);

            volume_total_de_remblai_valeur_recette_2_new = volume_total_de_rembla_fonction(volume_total_de_remblai_valeur_recette_2_new, nombre_de_contenant_par_recette, facteur_de_securite_new, volume_contenant_valeur_recette_2_new);

            volume_de_solide_du_remblai_valeur_recette_2_new = volume_de_solide_du_remblai_fonction(volume_de_solide_du_remblai_valeur_recette_2_new, pourcentage_solide_volumique_valeur_recette_2_new, volume_total_de_remblai_valeur_recette_2_new);

            volume_des_vides_valeur_recette_2_new = volume_des_vides_fonctions(volume_des_vides_valeur_recette_2_new, volume_total_de_remblai_valeur_recette_2_new, volume_de_solide_du_remblai_valeur_recette_2_new);

            compacite_du_remblai_valeur_recette_2_new = compacite_du_remblai_fonction(compacite_du_remblai_valeur_recette_2_new, volume_des_vides_valeur_recette_2_new, volume_total_de_remblai_valeur_recette_2_new);

            porosite_du_remblai_valeur_recette_2_new = porosite_du_remblai_fonction(porosite_du_remblai_valeur_recette_2_new, volume_des_vides_valeur_recette_2_new, volume_total_de_remblai_valeur_recette_2_new);



            // volume_des_rejets_dans_le_remblai_valeur_Vr_recette_2 = volume_des_rejets_dans_le_remblai_fonction(volume_des_rejets_dans_le_remblai_valeur_Vr_recette_2, volume_des_vides_valeur_recette_2, pourcentage_volumique_de_liant_Bv_valeur_recette_2)

            volume_des_rejets_dans_le_remblai_valeur_Vr_recette_2_new = volume_de_solide_du_remblai_valeur_recette_2_new;

            volume_du_liant_dans_le_remblai_valeur_recette_2_new = volume_du_liant_dans_le_remblai_fonction(volume_du_liant_dans_le_remblai_valeur_recette_2_new, pourcentage_volumique_de_liant_Bv_valeur_recette_2_new, volume_des_rejets_dans_le_remblai_valeur_Vr_recette_2_new);

            volume_eau_dans_remblai_valeur_recette_2_new = volume_eau_dans_remblai_fonction(volume_eau_dans_remblai_valeur_recette_2_new, degre_de_saturation, volume_des_vides_valeur_recette_2_new);





            // calculs complementaires ( Cw%)
            // Composante rejets 

            masse_de_residu_sec_dans_le_remblai_valeur_recette_2_new = masse_de_residu_sec_dans_le_remblai_fonction(masse_de_residu_sec_dans_le_remblai_valeur_recette_2_new, masse_volumique_specifique_du_residu, volume_des_rejets_dans_le_remblai_valeur_Vr_recette_2_new);

            masse_de_residu_humide_dans_le_remblai_valeur_recette_2_new = masse_de_residu_humide_dans_le_remblai_fonction(masse_de_residu_humide_dans_le_remblai_valeur_recette_2_new, masse_de_residu_sec_dans_le_remblai_valeur_recette_2_new, pourcentage_solide_massique_fixe);

            // Composante liant

            masse_de_liant_total_dans_le_remblai_valeur_Mb_recette_2_new = masse_de_liant_total_dans_le_remblai_function(masse_de_liant_total_dans_le_remblai_valeur_Mb_recette_2_new, masse_volumique_S_liant_valeur, volume_du_liant_dans_le_remblai_valeur_recette_2_new);

            masse_du_ciment_1_dans_le_remblai_valeur_recette_2_new = masse_du_ciment_1_dans_le_remblai_fonction(masse_du_ciment_1_dans_le_remblai_valeur_recette_2_new, fraction_ciment_1, masse_de_liant_total_dans_le_remblai_valeur_Mb_recette_2_new);

            masse_du_ciment_2_dans_le_remblai_valeur_recette_2_new = masse_du_ciment_2_dans_le_remblai_fonction(masse_du_ciment_2_dans_le_remblai_valeur_recette_2_new, fraction_ciment_2, masse_de_liant_total_dans_le_remblai_valeur_Mb_recette_2_new);

            masse_du_ciment_3_dans_le_remblai_valeur_recette_2_new = masse_du_ciment_3_dans_le_remblai_fonction(masse_du_ciment_3_dans_le_remblai_valeur_recette_2_new, fraction_ciment_3, masse_de_liant_total_dans_le_remblai_valeur_Mb_recette_2_new);



            // Composante eau de melange

            masse_eau_total_dans_le_remblai_valeur_recette_2_new = masse_eau_total_dans_le_remblai_fonction(masse_eau_total_dans_le_remblai_valeur_recette_2_new, masse_de_residu_sec_dans_le_remblai_valeur_recette_2_new, masse_du_ciment_1_dans_le_remblai_valeur_recette_2_new,
                masse_du_ciment_2_dans_le_remblai_valeur_recette_2_new, masse_du_ciment_3_dans_le_remblai_valeur_recette_2_new, pourcentage_solide_massique_fixe);

            masse_eau_dans_le_residu_humide_valeur_recette_2_new = masse_eau_dans_le_residu_humide_fonction(masse_de_residu_humide_dans_le_remblai_valeur_recette_2_new, masse_de_residu_sec_dans_le_remblai_valeur_recette_2_new, masse_eau_dans_le_residu_humide_valeur_recette_2_new);

            if (rapport_eau_ciment_dosage_selon_rapport_recette_2 == -99)
                rapport_eau_sur_ciment_valeur_recette_2_new = rapport_eau_sur_ciment_fonction(masse_eau_total_dans_le_remblai_valeur_recette_2_new, masse_de_liant_total_dans_le_remblai_valeur_Mb_recette_2_new, rapport_eau_sur_ciment_valeur_recette_2_new);
            else
                rapport_eau_sur_ciment_valeur_recette_2_new = rapport_eau_ciment_dosage_selon_rapport_recette_2;

            masse_eau_a_rajouter_valeur_recette_2_new = masse_eau_a_rajouter_fonction(masse_eau_total_dans_le_remblai_valeur_new, masse_de_residu_humide_dans_le_remblai_valeur_recette_2_new, masse_de_residu_sec_dans_le_remblai_valeur_new, masse_eau_a_rajouter_valeur_recette_2_new);



            teneur_en_eau_volumique_valeur_recette_2_new = teneur_en_eau_volumique_fonction(porosite_du_remblai_valeur_recette_2_new, degre_de_saturation, teneur_en_eau_volumique_valeur_recette_2_new);
            return default;




        }






        public object calcul_initiaux_3(ref double teneur_en_eau_volumique_valeur_recette_3, ref double masse_eau_a_rajouter_valeur_recette_3, ref double rapport_eau_sur_ciment_valeur_recette_3, ref double masse_eau_dans_le_residu_humide_valeur_recette_3, ref double masse_eau_total_dans_le_remblai_valeur_recette_3, ref double masse_du_ciment_3_dans_le_remblai_valeur_recette_3, ref double masse_du_ciment_2_dans_le_remblai_valeur_recette_3, ref double masse_du_ciment_1_dans_le_remblai_valeur_recette_3, ref double masse_de_liant_total_dans_le_remblai_valeur_Mb_recette_3, ref double masse_de_residu_humide_dans_le_remblai_valeur_recette_3, ref double masse_de_residu_sec_dans_le_remblai_valeur_recette_3, ref double volume_eau_dans_remblai_valeur_recette_3, ref double volume_du_liant_dans_le_remblai_valeur_recette_3, ref double volume_des_rejets_dans_le_remblai_valeur_Vr_recette_3, ref double porosite_du_remblai_valeur_recette_3, ref double compacite_du_remblai_valeur_recette_3, ref double volume_des_vides_valeur_recette_3, ref double volume_de_solide_du_remblai_valeur_recette_3, ref double volume_total_de_remblai_valeur_recette_3, ref double volume_contenant_valeur_recette_3, ref double poids_volumique_total_valeur_recette_3, ref double masse_volumique_totale_valeur_recette_3, ref double pourcentage_volumique_de_liant_Bv_valeur_recette_3, ref double pourcentage_solide_volumique_valeur_recette_3, ref double poids_volumique_sec_valeur_recette_3, ref double masse_volumique_seche_remblai_valeur_recette_3, ref double indice_des_vides_valeur_recette_3, ref double poids_specific_remblai_valeur_recette_3, ref double masse_volumique_remblai_valeur_recette_3, ref double masse_volumique_S_liant_valeur, ref double masse_volumique_specifique_du_ciment_3, ref double fraction_ciment_1, ref double fraction_ciment_2, ref double fraction_ciment_3, ref double poids_specific_liant_valeur, ref double masse_volumique_eau, ref double pourcentage_massique_de_liant_recette_3, ref double masse_volumique_specifique_du_residu, ref double pourcentage_solide_massique_fixe, ref double teneur_en_eau_massique_remblai_valeur, ref double degre_de_saturation, ref double g, ref double poids_volumique_sec_valeur, ref double section, ref double hauteur, ref double nombre_de_contenants, ref double facteur_de_securite, ref double masse_volumique_specifique_du_ciment_1, ref double masse_volumique_specifique_du_ciment_2, ref double Rayon_m, ref double hauteur_m, ref double Rayon_in, ref double hauteur_in, ref double longueur_m, ref double largeur_m, ref double hauteur_paralelipipede_m, ref double longueur_in, ref double largeur_in, ref double hauteur_paralelipipede_in, ref double section_in, ref double hauteur_section_in)
        {



            pourcentage_massique_de_liant_recette_pour_calcul_dans_fonction = pourcentage_massique_de_liant_recette_3;



            masse_volumique_S_liant_valeur = masse_volumique_S_liant_fonction(masse_volumique_S_liant_valeur, masse_volumique_specifique_du_ciment_1, masse_volumique_specifique_du_ciment_2, masse_volumique_specifique_du_ciment_3, fraction_ciment_1, fraction_ciment_2, fraction_ciment_3);


            poids_specific_liant_valeur_new = poids_specific_liant_fonction(masse_volumique_S_liant_valeur, masse_volumique_eau, poids_specific_liant_valeur_new);


            masse_volumique_remblai_valeur_recette_3_new = masse_volumique_remblai_fonction(pourcentage_massique_de_liant_recette_pour_calcul_dans_fonction, masse_volumique_specifique_du_residu, masse_volumique_S_liant_valeur, masse_volumique_remblai_valeur_recette_3_new);

            poids_specific_remblai_valeur_recette_3_new = poids_specific_remblai_fonction(masse_volumique_remblai_valeur_recette_3_new, masse_volumique_eau, poids_specific_remblai_valeur_recette_3_new);

            teneur_en_eau_massique_remblai_valeur_recette_3_new = teneur_en_eau_massique_remblai_fonction(pourcentage_solide_massique_fixe, teneur_en_eau_massique_remblai_valeur_recette_3_new);

            indice_des_vides_valeur_recette_3_new = indice_des_vides_fonction(degre_de_saturation, teneur_en_eau_massique_remblai_valeur_recette_3_new, indice_des_vides_valeur_recette_3_new, poids_specific_remblai_valeur_recette_3_new);

            masse_volumique_seche_remblai_valeur_recette_3_new = masse_volumique_seche_remblai_fonction(masse_volumique_remblai_valeur_recette_3_new, masse_volumique_seche_remblai_valeur_recette_3_new, indice_des_vides_valeur_recette_3_new);

            poids_volumique_sec_valeur_recette_3_new = poids_volumique_sec_fonction(poids_volumique_sec_valeur_recette_3_new, g_new, masse_volumique_seche_remblai_valeur_recette_3_new);

            pourcentage_solide_volumique_valeur_recette_3_new = pourcentage_solide_volumique_fonction(pourcentage_solide_volumique_valeur_recette_3_new, masse_volumique_seche_remblai_valeur_recette_3_new, masse_volumique_remblai_valeur_recette_3_new);//

            pourcentage_volumique_de_liant_Bv_valeur_recette_3_new = pourcentage_volumique_de_liant_Bv_fonction(ref pourcentage_volumique_de_liant_Bv_valeur_recette_3, pourcentage_massique_de_liant_recette_pour_calcul_dans_fonction, masse_volumique_specifique_du_residu, masse_volumique_S_liant_valeur, masse_volumique_specifique_aggregat);

            masse_volumique_totale_valeur_recette_3_new = masse_volumique_totale_remblai_fonction(masse_volumique_totale_valeur_recette_3_new, masse_volumique_seche_remblai_valeur_recette_3_new, teneur_en_eau_massique_remblai_valeur_recette_3_new);

            poids_volumique_total_valeur_recette_3_new = poids_volumique_total_fonction(poids_volumique_total_valeur_recette_3_new, g_new, masse_volumique_totale_valeur_recette_3_new);//

            volume_contenant_valeur_recette_3_new = volume_contenant_fonction(volume_contenant_valeur_recette_3_new, section, hauteur, Rayon_m, hauteur_m, Rayon_in, hauteur_in, longueur_m, largeur_m, hauteur_paralelipipede_m, longueur_in, largeur_in, hauteur_paralelipipede_in, section_in, hauteur_section_in);

            volume_total_de_remblai_valeur_recette_3_new = volume_total_de_rembla_fonction(volume_total_de_remblai_valeur_recette_3_new, nombre_de_contenant_par_recette, facteur_de_securite_new, volume_contenant_valeur_recette_3_new);


            volume_de_solide_du_remblai_valeur_recette_3_new = volume_de_solide_du_remblai_fonction(volume_de_solide_du_remblai_valeur_recette_3_new, pourcentage_solide_volumique_valeur_recette_3_new, volume_total_de_remblai_valeur_recette_3_new);

            volume_des_vides_valeur_recette_3_new = volume_des_vides_fonctions(volume_des_vides_valeur_recette_3_new, volume_total_de_remblai_valeur_recette_3_new, volume_de_solide_du_remblai_valeur_recette_3_new);

            compacite_du_remblai_valeur_recette_3_new = compacite_du_remblai_fonction(compacite_du_remblai_valeur_recette_3_new, volume_des_vides_valeur_recette_3_new, volume_total_de_remblai_valeur_recette_3_new);

            porosite_du_remblai_valeur_recette_3_new = porosite_du_remblai_fonction(porosite_du_remblai_valeur_recette_3_new, volume_des_vides_valeur_recette_3_new, volume_total_de_remblai_valeur_recette_3_new);



            // volume_des_rejets_dans_le_remblai_valeur_Vr_recette_3 = volume_des_rejets_dans_le_remblai_fonction(volume_des_rejets_dans_le_remblai_valeur_Vr_recette_3, volume_des_vides_valeur_recette_3, pourcentage_volumique_de_liant_Bv_valeur_recette_3)

            volume_des_rejets_dans_le_remblai_valeur_Vr_recette_3_new = volume_de_solide_du_remblai_valeur_recette_3_new;



            volume_du_liant_dans_le_remblai_valeur_recette_3_new = volume_du_liant_dans_le_remblai_fonction(volume_du_liant_dans_le_remblai_valeur_recette_3_new, pourcentage_volumique_de_liant_Bv_valeur_recette_3, volume_des_rejets_dans_le_remblai_valeur_Vr_recette_3_new);

            volume_eau_dans_remblai_valeur_recette_3_new = volume_eau_dans_remblai_fonction(volume_eau_dans_remblai_valeur_recette_3_new, degre_de_saturation, volume_des_vides_valeur_recette_3_new);





            // calculs complementaires ( Cw%)
            // Composante rejets 

            masse_de_residu_sec_dans_le_remblai_valeur_recette_3_new = masse_de_residu_sec_dans_le_remblai_fonction(masse_de_residu_sec_dans_le_remblai_valeur_recette_3_new, masse_volumique_specifique_du_residu, volume_des_rejets_dans_le_remblai_valeur_Vr_recette_3_new);



            masse_de_residu_humide_dans_le_remblai_valeur_recette_3_new = masse_de_residu_humide_dans_le_remblai_fonction(masse_de_residu_humide_dans_le_remblai_valeur_recette_3_new, masse_de_residu_sec_dans_le_remblai_valeur_recette_3_new, pourcentage_solide_massique_fixe);



            // Composante liant

            masse_de_liant_total_dans_le_remblai_valeur_Mb_recette_3_new = masse_de_liant_total_dans_le_remblai_function(masse_de_liant_total_dans_le_remblai_valeur_Mb_recette_3_new, masse_volumique_S_liant_valeur, volume_du_liant_dans_le_remblai_valeur_recette_3_new);

            masse_du_ciment_1_dans_le_remblai_valeur_recette_3_new = masse_du_ciment_1_dans_le_remblai_fonction(masse_du_ciment_1_dans_le_remblai_valeur_recette_3_new, fraction_ciment_1, masse_de_liant_total_dans_le_remblai_valeur_Mb_recette_3_new);

            masse_du_ciment_2_dans_le_remblai_valeur_recette_3_new = masse_du_ciment_2_dans_le_remblai_fonction(masse_du_ciment_2_dans_le_remblai_valeur_recette_3_new, fraction_ciment_2, masse_de_liant_total_dans_le_remblai_valeur_Mb_recette_3_new);

            masse_du_ciment_3_dans_le_remblai_valeur_recette_3_new = masse_du_ciment_3_dans_le_remblai_fonction(masse_du_ciment_3_dans_le_remblai_valeur_recette_3_new, fraction_ciment_3, masse_de_liant_total_dans_le_remblai_valeur_Mb_recette_3_new);



            // Composante eau de melange

            masse_eau_total_dans_le_remblai_valeur_recette_3_new = masse_eau_total_dans_le_remblai_fonction(masse_eau_total_dans_le_remblai_valeur_recette_3_new, masse_de_residu_sec_dans_le_remblai_valeur_recette_3_new, masse_du_ciment_1_dans_le_remblai_valeur_recette_3_new,
                masse_du_ciment_2_dans_le_remblai_valeur_recette_3_new, masse_du_ciment_3_dans_le_remblai_valeur_recette_3_new, pourcentage_solide_massique_fixe);

            masse_eau_dans_le_residu_humide_valeur_recette_3_new = masse_eau_dans_le_residu_humide_fonction(masse_de_residu_humide_dans_le_remblai_valeur_recette_3_new, masse_de_residu_sec_dans_le_remblai_valeur_recette_3_new, masse_eau_dans_le_residu_humide_valeur_recette_3_new);

            if (rapport_eau_ciment_dosage_selon_rapport_recette_3 == -99)
                rapport_eau_sur_ciment_valeur_recette_3_new = rapport_eau_sur_ciment_fonction(masse_eau_total_dans_le_remblai_valeur_recette_3_new, masse_de_liant_total_dans_le_remblai_valeur_Mb_recette_3_new, rapport_eau_sur_ciment_valeur_recette_3_new);
            else
                rapport_eau_sur_ciment_valeur_recette_3_new = rapport_eau_ciment_dosage_selon_rapport_recette_3;

            masse_eau_a_rajouter_valeur_recette_3_new = masse_eau_a_rajouter_fonction(masse_eau_total_dans_le_remblai_valeur_new, masse_de_residu_humide_dans_le_remblai_valeur_recette_3_new, masse_de_residu_sec_dans_le_remblai_valeur_new, masse_eau_a_rajouter_valeur_recette_3_new);



            teneur_en_eau_volumique_valeur_recette_3_new = teneur_en_eau_volumique_fonction(porosite_du_remblai_valeur_recette_3_new, degre_de_saturation, teneur_en_eau_volumique_valeur_recette_3_new);
            return default;









        }




        public object calcul_initiaux_4(ref double teneur_en_eau_volumique_valeur_recette_4, ref double masse_eau_a_rajouter_valeur_recette_4, ref double rapport_eau_sur_ciment_valeur_recette_4, ref double masse_eau_dans_le_residu_humide_valeur_recette_4, ref double masse_eau_total_dans_le_remblai_valeur_recette_4, ref double masse_du_ciment_3_dans_le_remblai_valeur_recette_4, ref double masse_du_ciment_2_dans_le_remblai_valeur_recette_4, ref double masse_du_ciment_1_dans_le_remblai_valeur_recette_4, ref double masse_de_liant_total_dans_le_remblai_valeur_Mb_recette_4, ref double masse_de_residu_humide_dans_le_remblai_valeur_recette_4, ref double masse_de_residu_sec_dans_le_remblai_valeur_recette_4, ref double volume_eau_dans_remblai_valeur_recette_4, ref double volume_du_liant_dans_le_remblai_valeur_recette_4, ref double volume_des_rejets_dans_le_remblai_valeur_Vr_recette_4, ref double porosite_du_remblai_valeur_recette_4, ref double compacite_du_remblai_valeur_recette_4, ref double volume_des_vides_valeur_recette_4, ref double volume_de_solide_du_remblai_valeur_recette_4, ref double volume_total_de_remblai_valeur_recette_4, ref double volume_contenant_valeur_recette_4, ref double poids_volumique_total_valeur_recette_4, ref double masse_volumique_totale_valeur_recette_4, ref double pourcentage_volumique_de_liant_Bv_valeur_recette_4, ref double pourcentage_solide_volumique_valeur_recette_4, ref double poids_volumique_sec_valeur_recette_4, ref double masse_volumique_seche_remblai_valeur_recette_4, ref double indice_des_vides_valeur_recette_4, ref double poids_specific_remblai_valeur_recette_4, ref double masse_volumique_remblai_valeur_recette_4, ref double masse_volumique_S_liant_valeur, ref double masse_volumique_specifique_du_ciment_3, ref double fraction_ciment_1, ref double fraction_ciment_2, ref double fraction_ciment_3, ref double poids_specific_liant_valeur, ref double masse_volumique_eau, ref double pourcentage_massique_de_liant_recette_4, ref double masse_volumique_specifique_du_residu, ref double pourcentage_solide_massique_fixe, ref double teneur_en_eau_massique_remblai_valeur, ref double degre_de_saturation, ref double g, ref double poids_volumique_sec_valeur, ref double section, ref double hauteur, ref double nombre_de_contenants, ref double facteur_de_securite, ref double masse_volumique_specifique_du_ciment_1, ref double masse_volumique_specifique_du_ciment_2, ref double Rayon_m, ref double hauteur_m, ref double Rayon_in, ref double hauteur_in, ref double longueur_m, ref double largeur_m, ref double hauteur_paralelipipede_m, ref double longueur_in, ref double largeur_in, ref double hauteur_paralelipipede_in, ref double section_in, ref double hauteur_section_in)
        {




            pourcentage_massique_de_liant_recette_pour_calcul_dans_fonction = pourcentage_massique_de_liant_recette_4;



            masse_volumique_S_liant_valeur = masse_volumique_S_liant_fonction(masse_volumique_S_liant_valeur, masse_volumique_specifique_du_ciment_1, masse_volumique_specifique_du_ciment_2, masse_volumique_specifique_du_ciment_3, fraction_ciment_1, fraction_ciment_2, fraction_ciment_3);


            poids_specific_liant_valeur_new = poids_specific_liant_fonction(masse_volumique_S_liant_valeur, masse_volumique_eau, poids_specific_liant_valeur_new);


            masse_volumique_remblai_valeur_recette_4_new = masse_volumique_remblai_fonction(pourcentage_massique_de_liant_recette_4, masse_volumique_specifique_du_residu, masse_volumique_S_liant_valeur, masse_volumique_remblai_valeur_recette_4_new);

            poids_specific_remblai_valeur_recette_4_new = poids_specific_remblai_fonction(masse_volumique_remblai_valeur_recette_4_new, masse_volumique_eau, poids_specific_remblai_valeur_recette_4_new);

            teneur_en_eau_massique_remblai_valeur_recette_4_new = teneur_en_eau_massique_remblai_fonction(pourcentage_solide_massique_fixe, teneur_en_eau_massique_remblai_valeur_recette_4_new);

            indice_des_vides_valeur_recette_4_new = indice_des_vides_fonction(degre_de_saturation, teneur_en_eau_massique_remblai_valeur_recette_4_new, indice_des_vides_valeur_recette_4_new, poids_specific_remblai_valeur_recette_4_new);

            masse_volumique_seche_remblai_valeur_recette_4_new = masse_volumique_seche_remblai_fonction(masse_volumique_remblai_valeur_recette_4_new, masse_volumique_seche_remblai_valeur_recette_4_new, indice_des_vides_valeur_recette_4_new);

            poids_volumique_sec_valeur_recette_4_new = poids_volumique_sec_fonction(poids_volumique_sec_valeur_recette_4_new, g_new, masse_volumique_seche_remblai_valeur_recette_4_new);

            pourcentage_solide_volumique_valeur_recette_4_new = pourcentage_solide_volumique_fonction(pourcentage_solide_volumique_valeur_recette_4_new, masse_volumique_seche_remblai_valeur_recette_4_new, masse_volumique_remblai_valeur_recette_4_new);

            pourcentage_volumique_de_liant_Bv_valeur_recette_4_new = pourcentage_volumique_de_liant_Bv_fonction(ref pourcentage_volumique_de_liant_Bv_valeur_recette_4_new, pourcentage_massique_de_liant_recette_4, masse_volumique_specifique_du_residu, masse_volumique_S_liant_valeur, masse_volumique_specifique_aggregat);

            masse_volumique_totale_valeur_recette_4_new = masse_volumique_totale_remblai_fonction(masse_volumique_totale_valeur_recette_4_new, masse_volumique_seche_remblai_valeur_recette_4_new, teneur_en_eau_massique_remblai_valeur_recette_4_new);

            poids_volumique_total_valeur_recette_4_new = poids_volumique_total_fonction(poids_volumique_total_valeur_recette_4_new, g_new, masse_volumique_totale_valeur_recette_4_new);

            volume_contenant_valeur_recette_4_new = volume_contenant_fonction(volume_contenant_valeur_recette_4_new, section, hauteur, Rayon_m, hauteur_m, Rayon_in, hauteur_in, longueur_m, largeur_m, hauteur_paralelipipede_m, longueur_in, largeur_in, hauteur_paralelipipede_in, section_in, hauteur_section_in);

            volume_total_de_remblai_valeur_recette_4_new = volume_total_de_rembla_fonction(volume_total_de_remblai_valeur_recette_4_new, nombre_de_contenant_par_recette, facteur_de_securite_new, volume_contenant_valeur_recette_4_new);

            volume_de_solide_du_remblai_valeur_recette_4_new = volume_de_solide_du_remblai_fonction(volume_de_solide_du_remblai_valeur_recette_4_new, pourcentage_solide_volumique_valeur_recette_4_new, volume_total_de_remblai_valeur_recette_4_new);

            volume_des_vides_valeur_recette_4_new = volume_des_vides_fonctions(volume_des_vides_valeur_recette_4_new, volume_total_de_remblai_valeur_recette_4_new, volume_de_solide_du_remblai_valeur_recette_4_new);

            compacite_du_remblai_valeur_recette_4_new = compacite_du_remblai_fonction(compacite_du_remblai_valeur_recette_4_new, volume_des_vides_valeur_recette_4_new, volume_total_de_remblai_valeur_recette_4_new);

            porosite_du_remblai_valeur_recette_4_new = porosite_du_remblai_fonction(porosite_du_remblai_valeur_recette_4_new, volume_des_vides_valeur_recette_4_new, volume_total_de_remblai_valeur_recette_4_new);

            // volume_des_rejets_dans_le_remblai_valeur_Vr_recette_2 = volume_des_rejets_dans_le_remblai_fonction(volume_des_rejets_dans_le_remblai_valeur_Vr_recette_2, volume_des_vides_valeur_recette_2, pourcentage_volumique_de_liant_Bv_valeur_recette_2)

            volume_des_rejets_dans_le_remblai_valeur_Vr_recette_4_new = volume_de_solide_du_remblai_valeur_recette_4_new;


            volume_du_liant_dans_le_remblai_valeur_recette_4_new = volume_du_liant_dans_le_remblai_fonction(volume_du_liant_dans_le_remblai_valeur_recette_4_new, pourcentage_volumique_de_liant_Bv_valeur_recette_4_new, volume_des_rejets_dans_le_remblai_valeur_Vr_recette_4_new);

            volume_eau_dans_remblai_valeur_recette_4_new = volume_eau_dans_remblai_fonction(volume_eau_dans_remblai_valeur_recette_4_new, degre_de_saturation, volume_des_vides_valeur_recette_4_new);





            // calculs complementaires ( Cw%)
            // Composante rejets 

            masse_de_residu_sec_dans_le_remblai_valeur_recette_4_new = masse_de_residu_sec_dans_le_remblai_fonction(masse_de_residu_sec_dans_le_remblai_valeur_recette_4_new, masse_volumique_specifique_du_residu, volume_des_rejets_dans_le_remblai_valeur_Vr_recette_4_new);

            masse_de_residu_humide_dans_le_remblai_valeur_recette_4_new = masse_de_residu_humide_dans_le_remblai_fonction(masse_de_residu_humide_dans_le_remblai_valeur_recette_4_new, masse_de_residu_sec_dans_le_remblai_valeur_recette_4_new, pourcentage_solide_massique_fixe);

            // Composante liant

            masse_de_liant_total_dans_le_remblai_valeur_Mb_recette_4_new = masse_de_liant_total_dans_le_remblai_function(masse_de_liant_total_dans_le_remblai_valeur_Mb_recette_4_new, masse_volumique_S_liant_valeur, volume_du_liant_dans_le_remblai_valeur_recette_4_new);

            masse_du_ciment_1_dans_le_remblai_valeur_recette_4_new = masse_du_ciment_1_dans_le_remblai_fonction(masse_du_ciment_1_dans_le_remblai_valeur_recette_4_new, fraction_ciment_1, masse_de_liant_total_dans_le_remblai_valeur_Mb_recette_4_new);

            masse_du_ciment_2_dans_le_remblai_valeur_recette_4_new = masse_du_ciment_2_dans_le_remblai_fonction(masse_du_ciment_2_dans_le_remblai_valeur_recette_4_new, fraction_ciment_2, masse_de_liant_total_dans_le_remblai_valeur_Mb_recette_4_new);

            masse_du_ciment_3_dans_le_remblai_valeur_recette_4_new = masse_du_ciment_3_dans_le_remblai_fonction(masse_du_ciment_3_dans_le_remblai_valeur_recette_4_new, fraction_ciment_3, masse_de_liant_total_dans_le_remblai_valeur_Mb_recette_4_new);



            // Composante eau de melange

            masse_eau_total_dans_le_remblai_valeur_recette_4_new = masse_eau_total_dans_le_remblai_fonction(masse_eau_total_dans_le_remblai_valeur_recette_4_new, masse_de_residu_sec_dans_le_remblai_valeur_recette_4_new, 
                masse_du_ciment_1_dans_le_remblai_valeur_recette_4_new, masse_du_ciment_2_dans_le_remblai_valeur_recette_4_new, masse_du_ciment_3_dans_le_remblai_valeur_recette_4_new, pourcentage_solide_massique_fixe);

            masse_eau_dans_le_residu_humide_valeur_recette_4_new = masse_eau_dans_le_residu_humide_fonction(masse_de_residu_humide_dans_le_remblai_valeur_recette_4_new, masse_de_residu_sec_dans_le_remblai_valeur_recette_4_new, masse_eau_dans_le_residu_humide_valeur_recette_4_new);

            if (rapport_eau_ciment_dosage_selon_rapport_recette_4 == -99)
                rapport_eau_sur_ciment_valeur_recette_4_new = rapport_eau_sur_ciment_fonction(masse_eau_total_dans_le_remblai_valeur_recette_4_new, masse_de_liant_total_dans_le_remblai_valeur_Mb_recette_4_new, rapport_eau_sur_ciment_valeur_recette_4_new);
            else
                rapport_eau_sur_ciment_valeur_recette_4_new = rapport_eau_ciment_dosage_selon_rapport_recette_4;

            masse_eau_a_rajouter_valeur_recette_4_new = masse_eau_a_rajouter_fonction(masse_eau_total_dans_le_remblai_valeur_new, masse_de_residu_humide_dans_le_remblai_valeur_recette_4_new, masse_de_residu_sec_dans_le_remblai_valeur_new, masse_eau_a_rajouter_valeur_recette_4_new);



            teneur_en_eau_volumique_valeur_recette_4_new = teneur_en_eau_volumique_fonction(porosite_du_remblai_valeur_recette_4_new, degre_de_saturation, teneur_en_eau_volumique_valeur_recette_4_new);
            return default;








        }







        // Functions
        public double masse_volumique_S_liant_fonction(double masse_volumique_S_liant_valeur, double masse_volumique_specifique_du_ciment_1, double masse_volumique_specifique_du_ciment_2, double masse_volumique_specifique_du_ciment_3, double fraction_ciment_1, double fraction_ciment_2, double fraction_ciment_3)
        {



            // If masse_volumique_specifique_du_ciment_3 = Nullable Then
            // masse_volumique_S_liant_variable_function = 1 / (((0.01) * fraction_ciment_1 / masse_volumique_specifique_du_ciment_1) + ((0.01) * fraction_ciment_2 / masse_volumique_specifique_du_ciment_2))
            // ElseIf masse_volumique_specifique_du_ciment_3 <> "" Then

            if (fraction_ciment_3 > 0)
            {
                masse_volumique_S_liant_valeur = 1d / ((0.01d * fraction_ciment_1) / masse_volumique_specifique_du_ciment_1 + 0.01d * fraction_ciment_2 / masse_volumique_specifique_du_ciment_2 + 0.01d * fraction_ciment_3 / masse_volumique_specifique_du_ciment_3);
            }
            else
            {
                masse_volumique_S_liant_valeur = 1d / ((0.01d * fraction_ciment_1) / masse_volumique_specifique_du_ciment_1 + 0.01d * fraction_ciment_2 / masse_volumique_specifique_du_ciment_2 );
            }

            // End If



            return masse_volumique_S_liant_valeur;

        }

        public double poids_specific_liant_fonction(double masse_volumique_S_liant_valeur, double masse_volumique_eau, double poids_specific_liant_valeur)
        {

            poids_specific_liant_valeur = masse_volumique_S_liant_valeur / masse_volumique_eau;

            return poids_specific_liant_valeur;


        }

        public double masse_volumique_remblai_fonction(double pourcentage_massique_de_liant_recette_pour_calcul_dans_fonction, double masse_volumique_specifique_du_residu, double masse_volumique_S_liant_valeur, double masse_volumique_remblai_valeur)
        {

            masse_volumique_remblai_valeur = 100d + pourcentage_massique_de_liant_recette_pour_calcul_dans_fonction;
            double denominateur = 1d / masse_volumique_specifique_du_residu + 0.01d * pourcentage_massique_de_liant_recette_pour_calcul_dans_fonction * (1d / masse_volumique_S_liant_valeur);
            masse_volumique_remblai_valeur = masse_volumique_remblai_valeur / denominateur / 100d;

            return masse_volumique_remblai_valeur;


        }


        public double poids_specific_remblai_fonction(double masse_volumique_remblai_valeur, double masse_volumique_eau, double poids_specific_remblai_valeur)
        {
            

            poids_specific_remblai_valeur = masse_volumique_remblai_valeur / masse_volumique_eau;

            return poids_specific_remblai_valeur;

        }


        public double teneur_en_eau_massique_remblai_fonction(double pourcentage_solide_massique_fixe, double teneur_en_eau_massique_remblai_valeur)
        {

            teneur_en_eau_massique_remblai_valeur = 100d / pourcentage_solide_massique_fixe - 1d;

            return teneur_en_eau_massique_remblai_valeur;

        }

        public double indice_des_vides_fonction(double degre_de_saturation, double teneur_en_eau_massique_remblai_valeur, double indice_des_vides_valeur, double poids_specific_remblai_valeur)
        {
            double denominateur = 0.01d * degre_de_saturation;

            indice_des_vides_valeur = teneur_en_eau_massique_remblai_valeur * (poids_specific_remblai_valeur / denominateur);

            return indice_des_vides_valeur;

        }


        public double masse_volumique_seche_remblai_fonction(double masse_volumique_remblai_valeur, double masse_volumique_seche_remblai_valeur, double indice_des_vides_valeur)
        {

            masse_volumique_seche_remblai_valeur = masse_volumique_remblai_valeur / (1d + indice_des_vides_valeur);

            return masse_volumique_seche_remblai_valeur;


        }


        public double poids_volumique_sec_fonction(double poids_volumique_sec_valeur, double g, double masse_volumique_seche_remblai_valeur)
        {

            poids_volumique_sec_valeur = (g * masse_volumique_seche_remblai_valeur);


            return poids_volumique_sec_valeur;

        }


        public double pourcentage_solide_volumique_fonction(double pourcentage_solide_volumique_valeur, double masse_volumique_seche_remblai_valeur, double masse_volumique_remblai_valeur)
        {

            double denominateur = masse_volumique_remblai_valeur;

            pourcentage_solide_volumique_valeur = masse_volumique_seche_remblai_valeur / denominateur;

            return pourcentage_solide_volumique_valeur;

        }


        public double pourcentage_volumique_de_liant_Bv_fonction(ref double pourcentage_volumique_de_liant_Bv_valeur, double pourcentage_massique_de_liant_recette_pour_calcul_dans_fonction, double masse_volumique_specifique_du_residu, double masse_volumique_S_liant_valeur, double masse_volumique_specifique_aggregat)
        {

            if (masse_volumique_specifique_aggregat == 0d)
            {

                pourcentage_volumique_de_liant_Bv_valeur = 0.01d * pourcentage_massique_de_liant_recette_pour_calcul_dans_fonction * (masse_volumique_specifique_du_residu / masse_volumique_S_liant_valeur);
            }

            else
            {
                pourcentage_volumique_de_liant_Bv_valeur = 0.01d * pourcentage_massique_de_liant_recette_pour_calcul_dans_fonction * (Math.Pow(A_m / masse_volumique_specifique_aggregat + (1d - A_m) / masse_volumique_specifique_du_residu, -1) / masse_volumique_S_liant_valeur);


            }

            return pourcentage_volumique_de_liant_Bv_valeur;
        }


        public double masse_volumique_totale_remblai_fonction(double masse_volumique_totale_valeur, double masse_volumique_seche_remblai_valeur, double teneur_en_eau_massique_remblai_valeur)
        {

            masse_volumique_totale_valeur = masse_volumique_seche_remblai_valeur * (1d + teneur_en_eau_massique_remblai_valeur);

            return masse_volumique_totale_valeur;

        }


        public double poids_volumique_total_fonction(double poids_volumique_total_valeur, double g, double masse_volumique_totale_valeur)
        {

            poids_volumique_total_valeur = g * masse_volumique_totale_valeur;

            return poids_volumique_total_valeur;

        }




        public double volume_contenant_fonction(double volume_contenant_valeur, double section, double hauteur, double Rayon_m, double hauteur_m, double Rayon_in, double hauteur_in, double longueur_m, double largeur_m, double hauteur_paralelipipede_m, double longueur_in, double largeur_in, double hauteur_paralelipipede_in, double section_in, double hauteur_section_in)
        {
            if (section_in == 0d & Rayon_m == 0d | Rayon_in == 0d & longueur_m == 0d & longueur_in == 0d)
                volume_contenant_valeur = section * 0.01d * (hauteur * 0.01d);
            if (section == 0d & Rayon_m == 0d & Rayon_in == 0d & longueur_m == 0d & longueur_in == 0d)
                volume_contenant_valeur = section_in * 0.01d * 2.54d * (hauteur_in * 2.54d * 0.01d);
            if (section == 0d & section_in == 0d & Rayon_in == 0d & longueur_m == 0d & longueur_in == 0d)
                volume_contenant_valeur = Math.PI * (Rayon_m * 0.01d) * (Rayon_m * 2.54d * 0.01d) * (hauteur_m * 0.01d * 2.54d);
            if (section == 0d & section_in == 0d & Rayon_m == 0d & longueur_m == 0d & longueur_in == 0d)
                volume_contenant_valeur = Math.PI * (Rayon_in * 2.54d * 0.01d) * (Rayon_in * 2.54d * 0.01d) * (hauteur_in * 2.54d * 0.01d);
            if (section == 0d & section_in == 0d & Rayon_m == 0d & Rayon_in == 0d & longueur_in == 0d)
                volume_contenant_valeur = longueur_m * 0.01d * (largeur_m * 0.01d) * (hauteur_paralelipipede_m * 0.01d);
            if (section == 0d & section_in == 0d & Rayon_m == 0d & Rayon_in == 0d & longueur_m == 0d)
                volume_contenant_valeur = longueur_in * 2.54d * 0.01d * (largeur_in * 2.54d * 0.01d) * (hauteur_paralelipipede_in * 2.54d * 0.01d);


            return volume_contenant_valeur;

        }



        public double volume_total_de_rembla_fonction(double volume_total_de_remblai_valeur, double nombre_de_contenants, double facteur_de_securite, double volume_contenant_valeur)
        {

            volume_total_de_remblai_valeur = nombre_de_contenants * volume_contenant_valeur * facteur_de_securite;

            return volume_total_de_remblai_valeur;

        }


        public double volume_de_solide_du_remblai_fonction(double volume_de_solide_du_remblai_valeur, double pourcentage_solide_volumique_valeur, double volume_total_de_remblai_valeur)
        {


            volume_de_solide_du_remblai_valeur = pourcentage_solide_volumique_valeur * volume_total_de_remblai_valeur;

            return volume_de_solide_du_remblai_valeur;

        }


        public double volume_des_vides_fonctions(double volume_des_vides_valeur, double volume_total_de_remblai_valeur, double volume_de_solide_du_remblai_valeur)
        {


            volume_des_vides_valeur = volume_total_de_remblai_valeur - volume_de_solide_du_remblai_valeur;

            // MsgBox(volume_total_de_remblai_valeur)
            // MsgBox(volume_de_solide_du_remblai_valeur)



            return volume_des_vides_valeur;

        }

        public double compacite_du_remblai_fonction(double compacite_du_remblai_valeur, double volume_des_vides_valeur, double volume_total_de_remblai_valeur)
        {

            compacite_du_remblai_valeur = volume_des_vides_valeur / volume_total_de_remblai_valeur;

            return compacite_du_remblai_valeur;
        }


        public double porosite_du_remblai_fonction(double porosite_du_remblai_valeur, double volume_des_vides_valeur, double volume_total_de_remblai_valeur)
        {

            porosite_du_remblai_valeur = volume_des_vides_valeur / volume_total_de_remblai_valeur;

            return porosite_du_remblai_valeur;

        }


        public double volume_des_rejets_dans_le_remblai_fonction(double volume_des_rejets_dans_le_remblai_valeur_Vr, double volume_de_solide_du_remblai_valeur, double pourcentage_volumique_de_liant_Bv_valeur)
        {

            volume_des_rejets_dans_le_remblai_valeur_Vr = volume_de_solide_du_remblai_valeur / (1d + pourcentage_volumique_de_liant_Bv_valeur);


            return volume_des_rejets_dans_le_remblai_valeur_Vr;

        }


        public double volume_du_liant_dans_le_remblai_fonction(double volume_du_liant_dans_le_remblai_valeur, double pourcentage_volumique_de_liant_Bv_valeur, double volume_des_rejets_dans_le_remblai_valeur_Vr)
        {


            volume_du_liant_dans_le_remblai_valeur = pourcentage_volumique_de_liant_Bv_valeur * volume_des_rejets_dans_le_remblai_valeur_Vr;

            return volume_du_liant_dans_le_remblai_valeur;

        }

        public double volume_eau_dans_remblai_fonction(double volume_eau_dans_remblai_valeur, double degre_de_saturation, double volume_des_vides_valeur)
        {

            volume_eau_dans_remblai_valeur = 0.01d * degre_de_saturation * volume_des_vides_valeur;



            // MsgBox(volume_des_vides_valeur)



            return volume_eau_dans_remblai_valeur;

        }

        // Calculs complementaires dosage selon Cw%
        // Composants rejets 

        public double masse_de_residu_sec_dans_le_remblai_fonction(double masse_de_residu_sec_dans_le_remblai_valeur, double masse_volumique_specifique_du_residu, double volume_des_rejets_dans_le_remblai_valeur_Vr)
        {

            masse_de_residu_sec_dans_le_remblai_valeur = masse_volumique_specifique_du_residu * volume_des_rejets_dans_le_remblai_valeur_Vr;

            return masse_de_residu_sec_dans_le_remblai_valeur;



        }


        public double masse_de_residu_humide_dans_le_remblai_fonction(double masse_de_residu_humide_dans_le_remblai_valeur, double masse_de_residu_sec_dans_le_remblai_valeur, double pourcentage_solide_massique_fixe)
        {


            masse_de_residu_humide_dans_le_remblai_valeur = masse_de_residu_sec_dans_le_remblai_valeur * (1d + 0.01d * teneur_en_eau_massique_du_residu);

            // MsgBox(masse_de_residu_sec_dans_le_remblai_valeur)
            // MsgBox(masse_de_residu_humide_dans_le_remblai_valeur)

            return masse_de_residu_humide_dans_le_remblai_valeur;


        }

        // Composante liant

        public double masse_de_liant_total_dans_le_remblai_function(double masse_de_liant_total_dans_le_remblai_valeur_Mb, double masse_volumique_S_liant_valeur, double volume_du_liant_dans_le_remblai_valeur)
        {

            masse_de_liant_total_dans_le_remblai_valeur_Mb = masse_volumique_S_liant_valeur * volume_du_liant_dans_le_remblai_valeur;

            return masse_de_liant_total_dans_le_remblai_valeur_Mb;

        }



        public double masse_du_ciment_1_dans_le_remblai_fonction(double masse_du_ciment_1_dans_le_remblai_valeur, double fraction_ciment_1, double masse_de_liant_total_dans_le_remblai_valeur_Mb)
        {


            masse_du_ciment_1_dans_le_remblai_valeur = 0.01d * fraction_ciment_1 * masse_de_liant_total_dans_le_remblai_valeur_Mb;

            return masse_du_ciment_1_dans_le_remblai_valeur;




        }




        public double masse_du_ciment_2_dans_le_remblai_fonction(double masse_du_ciment_2_dans_le_remblai_valeur, double fraction_ciment_2, double masse_de_liant_total_dans_le_remblai_valeur_Mb)
        {


            masse_du_ciment_2_dans_le_remblai_valeur = 0.01d * fraction_ciment_2 * masse_de_liant_total_dans_le_remblai_valeur_Mb;

            return masse_du_ciment_2_dans_le_remblai_valeur;



        }


        public double masse_du_ciment_3_dans_le_remblai_fonction(double masse_du_ciment_3_dans_le_remblai_valeur, double fraction_ciment_3, double masse_de_liant_total_dans_le_remblai_valeur_Mb)
        {



            masse_du_ciment_3_dans_le_remblai_valeur = 0.01d * fraction_ciment_3 * masse_de_liant_total_dans_le_remblai_valeur_Mb;

            return masse_du_ciment_3_dans_le_remblai_valeur;






        }





        // Composante eau de melange 

        // Public Function masse_eau_total_dans_le_remblai_fonction(masse_volumique_eau As Double, volume_eau_dans_remblai_valeur As Double, masse_eau_total_dans_le_remblai_valeur As Double) As Double

        // masse_eau_total_dans_le_remblai_valeur = (masse_de_residu_sec_dans_le_remblai_valeur + masse_du_ciment_1_dans_le_remblai_valeur + masse_du_ciment_2_dans_le_remblai_valeur + masse_du_ciment_3_dans_le_remblai_valeur) * ((100 / pourcentage_solide_massique_fixe) - 1)

        // masse_eau_total_dans_le_remblai_valeur = masse_volumique_eau * (volume_eau_dans_remblai_valeur)

        // Return masse_eau_total_dans_le_remblai_valeur





        // End Function



        public double masse_eau_total_dans_le_remblai_fonction(double masse_eau_total_dans_le_remblai_valeur, double masse_de_residu_sec_dans_le_remblai_valeur, double masse_du_ciment_1_dans_le_remblai_valeur, double masse_du_ciment_2_dans_le_remblai_valeur,double masse_du_ciment_3_dans_le_remblai_valeur, double pourcentage_solide_massique_fixe)
        {



            masse_eau_total_dans_le_remblai_valeur = (masse_de_residu_sec_dans_le_remblai_valeur + masse_du_ciment_1_dans_le_remblai_valeur + masse_du_ciment_2_dans_le_remblai_valeur + masse_du_ciment_3_dans_le_remblai_valeur) * (100d / pourcentage_solide_massique_fixe - 1d);



            return masse_eau_total_dans_le_remblai_valeur;





        }





        public double masse_eau_dans_le_residu_humide_fonction(double masse_de_residu_humide_dans_le_remblai_valeur, double masse_de_residu_sec_dans_le_remblai_valeur, double masse_eau_dans_le_residu_humide_valeur)
        {



            masse_eau_dans_le_residu_humide_valeur = masse_de_residu_humide_dans_le_remblai_valeur - masse_de_residu_sec_dans_le_remblai_valeur;

            return masse_eau_dans_le_residu_humide_valeur;





        }






        public double rapport_eau_sur_ciment_fonction(double masse_eau_total_dans_le_remblai_valeur, double masse_de_liant_total_dans_le_remblai_valeur_Mb, double rapport_eau_sur_ciment_valeur)
        {



            rapport_eau_sur_ciment_valeur = masse_eau_total_dans_le_remblai_valeur / masse_de_liant_total_dans_le_remblai_valeur_Mb;

            // MsgBox(rapport_eau_sur_ciment_valeur)



            return rapport_eau_sur_ciment_valeur;


        }





        public double masse_eau_a_rajouter_fonction(double masse_eau_total_dans_le_remblai_valeur, double masse_de_residu_humide_dans_le_remblai_valeur, double masse_de_residu_sec_dans_le_remblai_valeur, double masse_eau_a_rajouter_valeur)
        {





            masse_eau_a_rajouter_valeur = masse_eau_total_dans_le_remblai_valeur - (masse_de_residu_humide_dans_le_remblai_valeur - masse_de_residu_sec_dans_le_remblai_valeur);




            return masse_eau_a_rajouter_valeur;



        }





        // Public Function masse_eau_a_rajouter_fonction(masse_eau_total_dans_le_remblai_valeur As Double, masse_eau_dans_le_residu_humide_valeur As Double, masse_eau_a_rajouter_valeur As Double) As Double





        // masse_eau_a_rajouter_valeur = masse_eau_total_dans_le_remblai_valeur - masse_eau_dans_le_residu_humide_valeur



        // Return masse_eau_a_rajouter_valeur



        // End Function




        public double teneur_en_eau_volumique_fonction(double porosite_du_remblai_valeur, double degre_de_saturation, double teneur_en_eau_volumique_valeur)
        {



            teneur_en_eau_volumique_valeur = porosite_du_remblai_valeur * (0.01d * degre_de_saturation);

            return teneur_en_eau_volumique_valeur;





        }




       

























        public Dosage_selon_Cw()
        {
            this.InitializeComponent();

            










        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {

            pourcentage_solide_massique_fixe = NumberBoxSpinButton_Dosage_Cw_1.Value;
            degre_de_saturation = NumberBoxSpinButton_Dosage_Cw_2.Value;
            masse_volumique_specifique_du_residu=NumberBoxSpinButton_Dosage_Cw_3.Value;
            teneur_en_eau_massique_du_residu = NumberBoxSpinButton_Dosage_Cw_4.Value;
            
            nombre_de_contenant_par_recette = NumberBoxSpinButton_Dosage_Cw__.Value;
            facteur_de_securite_new = NumberBoxSpinButton_Dosage_Cw_6.Value;
            pourcentage_massique_de_liant_recette_1 = NumberBoxSpinButton_Dosage_Cw_7.Value;
            pourcentage_massique_de_liant_recette_2 = NumberBoxSpinButton_Dosage_Cw_8.Value;
            pourcentage_massique_de_liant_recette_3 = NumberBoxSpinButton_Dosage_Cw_9.Value;
            pourcentage_massique_de_liant_recette_4 = NumberBoxSpinButton_Dosage_Cw_10.Value;


            fraction_ciment_1 = InformationsPage.fraction_ciment_1;
            fraction_ciment_2 = InformationsPage.fraction_ciment_2;
            fraction_ciment_3 = InformationsPage.fraction_ciment_3;

            nombre_de_ciment_pour_liant= InformationsPage.nombre_de_ciment_pour_liant;








            if (InformationsPage.nom_liant_1 == "Ciment_CP50_ciment_1")
            {
                masse_volumique_specifique_du_ciment_1 = 3.1543;
            }
            else if (InformationsPage.nom_liant_1 == "Slag_ciment_1")
            {
                masse_volumique_specifique_du_ciment_1 = 2.8426;
            }
            else if (InformationsPage.nom_liant_1 == "Fly_Ash_ciment_1")
            {
                masse_volumique_specifique_du_ciment_1 = 2.6114;
            }
            else if (InformationsPage.nom_liant_1 == "Ciment_CP10_ciment_1")
            {
                masse_volumique_specifique_du_ciment_1 = 3.1543;
            }
            else if (InformationsPage.nom_liant_1 == "Chaux_ciment_1")
            { masse_volumique_specifique_du_ciment_1 = 2.66; }




            if (InformationsPage.nom_liant_2 == "Ciment_CP50_ciment_2")
            {
                masse_volumique_specifique_du_ciment_2 = 3.1543;
            }
            else if (InformationsPage.nom_liant_2 == "Slag_ciment_2")
            {
                masse_volumique_specifique_du_ciment_2 = 2.8426;
            }
            else if (InformationsPage.nom_liant_2 == "Fly_Ash_ciment_2")
            {
                masse_volumique_specifique_du_ciment_2 = 2.6114;
            }
            else if (InformationsPage.nom_liant_2 == "Ciment_CP10_ciment_2")
            {
                masse_volumique_specifique_du_ciment_2 = 3.1543;
            }
            else if (InformationsPage.nom_liant_2 == "Chaux_ciment_2")
            { masse_volumique_specifique_du_ciment_2 = 2.66; }




            if (InformationsPage.nom_liant_3 == "Ciment_CP50_ciment_3")
            {
                masse_volumique_specifique_du_ciment_3 = 3.1543;
            }
            else if (InformationsPage.nom_liant_3 == "Slag_ciment_3")
            {
                masse_volumique_specifique_du_ciment_3 = 2.8426;
            }
            else if (InformationsPage.nom_liant_3 == "Fly_Ash_ciment_3")
            {
                masse_volumique_specifique_du_ciment_3 = 2.6114;
            }
            else if (InformationsPage.nom_liant_3 == "Ciment_CP10_ciment_3")
            {
                masse_volumique_specifique_du_ciment_3 = 3.1543;
            }
            else if (InformationsPage.nom_liant_3 == "Chaux_ciment_3")
            { masse_volumique_specifique_du_ciment_3 = 2.66; }




            section = Section_et_hauteur_metre.section_m;
            hauteur = Section_et_hauteur_metre.hauteur_m;

            section_in = Section_et_hauteur_inch.section_in;
            hauteur_section_in = Section_et_hauteur_inch.hauteur_in;

            Rayon_m = Rayon_et_hauteur_metre.rayon_m;
            hauteur_m = Rayon_et_hauteur_metre.hauteur_m;

            Rayon_in = Rayon_et_hauteur_inch.rayon_in;
            hauteur_in = Rayon_et_hauteur_inch.hauteur_in;

            longueur_m = Longueur_largeur_et_hauteur_metre.longueur_m;
            largeur_m = Longueur_largeur_et_hauteur_metre.largeur_m;
            hauteur_paralelipipede_m = Longueur_largeur_et_hauteur_metre.hauteur_m;

            longueur_in = Longeur_largeur_hauteur_inch.longueur_in;
            largeur_in = Longeur_largeur_hauteur_inch.largeur_in;
            hauteur_paralelipipede_in = Longeur_largeur_hauteur_inch.hauteur_in;




            calcul_initiaux_1(ref teneur_en_eau_massique_remblai_valeur, ref indice_des_vides_valeur, ref poids_specific_valeur, ref masse_volumique_seche_remblai_valeur, ref poids_volumique_sec_valeur, 
                ref pourcentage_solide_volumique_valeur, ref pourcentage_volumique_de_liant_Bv_valeur, ref masse_volumique_totale_valeur, ref poids_volumique_total_valeur, ref volume_contenant_valeur, 
                ref volume_total_de_remblai_valeur, ref volume_de_solide_du_remblai_valeur, ref volume_des_vides_valeur, ref compacite_du_remblai_valeur, ref porosite_du_remblai_valeur, 
                ref volume_des_rejets_dans_le_remblai_valeur_Vr, ref volume_du_liant_dans_le_remblai_valeur, ref volume_eau_dans_remblai_valeur, ref masse_de_residu_sec_dans_le_remblai_valeur, 
                ref masse_de_residu_humide_dans_le_remblai_valeur, ref masse_de_liant_total_dans_le_remblai_valeur_Mb, ref masse_du_ciment_1_dans_le_remblai_valeur, ref masse_du_ciment_2_dans_le_remblai_valeur, 
                ref masse_du_ciment_3_dans_le_remblai_valeur, ref masse_eau_total_dans_le_remblai_valeur, ref masse_eau_dans_le_residu_humide_valeur, ref rapport_eau_sur_ciment_valeur, ref masse_eau_a_rajouter_valeur, 
                ref teneur_en_eau_volumique_valeur, ref pourcentage_massique_de_liant_recette_1, ref masse_volumique_S_liant_valeur, ref poids_specific_liant_valeur, ref masse_volumique_remblai_valeur,
                ref poids_specific_remblai_valeur, ref section, ref hauteur, ref masse_volumique_specifique_du_ciment_1, ref masse_volumique_specifique_du_ciment_2, ref masse_volumique_specifique_du_ciment_3,
                ref fraction_ciment_1, ref fraction_ciment_2, ref fraction_ciment_3, ref masse_volumique_eau, ref masse_volumique_specifique_du_residu, ref pourcentage_solide_massique_fixe, ref g,
                ref nombre_de_contenants, ref degre_de_saturation, ref facteur_de_securite, ref Rayon_m , ref hauteur_m, ref Rayon_in, ref hauteur_in, 
                ref longueur_m, ref largeur_m, ref hauteur_paralelipipede_m, ref longueur_in, ref largeur_in, ref hauteur_paralelipipede_in, 
                ref section_in, ref hauteur_section_in);


            calcul_initiaux_2(ref teneur_en_eau_volumique_valeur_recette_2, ref masse_eau_a_rajouter_valeur_recette_2, ref rapport_eau_sur_ciment_valeur_recette_2, ref masse_eau_dans_le_residu_humide_valeur_recette_2,
                ref masse_eau_total_dans_le_remblai_valeur_recette_2, ref masse_du_ciment_3_dans_le_remblai_valeur_recette_2, ref masse_du_ciment_2_dans_le_remblai_valeur_recette_2, 
                ref masse_du_ciment_1_dans_le_remblai_valeur_recette_2, ref masse_de_liant_total_dans_le_remblai_valeur_Mb_recette_2, ref masse_de_residu_humide_dans_le_remblai_valeur_recette_2, 
                ref masse_de_residu_sec_dans_le_remblai_valeur_recette_2, ref volume_eau_dans_remblai_valeur_recette_2, ref volume_du_liant_dans_le_remblai_valeur_recette_2, 
                ref volume_des_rejets_dans_le_remblai_valeur_Vr_recette_2, ref porosite_du_remblai_valeur_recette_2, ref compacite_du_remblai_valeur_recette_2, ref volume_des_vides_valeur_recette_2,
                ref volume_de_solide_du_remblai_valeur_recette_2, ref volume_total_de_remblai_valeur_recette_2, ref volume_contenant_valeur_recette_2, ref poids_volumique_total_valeur_recette_2, 
                ref masse_volumique_totale_valeur_recette_2, ref pourcentage_volumique_de_liant_Bv_valeur_recette_2, ref pourcentage_solide_volumique_valeur_recette_2, ref poids_volumique_sec_valeur_recette_2, 
                ref masse_volumique_seche_remblai_valeur_recette_2, ref indice_des_vides_valeur_recette_2, ref poids_specific_remblai_valeur_recette_2, ref masse_volumique_remblai_valeur_recette_2,
                ref masse_volumique_S_liant_valeur, ref masse_volumique_specifique_du_ciment_1, ref masse_volumique_specifique_du_ciment_2, ref masse_volumique_specifique_du_ciment_3, ref fraction_ciment_1, 
                ref fraction_ciment_2, ref fraction_ciment_3, ref poids_specific_liant_valeur, ref masse_volumique_eau, ref pourcentage_massique_de_liant_recette_2, ref masse_volumique_specifique_du_residu, 
                ref pourcentage_solide_massique_fixe, ref teneur_en_eau_massique_remblai_valeur, ref degre_de_saturation, ref g, ref poids_volumique_sec_valeur, ref section, ref hauteur, 
                ref nombre_de_contenants, ref facteur_de_securite, ref Rayon_m, ref hauteur_m, ref Rayon_in, ref hauteur_in, ref longueur_m,
                ref largeur_m, ref hauteur_paralelipipede_m, ref longueur_in, ref largeur_in, ref hauteur_paralelipipede_in, ref section_in,
                ref hauteur_section_in);



            calcul_initiaux_3(ref teneur_en_eau_volumique_valeur_recette_3, ref masse_eau_a_rajouter_valeur_recette_3, ref rapport_eau_sur_ciment_valeur_recette_3, ref masse_eau_dans_le_residu_humide_valeur_recette_3, 
                ref masse_eau_total_dans_le_remblai_valeur_recette_3, ref masse_du_ciment_3_dans_le_remblai_valeur_recette_3, ref masse_du_ciment_2_dans_le_remblai_valeur_recette_3, 
                ref masse_du_ciment_1_dans_le_remblai_valeur_recette_3, ref masse_de_liant_total_dans_le_remblai_valeur_Mb_recette_3, ref masse_de_residu_humide_dans_le_remblai_valeur_recette_3,
                ref masse_de_residu_sec_dans_le_remblai_valeur_recette_3, ref volume_eau_dans_remblai_valeur_recette_3, ref volume_du_liant_dans_le_remblai_valeur_recette_3, 
                ref volume_des_rejets_dans_le_remblai_valeur_Vr_recette_3, ref porosite_du_remblai_valeur_recette_3, ref compacite_du_remblai_valeur_recette_3, ref volume_des_vides_valeur_recette_3, 
                ref volume_de_solide_du_remblai_valeur_recette_3, ref volume_total_de_remblai_valeur_recette_3, ref volume_contenant_valeur_recette_3, ref poids_volumique_total_valeur_recette_3, 
                ref masse_volumique_totale_valeur_recette_3, ref pourcentage_volumique_de_liant_Bv_valeur_recette_3, ref pourcentage_solide_volumique_valeur_recette_3, ref poids_volumique_sec_valeur_recette_3, 
                ref masse_volumique_seche_remblai_valeur_recette_3, ref indice_des_vides_valeur_recette_3, ref poids_specific_remblai_valeur_recette_3, ref masse_volumique_remblai_valeur_recette_3, 
                ref masse_volumique_S_liant_valeur, ref masse_volumique_specifique_du_ciment_3, ref fraction_ciment_1, ref fraction_ciment_2, ref fraction_ciment_3, ref poids_specific_liant_valeur,
                ref masse_volumique_eau, ref pourcentage_massique_de_liant_recette_3, ref masse_volumique_specifique_du_residu, ref pourcentage_solide_massique_fixe, ref teneur_en_eau_massique_remblai_valeur, 
                ref degre_de_saturation, ref g, ref poids_volumique_sec_valeur, ref section, ref hauteur, ref nombre_de_contenants, ref facteur_de_securite, 
                ref masse_volumique_specifique_du_ciment_1, ref masse_volumique_specifique_du_ciment_2, ref Rayon_m, ref hauteur_m, ref Rayon_in, ref hauteur_in, 
                ref longueur_m, ref largeur_m, ref hauteur_paralelipipede_m, ref longueur_in, ref largeur_in, ref hauteur_paralelipipede_in,
                ref section_in, ref hauteur_section_in);



            calcul_initiaux_4(ref teneur_en_eau_volumique_valeur_recette_4, ref masse_eau_a_rajouter_valeur_recette_4, ref rapport_eau_sur_ciment_valeur_recette_4, ref masse_eau_dans_le_residu_humide_valeur_recette_4, 
                ref masse_eau_total_dans_le_remblai_valeur_recette_4, ref masse_du_ciment_3_dans_le_remblai_valeur_recette_4, ref masse_du_ciment_2_dans_le_remblai_valeur_recette_4,
                ref masse_du_ciment_1_dans_le_remblai_valeur_recette_4, ref masse_de_liant_total_dans_le_remblai_valeur_Mb_recette_4, ref masse_de_residu_humide_dans_le_remblai_valeur_recette_4, 
                ref masse_de_residu_sec_dans_le_remblai_valeur_recette_4, ref volume_eau_dans_remblai_valeur_recette_4, ref volume_du_liant_dans_le_remblai_valeur_recette_4, 
                ref volume_des_rejets_dans_le_remblai_valeur_Vr_recette_4, ref porosite_du_remblai_valeur_recette_4, ref compacite_du_remblai_valeur_recette_4, ref volume_des_vides_valeur_recette_4, 
                ref volume_de_solide_du_remblai_valeur_recette_4, ref volume_total_de_remblai_valeur_recette_4, ref volume_contenant_valeur_recette_4, ref poids_volumique_total_valeur_recette_4, 
                ref masse_volumique_totale_valeur_recette_4, ref pourcentage_volumique_de_liant_Bv_valeur_recette_4, ref pourcentage_solide_volumique_valeur_recette_4, ref poids_volumique_sec_valeur_recette_4, 
                ref masse_volumique_seche_remblai_valeur_recette_4, ref indice_des_vides_valeur_recette_4, ref poids_specific_remblai_valeur_recette_4, ref masse_volumique_remblai_valeur_recette_4, 
                ref masse_volumique_S_liant_valeur, ref masse_volumique_specifique_du_ciment_3, ref fraction_ciment_1, ref fraction_ciment_2, ref fraction_ciment_3, ref poids_specific_liant_valeur, 
                ref masse_volumique_eau, ref pourcentage_massique_de_liant_recette_4, ref masse_volumique_specifique_du_residu, ref pourcentage_solide_massique_fixe, ref teneur_en_eau_massique_remblai_valeur,
                ref degre_de_saturation, ref g, ref poids_volumique_sec_valeur, ref section, ref hauteur, ref nombre_de_contenants, ref facteur_de_securite, 
                ref masse_volumique_specifique_du_ciment_1, ref masse_volumique_specifique_du_ciment_2, ref Rayon_m, ref hauteur_m, ref Rayon_in, 
                ref hauteur_in, ref longueur_m, ref largeur_m, ref hauteur_paralelipipede_m, ref longueur_in, ref largeur_in,
                ref hauteur_paralelipipede_in, ref section_in, ref hauteur_section_in);
















        }

        void RadioButton_Checked_nombre_recette(object sender, Microsoft.UI.Xaml.RoutedEventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            string nombre_de_recette_de_melange_string;

            nombre_de_recette_de_melange_string = rb.Content.ToString();

            nombre_de_recette_de_melange = Convert.ToDouble(nombre_de_recette_de_melange_string);


            if (rb.Name == "un")
            { NumberBoxSpinButton_Dosage_Cw_8.IsEnabled = false;
                NumberBoxSpinButton_Dosage_Cw_9.IsEnabled = false;
                NumberBoxSpinButton_Dosage_Cw_10.IsEnabled = false;
            }
            else if (rb.Name == "deux")
            {
                NumberBoxSpinButton_Dosage_Cw_8.IsEnabled = true;
                NumberBoxSpinButton_Dosage_Cw_9.IsEnabled = false;
                NumberBoxSpinButton_Dosage_Cw_10.IsEnabled = false;
            }
            else if (rb.Name == "trois")
            {
                NumberBoxSpinButton_Dosage_Cw_8.IsEnabled = true;
                NumberBoxSpinButton_Dosage_Cw_9.IsEnabled = true;
                NumberBoxSpinButton_Dosage_Cw_10.IsEnabled = false; }

            else if (rb.Name == "quatre")
            {
                NumberBoxSpinButton_Dosage_Cw_7.IsEnabled = true;
                NumberBoxSpinButton_Dosage_Cw_8.IsEnabled = true;
                NumberBoxSpinButton_Dosage_Cw_9.IsEnabled = true;
                NumberBoxSpinButton_Dosage_Cw_10.IsEnabled = true;
            }

           


        }



    }
}
