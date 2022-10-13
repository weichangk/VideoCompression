using Prism.Ioc;
using System.Windows;
using VideoCompression.Views;

namespace VideoCompression;
public partial class App
{
    protected override Window CreateShell()
    {
        var window = Container.Resolve<MainWindow>();
        return window;
    }

    protected override void RegisterTypes(IContainerRegistry containerRegistry)
    {
        //containerRegistry.RegisterForNavigation<AdvancedSetView, SetViewModel>();
        //containerRegistry.RegisterForNavigation<BitRateSetView, SetViewModel>();
        //containerRegistry.RegisterForNavigation<FileSizeSetView, SetViewModel>();
    }
}
