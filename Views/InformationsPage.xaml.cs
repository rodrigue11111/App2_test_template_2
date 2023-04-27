using App2_test_template_2.ViewModels;

using Microsoft.UI.Xaml.Controls;
using System;

namespace App2_test_template_2.Views
{
   

    public sealed partial class InformationsPage : Page
    {

        public static double masse_volumique_eau = 1;
        public double g = 9.81;
        public double nombre_de_contenants;
        public string Informations = "Informations générales";

       

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





        









        // Informations generales (Les separer par tab)
        public static string nom_operateur;
        public static string nom_du_projet;
        public static string identification_du_residu;
        public static string date_de_melange;

        // Public section As Double = 0
        // Public hauteur As Double = 0
        // Public section_in As Double = 0
        // Public hauteur_section_in As Double = 0
        // Public Rayon_cm As Double = 0
        // Public hauteur_cm As Double = 0
        // Public Rayon_in As Double = 0
        // Public hauteur_in As Double = 0
        // Public longueur_cm As Double = 0
        // Public largeur_cm As Double = 0
        // Public hauteur_paralelipipede_cm As Double = 0
        // Public longueur_in As Double = 0
        // Public largeur_in As Double = 0
        // Public hauteur_paralelipipede_in As Double = 0







        
        
        public static double masse_volumique_specifique_du_ciment_1;
        public static double masse_volumique_specifique_du_ciment_2;
        public static double masse_volumique_specifique_du_ciment_3;
        public static double fraction_ciment_1;
        public static double fraction_ciment_2;
        public static double fraction_ciment_3;
        public static string nom_liant_1;
        public static string nom_liant_2;
        public static string nom_liant_3;
        
        
        
        
        
        
        public static double pourcentage_massique_de_liant_recette_2;
        public static double pourcentage_massique_de_liant_recette_3;
        public static double pourcentage_massique_de_liant_recette_4;
        public static double pourcentage_massique_de_liant_recette_pour_calcul_dans_fonction;
    
       
        public static double nombre_de_ciment_pour_liant;




        // Section 3_Ajustement 

        public double masse_de_residu_sec_total_dans_le_remblai_ajustement_recette_1;


        public double masse_de_residu_sec_total_dans_le_remblai_ajustement_recette_2;


        public double masse_de_residu_sec_total_dans_le_remblai_ajustement_recette_3;


        public double masse_de_residu_sec_total_dans_le_remblai_ajustement_recette_4;




        public double volume_de_residu_sec_total_dans_le_remblai_ajustement_recette_1;

        public double volume_de_residu_sec_total_dans_le_remblai_ajustement_recette_2;
        public double volume_de_residu_sec_total_dans_le_remblai_ajustement_recette_3;
        public double volume_de_residu_sec_total_dans_le_remblai_ajustement_recette_4;


        public double nouveau_pourcentage_massique_de_liant_dans_le_remblai_ajustement_recette_1;
        public double nouveau_pourcentage_massique_de_liant_dans_le_remblai_ajustement_recette_2;
        public double nouveau_pourcentage_massique_de_liant_dans_le_remblai_ajustement_recette_3;
        public double nouveau_pourcentage_massique_de_liant_dans_le_remblai_ajustement_recette_4;

        public double nouvelle_masse_totale_de_liant_dans_le_remblai_ajustement_recette_1;
        public double nouvelle_masse_totale_de_liant_dans_le_remblai_ajustement_recette_2;
        public double nouvelle_masse_totale_de_liant_dans_le_remblai_ajustement_recette_3;
        public double nouvelle_masse_totale_de_liant_dans_le_remblai_ajustement_recette_4;


        public double nouveau_volume_total_de_liant_dans_le_remblai_recette_1;
        public double nouveau_volume_total_de_liant_dans_le_remblai_recette_2;
        public double nouveau_volume_total_de_liant_dans_le_remblai_recette_3;
        public double nouveau_volume_total_de_liant_dans_le_remblai_recette_4;


        public double nouvelle_masse_de_liant_a_ajouter_dans_le_remblai_recette_1;

