using System.Windows.Controls;
using System.Windows.Input;
using VideoCompression.Common;

namespace VideoCompression.Views;
public partial class HeadView : UserControl
{
    public HeadView()
    {
        InitializeComponent();
        DragMoveBind();
    }

    private void DragMoveBind()
    {
        Border.MouseMove += (s, e) => {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                if (DataContext is IDragMove vm)
                {
                    vm.Move(s, e);
                }
            }
        };
    }
}
