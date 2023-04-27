using App2_test_template_2.ViewModels;

using Microsoft.UI.Xaml.Controls;

namespace App2_test_template_2.Views
{
    // TODO: Change the grid as appropriate for your app. Adjust the column definitions on DataGridPage.xaml.
    // For more details, see the documentation at https://docs.microsoft.com/windows/communitytoolkit/controls/datagrid.
    public sealed partial class RésultatsPage : Page
    {
        public RésultatsViewModel ViewModel { get; }

        public RésultatsPage()
        {
            ViewModel = App.GetService<RésultatsViewModel>();
            InitializeComponent();
        }
    }
}
