using App2_test_template_2.ViewModels;

using Microsoft.UI.Xaml.Controls;

namespace App2_test_template_2.Views
{
    public sealed partial class RRCPage : Page
    {
        public RRCViewModel ViewModel { get; }

        public RRCPage()
        {
            ViewModel = App.GetService<RRCViewModel>();
            InitializeComponent();
        }
    }
}