        public double nouvelle_masse_de_liant_a_ajouter_dans_le_remblai_recette_2;

        public double nouvelle_masse_de_liant_a_ajouter_dans_le_remblai_recette_3;

        public double nouvelle_masse_de_liant_a_ajouter_dans_le_remblai_recette_4;


        public double masse_ciment_1_a_ajouter_dans_le_remblai_recette_1_ajustement;
        public double masse_ciment_1_a_ajouter_dans_le_remblai_recette_2_ajustement;
        public double masse_ciment_1_a_ajouter_dans_le_remblai_recette_3_ajustement;
        public double masse_ciment_1_a_ajouter_dans_le_remblai_recette_4_ajustement;


        public double masse_ciment_2_a_ajouter_dans_le_remblai_recette_1_ajustement;
        public double masse_ciment_2_a_ajouter_dans_le_remblai_recette_2_ajustement;
        public double masse_ciment_2_a_ajouter_dans_le_remblai_recette_3_ajustement;
        public double masse_ciment_2_a_ajouter_dans_le_remblai_recette_4_ajustement;


        public double masse_ciment_3_a_ajouter_dans_le_remblai_recette_1_ajustement;
        public double masse_ciment_3_a_ajouter_dans_le_remblai_recette_2_ajustement;
        public double masse_ciment_3_a_ajouter_dans_le_remblai_recette_3_ajustement;
        public double masse_ciment_3_a_ajouter_dans_le_remblai_recette_4_ajustement;


        // Ajustement masse eau

        public double masse_eau_contenu_residu_humide_humide_ajoute_ajustement_recette_1;
        public double masse_eau_contenu_residu_humide_humide_ajoute_ajustement_recette_2;
        public double masse_eau_contenu_residu_humide_humide_ajoute_ajustement_recette_3;
        public double masse_eau_contenu_residu_humide_humide_ajoute_ajustement_recette_4;

        public double masse_eau_total_ajustement_recette_1;
        public double masse_eau_total_ajustement_recette_2;
        public double masse_eau_total_ajustement_recette_3;
        public double masse_eau_total_ajustement_recette_4;

        public double volume_eau_total_ajustement_recette_1;
        public double volume_eau_total_ajustement_recette_2;
        public double volume_eau_total_ajustement_recette_3;
        public double volume_eau_total_ajustement_recette_4;



        // Nouveaux parametres

        public double nouveau_rapport_eau_ciment_ajustement_recette_1;
        public double nouveau_rapport_eau_ciment_ajustement_recette_2;
        public double nouveau_rapport_eau_ciment_ajustement_recette_3;
        public double nouveau_rapport_eau_ciment_ajustement_recette_4;

        public double nouveau_pourcentage_solide_ajustement_recette_1;
        public double nouveau_pourcentage_solide_ajustement_recette_2;
        public double nouveau_pourcentage_solide_ajustement_recette_3;
        public double nouveau_pourcentage_solide_ajustement_recette_4;

        public double nouvelle_teneur_en_eau_massique_ajustement_recette_1;
        public double nouvelle_teneur_en_eau_massique_ajustement_recette_2;
        public double nouvelle_teneur_en_eau_massique_ajustement_recette_3;
        public double nouvelle_teneur_en_eau_massique_ajustement_recette_4;


        public double nouveau_volume_des_solides_ajustement_recette_1;
        public double nouveau_volume_des_solides_ajustement_recette_2;
        public double nouveau_volume_des_solides_ajustement_recette_3;
        public double nouveau_volume_des_solides_ajustement_recette_4;


        public double nouveau_volume_total_ajustement_recette_1;
        public double nouveau_volume_total_ajustement_recette_2;
        public double nouveau_volume_total_ajustement_recette_3;
        public double nouveau_volume_total_ajustement_recette_4;

        public double nouveau_volume_des_vides_ajustement_recette_1;
        public double nouveau_volume_des_vides_ajustement_recette_2;
        public double nouveau_volume_des_vides_ajustement_recette_3;
        public double nouveau_volume_des_vides_ajustement_recette_4;

