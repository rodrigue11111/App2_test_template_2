namespace muxc
{
    internal class NavigationViewItemInvokedEventArgs
    {
        public bool IsSettingsInvoked { get; internal set; }
        public object RecommendedNavigationTransitionInfo { get; internal set; }
        public object InvokedItemContainer { get; internal set; }
    }
}