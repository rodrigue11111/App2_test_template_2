﻿using Microsoft.UI.Xaml;
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
    

    // Public hauteur As Double = 0
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Section_et_hauteur_metre : Page
    {
        public static Double section_m=0;
        public static Double hauteur_m=0;

        public Section_et_hauteur_metre()
        {
            this.InitializeComponent();


        }



        private void btn1_section_hauteur_metre_Click(object sender, RoutedEventArgs e)
        {
            section_m = NumberBoxSpinButton_Section_et_hauteur_metre_1.Value;
            hauteur_m = NumberBoxSpinButton_Section_et_hauteur_metre_2.Value;
        }
    }
}