        public double nouvel_indice_des_vides_ajustement_recette_1;
        public double nouvel_indice_des_vides_ajustement_recette_2;
        public double nouvel_indice_des_vides_ajustement_recette_3;
        public double nouvel_indice_des_vides_ajustement_recette_4;

        public double compacite_ajustement_recette_1;
        public double compacite_ajustement_recette_2;
        public double compacite_ajustement_recette_3;
        public double compacite_ajustement_recette_4;


        public double porosite_ajustement_recette_1;
        public double porosite_ajustement_recette_2;
        public double porosite_ajustement_recette_3;
        public double porosite_ajustement_recette_4;

        public double nouveau_degre_de_saturation_ajustement_recette_1;
        public double nouveau_degre_de_saturation_ajustement_recette_2;
        public double nouveau_degre_de_saturation_ajustement_recette_3;
        public double nouveau_degre_de_saturation_ajustement_recette_4;

        public double teneur_en_eau_volumique_ajustement_recette_1;
        public double teneur_en_eau_volumique_ajustement_recette_2;
        public double teneur_en_eau_volumique_ajustement_recette_3;
        public double teneur_en_eau_volumique_ajustement_recette_4;




        public double nouvelle_masse_volumique_totale_valeur_recette_1;
        public double nouvelle_masse_volumique_totale_valeur_recette_2;
        public double nouvelle_masse_volumique_totale_valeur_recette_3;
        public double nouvelle_masse_volumique_totale_valeur_recette_4;


        public double nouveau_pourcentage_volumique_de_liant_Bv_valeur_recette_1;
        public double nouveau_pourcentage_volumique_de_liant_Bv_valeur_recette_2;
        public double nouveau_pourcentage_volumique_de_liant_Bv_valeur_recette_3;
        public double nouveau_pourcentage_volumique_de_liant_Bv_valeur_recette_4;

        public double nouvelle_masse_volumique_seche_remblai_valeur_recette_1;
        public double nouvelle_masse_volumique_seche_remblai_valeur_recette_2;
        public double nouvelle_masse_volumique_seche_remblai_valeur_recette_3;
        public double nouvelle_masse_volumique_seche_remblai_valeur_recette_4;

        public double nouvelle_masse_volumique_remblai_valeur_recette_1;
        public double nouvelle_masse_volumique_remblai_valeur_recette_2;
        public double nouvelle_masse_volumique_remblai_valeur_recette_3;
        public double nouvelle_masse_volumique_remblai_valeur_recette_4;







        // Ajusyement pour le slump

       



        

        // Prediction_rapport eau ciment 

        public double prediction_cw_rapport_eau_ciment_valeur;


        

        public double pourcentage_solide_cw_massique_fixe_dosage_selon_rapport_recette_1;
        public double pourcentage_solide_cw_massique_fixe_dosage_selon_rapport_recette_2;
        public double pourcentage_solide_cw_massique_fixe_dosage_selon_rapport_recette_3;
        public double pourcentage_solide_cw_massique_fixe_dosage_selon_rapport_recette_4;

        public double teneur_eau_massique_section_rapport_w_recette_1;
        public double teneur_eau_massique_section_rapport_w_recette_2;
        public double teneur_eau_massique_section_rapport_w_recette_3;
        public double teneur_eau_massique_section_rapport_w_recette_4;







        // PAF



        public double am;
        public double A_m;
        public double masse_volumique_Paf_recette_2;
        public double masse_volumique_specifique_aggregat;

        public double masse_volumique_grain_solid_PAF_valeur;
        public double masse_volumique_bulk_total_PAF_valeur;

        public double masse_total_MT_PAF;
        public double pourcentage_solide_residu_humide_PAF;
        public double masse_de_residu_sec_dans_le_remblai_valeur_recette_2_PAF;
        public double masse_de_aggrega_sec_dans_le_remblai_valeur_recette_2;
        public double masse_de_residu_humide_dans_le_remblai_valeur_recette_2_PAF_recette_2;
        public double masse_de_liant_total_dans_le_remblai_valeur_Mb_PAF_recette_2;
        public double masse_eau_total_dans_le_remblai_valeur_recette_2_PAF;
        public double masse_eau_a_rajouter_valeur_recette_2_PAF;
        public double masse_de_residu_sec_dans_le_remblai_PAF_valeur_recette_2;




