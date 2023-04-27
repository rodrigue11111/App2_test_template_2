using App2_test_template_2.ViewModels;

using Microsoft.UI.Xaml.Controls;

namespace App2_test_template_2.Views
{
    public sealed partial class RPGPage : Page
    {
        public RPGViewModel ViewModel { get; }

        public RPGPage()
        {
            ViewModel = App.GetService<RPGViewModel>();
            InitializeComponent();
        }
        private void nvSample2_SelectionChanged(NavigationView sender, NavigationViewSelectionChangedEventArgs args)
        {
            if (args.IsSettingsSelected)
            {

                contentFrame2.Navigate(typeof(Dosage_selon_Cw));
            }
            else
            {
                NavigationViewItem item = args.SelectedItem as NavigationViewItem;
                switch (item.Tag.ToString())
                {
                    case "Dosage_selon_Cw":
                        contentFrame2.Navigate(typeof(Dosage_selon_Cw));
                        break;
                    //case "Méthode_essai_erreur":
                    //    contentFrame2.Navigate(typeof(Methode_essai_erreur));
                    //    break;
                    //case "Dosage_selon_le_slump":
                    //    contentFrame2.Navigate(typeof(Dosage_selon_le_slump));
                    //    break;
                    case "Dosage_selon_w_c":
                        contentFrame2.Navigate(typeof(Dosage_selon_w_c));
                        break;
                    case "Resultats":
                        contentFrame2.Navigate(typeof(Resultats_RPC));
                        break;


                }



            }
        }
    }
}
