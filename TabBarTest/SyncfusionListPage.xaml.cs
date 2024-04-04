using System.Reflection;
using Syncfusion.Maui.DataSource.Extensions;
using TabBarTest.ViewModels;

namespace TabBarTest;

public partial class SyncfusionListPage
{
    public SyncfusionListPage()
    {
        InitializeComponent();
        this.BindingContext = new MonkeysViewModel();
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();

        // Work-around provided by Syncfusion in response to the following MAUI issues.
        // https://github.com/dotnet/maui/issues/19720
        // https://github.com/dotnet/maui/issues/16360
#if IOS
        var safeAreaPropertyInfo = this.ListView.GetType().GetProperties(BindingFlags.Instance | BindingFlags.NonPublic).FirstOrDefault(x => x.Name == "IgnoreSafeArea");
        if (safeAreaPropertyInfo != null)
        {
            safeAreaPropertyInfo.SetValue(this.ListView, true);
        }
#endif
    }

    private void ToggleTabBar(object? sender, EventArgs e)
    {
        Shell.SetTabBarIsVisible(this, !Shell.GetTabBarIsVisible(this));
    }

}