        public double Teneur_en_eau_massique_agregat;
        public double Pourcentage_massique_granulat_par_rapport_aux_résidus_secs;





        public double masse_de_liant_total_dans_le_remblai_valeur_Mb_recette_2_paf;




        public double masse_volumique_grain_solid_PAF_valeur_recette_2;
        public double masse_volumique_bulk_total_PAF_valeur_recette_2;
        public double masse_total_MT_PAF_recette_2;







        public double masse_de_residu_sec_dans_le_remblai_valeur_recette_3_PAF;
        public double masse_de_aggrega_sec_dans_le_remblai_valeur_recette_3;
        public double masse_de_residu_humide_dans_le_remblai_valeur_recette_3_PAF_recette_3;
        public double masse_de_liant_total_dans_le_remblai_valeur_Mb_PAF_recette_3;
        public double masse_eau_total_dans_le_remblai_valeur_recette_3_PAF;
        public double masse_eau_a_rajouter_valeur_recette_3_PAF;
        public double masse_de_residu_sec_dans_le_remblai_PAF_valeur_recette_3;
        public double masse_de_liant_total_dans_le_remblai_valeur_Mb_recette_3_paf;
        public double masse_volumique_grain_solid_PAF_valeur_recette_3;
        public double masse_volumique_bulk_total_PAF_valeur_recette_3;
        public double masse_total_MT_PAF_recette_3;
        public double masse_volumique_Paf_recette_3;



        public double masse_de_residu_sec_dans_le_remblai_valeur_recette_4_PAF;
        public double masse_de_aggrega_sec_dans_le_remblai_valeur_recette_4;
        public double masse_de_residu_humide_dans_le_remblai_valeur_recette_4_PAF_recette_4;
        public double masse_de_liant_total_dans_le_remblai_valeur_Mb_PAF_recette_4;
        public double masse_eau_total_dans_le_remblai_valeur_recette_4_PAF;
        public double masse_eau_a_rajouter_valeur_recette_4_PAF;
        public double masse_de_residu_sec_dans_le_remblai_PAF_valeur_recette_4;
        public double masse_de_liant_total_dans_le_remblai_valeur_Mb_recette_4_paf;
        public double masse_volumique_grain_solid_PAF_valeur_recette_4;
        public double masse_volumique_bulk_total_PAF_valeur_recette_4;
        public double masse_total_MT_PAF_recette_4;

        public double masse_volumique_Paf_recette_4;



        public double masse_de_residu_sec_dans_le_remblai_valeur_recette_1_PAF;
        public double masse_de_aggrega_sec_dans_le_remblai_valeur_recette_1;
        public double masse_de_residu_humide_dans_le_remblai_valeur_recette_1_PAF_recette_1;
        public double masse_de_liant_total_dans_le_remblai_valeur_Mb_PAF_recette_1;
        public double masse_eau_total_dans_le_remblai_valeur_recette_1_PAF;
        public double masse_eau_a_rajouter_valeur_recette_1_PAF;
        public double masse_de_residu_sec_dans_le_remblai_PAF_valeur_recette_1;
        public double masse_de_liant_total_dans_le_remblai_valeur_Mb_recette_1_paf;
        public double masse_volumique_grain_solid_PAF_valeur_recette_1;
        public double masse_volumique_bulk_total_PAF_valeur_recette_1;
        public double masse_total_MT_PAF_recette_1;




        // Vaiables pour bouttons


       public  string transformation;
       public  double transform;
      


















































        public InformationsViewModel ViewModel { get; }

        public InformationsPage()
        {
            ViewModel = App.GetService<InformationsViewModel>();
            InitializeComponent();
        }

        

       

