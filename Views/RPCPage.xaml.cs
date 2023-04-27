using App2_test_template_2.ViewModels;

using Microsoft.UI.Xaml.Controls;

namespace App2_test_template_2.Views
{
    public sealed partial class RPCPage : Page
    {
        public RPCViewModel ViewModel { get; }

        public RPCPage()
        {
            ViewModel = App.GetService<RPCViewModel>();
            InitializeComponent();
        }

        private void nvSample_SelectionChanged(NavigationView sender, NavigationViewSelectionChangedEventArgs args)
        {
            if (args.IsSettingsSelected)
            {

                contentFrame.Navigate(typeof(Dosage_selon_Cw));
            }
            else
            {
                NavigationViewItem item =args.SelectedItem as NavigationViewItem;
                switch(item.Tag.ToString())
                {
                    case "Dosage_selon_Cw":
                        contentFrame.Navigate(typeof(Dosage_selon_Cw));
                        break;
                    case "Méthode_essai_erreur":
                        contentFrame.Navigate(typeof(Methode_essai_erreur));
                        break;
                    case "Dosage_selon_le_slump":
                        contentFrame.Navigate(typeof(Dosage_selon_le_slump));
                        break;
                    case "Dosage_selon_w_c":
                        contentFrame.Navigate(typeof(Dosage_selon_w_c));
                        break;
                    case "Resultats":
                        contentFrame.Navigate(typeof(Resultats_RPC));
                        break;


                }



            }
        }
    }
}
