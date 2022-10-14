using Prism.Mvvm;
using Prism.Regions;
using VideoCompression.Views;

namespace VideoCompression.ViewModels;

public class FileManageViewModel : BindableBase
{
    readonly IRegionManager regionManager;

    public FileManageViewModel(IRegionManager regionManager)
    {
        this.regionManager = regionManager;

        Configure();
    }

    private void Configure()
    {
        regionManager.RegisterViewWithRegion("FileListRegion", typeof(FileListView));
    }
}