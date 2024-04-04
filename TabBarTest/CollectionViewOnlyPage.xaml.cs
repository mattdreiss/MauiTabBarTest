using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TabBarTest.ViewModels;

namespace TabBarTest;

public partial class CollectionViewOnlyPage
{
    public CollectionViewOnlyPage()
    {
        InitializeComponent();
        this.BindingContext = new MonkeysViewModel();
    }

    private void ToggleTabBar(object? sender, EventArgs e)
    {
        Shell.SetTabBarIsVisible(this, !Shell.GetTabBarIsVisible(this));
    }
}
