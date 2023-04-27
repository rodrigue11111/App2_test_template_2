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

    public class Information
    {
        public int PersonId { get; set; }
        public int DepartmentId { get; set; }
        public string Nom_du_résidu { get; set; }
        public string Nom_Operateur { get; set; }
        public string Quantité_moulée { get; set; }

        public double Cw { get; set; }

        public string Date_de_melange { get; set; }


    }


    public sealed partial class Information_sur_le_melange_Resultats_RPC : Page
    {

        //public List<Department> Departments { get; set; }
        public List<Information> Informations { get; set; }

        public Information_sur_le_melange_Resultats_RPC()
        {
            this.InitializeComponent();


        //    Departments = new List<Department>
        //{
        //    new Department {DepartmentId = 1, DepartmentName = "R&D"},
        //    new Department {DepartmentId = 2, DepartmentName = "Finance"},
        //    new Department {DepartmentId = 3, DepartmentName = "IT"}
        //};

            Informations = new List<Information>
        {
            new Information
            {
                 Nom_du_résidu = InformationsPage.identification_du_residu, Nom_Operateur = InformationsPage.nom_operateur,
                Quantité_moulée = "Network Administrator",Cw=Dosage_selon_Cw.pourcentage_solide_massique_fixe , Date_de_melange=InformationsPage.date_de_melange
            },

        };



        }



    }
}
