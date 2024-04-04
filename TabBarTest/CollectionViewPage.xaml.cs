using TabBarTest.ViewModels;

namespace TabBarTest;

public partial class CollectionViewPage
{
    public CollectionViewPage()
    {
        InitializeComponent();
        this.BindingContext = new MonkeysViewModel();
    }

    private void ToggleTabBar(object? sender, EventArgs e)
    {
        Shell.SetTabBarIsVisible(this, !Shell.GetTabBarIsVisible(this));
    }
}
