using Prism.Mvvm;
using Prism.Regions;
using VideoCompression.Views;

namespace VideoCompression.ViewModels;
public class SetViewModel : BindableBase
{
    private readonly IRegionManager regionManager;
    public SetViewModel(IRegionManager regionManager)
    {
        this.regionManager = regionManager;
        Configure();
    }

    private void Configure()
    {
        regionManager.RegisterViewWithRegion("SetTypeTabRegion", typeof(AdvancedSetView));
        regionManager.RegisterViewWithRegion("SetParamTypeTabRegion", typeof(BitRateSetView));
    }
}