        void RadioButton_Checked_Nombre(object sender, Microsoft.UI.Xaml.RoutedEventArgs e)
        {
            RadioButton rb = sender as RadioButton;

           

            transformation = rb.Content.ToString();

            transform = Convert.ToDouble(transformation);

            nombre_de_ciment_pour_liant = transform;




            if (rb.Name == "Option_1_Nombre_ciments")
            {
                ciment_1.IsEnabled = true;
                NumberBoxSpinButton_InformationPage_1.IsEnabled = true;

                ciment_2.IsEnabled = false;
                NumberBoxSpinButton_InformationPage_2.IsEnabled = false;

                ciment_3.IsEnabled = false;
                NumberBoxSpinButton_InformationPage_3.IsEnabled= false;


            }
            else if (rb.Name == "Option_2_Nombre_ciments")
            {
                ciment_1.IsEnabled = true;
                NumberBoxSpinButton_InformationPage_1.IsEnabled = true;

                ciment_2.IsEnabled = true;
                NumberBoxSpinButton_InformationPage_2.IsEnabled = true;

                ciment_3.IsEnabled = false;
                NumberBoxSpinButton_InformationPage_3.IsEnabled = false;
            }
            else if (rb.Name == "Option_3_Nombre_ciments")
            {
                ciment_1.IsEnabled = true;
                NumberBoxSpinButton_InformationPage_1.IsEnabled = true;
                ciment_2.IsEnabled = true;
                NumberBoxSpinButton_InformationPage_2.IsEnabled = true;
                ciment_3.IsEnabled = true;
                NumberBoxSpinButton_InformationPage_3.IsEnabled = true;
            }

          







        }

        void RadioButton_Checked_Ciment_1(object sender, Microsoft.UI.Xaml.RoutedEventArgs e)
        {
            RadioButton rb = sender as RadioButton;

            nom_liant_1 = rb.Name;

        }


        void RadioButton_Checked_Ciment_2(object sender, Microsoft.UI.Xaml.RoutedEventArgs e)
        {
            RadioButton rb = sender as RadioButton;

            nom_liant_2 = rb.Name;


        }







        void RadioButton_Checked_Ciment_3(object sender, Microsoft.UI.Xaml.RoutedEventArgs e)
        {
            RadioButton rb = sender as RadioButton;

            nom_liant_3 = rb.Name;



        }

       
        

        private void MenuFlyoutItem_Click(object sender, Microsoft.UI.Xaml.RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Section_et_hauteur_metre));
        }

        private void MenuFlyoutItem_Click_1(object sender, Microsoft.UI.Xaml.RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Section_et_hauteur_inch));
        }

        private void MenuFlyoutItem_Click_2(object sender, Microsoft.UI.Xaml.RoutedEventArgs e)
        {

            this.Frame.Navigate(typeof(Rayon_et_hauteur_metre));

        }

        private void MenuFlyoutItem_Click_3(object sender, Microsoft.UI.Xaml.RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Rayon_et_hauteur_inch));
        }

        private void MenuFlyoutItem_Click_4(object sender, Microsoft.UI.Xaml.RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Longueur_largeur_et_hauteur_metre));
        }

        private void MenuFlyoutItem_Click_5(object sender, Microsoft.UI.Xaml.RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Longeur_largeur_hauteur_inch));
        }

        private void btn1_click(object sender, Microsoft.UI.Xaml.RoutedEventArgs e)
        {


            



            identification_du_residu = identification_du_résidu_.Text.ToString();

            // date_de_melange = date_de_mélange_.Date.ToString();

            date_de_melange = date_de_mélange_.Date.ToString("D");

            nom_operateur = nom_operateur_.Text.ToString();

            nom_du_projet = nom_du_projet_.Text.ToString();



            fraction_ciment_1 = NumberBoxSpinButton_InformationPage_1.Value;
            fraction_ciment_2 = NumberBoxSpinButton_InformationPage_2.Value;
            fraction_ciment_3 = NumberBoxSpinButton_InformationPage_3.Value;







           







        }
    }
}
