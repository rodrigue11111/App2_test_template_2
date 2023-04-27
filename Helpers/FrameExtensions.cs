using Microsoft.UI.Xaml.Controls;

namespace App2_test_template_2.Helpers
{
    public static class FrameExtensions
    {
        public static object GetPageViewModel(this Frame frame)
            => frame?.Content?.GetType().GetProperty("ViewModel")?.GetValue(frame.Content, null);
    }
}
