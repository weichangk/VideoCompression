using Prism.Commands;
using Prism.Events;
using Prism.Mvvm;
using Prism.Regions;
using System;
using VideoCompression.Common;
using VideoCompression.Views;

namespace VideoCompression.ViewModels;
public class MainWindowViewModel : BindableBase, IHeadOper
{
    readonly IEventAggregator ea;
    readonly IRegionManager regionManager;

    public DelegateCommand SendMessageCommand { get; private set; }
    public Action Close { get; set; }
    public Action Min { get; set; }
    public Action Move { get; set; }

    public MainWindowViewModel(IRegionManager regionManager, IEventAggregator ea)
    {
        this.regionManager = regionManager;
        this.ea = ea;

        Configure();
    }

    private void Configure()
    {
        regionManager.RegisterViewWithRegion("HeadRegion", typeof(HeadView));
        regionManager.RegisterViewWithRegion("ContentRegion", typeof(FileListView));
        regionManager.RegisterViewWithRegion("SetRegion", typeof(SetView));

        ea.GetEvent<HeadOperEvent>().Subscribe(HeadOperReceived);
    }

    private void HeadOperReceived(string obj)
    {
        switch (obj)
        {
            case "Close":
                DoClose();
                break;
            case "Min":
                DoMin();
                break;
            case "Move":
                DoMove();
                break;
            default:
                break;
        }
    }

    private void DoClose()
    {
        Close?.Invoke();
    }

    private void DoMin()
    {
        Min?.Invoke();
    }

    private void DoOpenMenu()
    {
    }

    private void DoMove()
    {
        Move?.Invoke();
    }

}
