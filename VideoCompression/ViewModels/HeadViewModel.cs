using Prism.Commands;
using Prism.Events;
using Prism.Mvvm;
using System;
using System.Windows.Input;
using VideoCompression.Common;

namespace VideoCompression.ViewModels;
public class HeadViewModel : BindableBase, IDragMove
{
    readonly IEventAggregator ea;
    public DelegateCommand<string> SendOperCommand { get; private set; }
    public Action<object, MouseEventArgs> Move { get; set; }

    public HeadViewModel(IEventAggregator ea)
    {
        this.ea = ea;
        SendOperCommand = new DelegateCommand<string>(SendOper);
        Move += DoMove;
    }

    private void SendOper(string headOper)
    {
        ea.GetEvent<HeadOperEvent>().Publish(headOper);
    }

    private void DoMove(object s, MouseEventArgs e)
    {
        ea.GetEvent<HeadOperEvent>().Publish(nameof(HeadOperEnum.Move));
    }
}
