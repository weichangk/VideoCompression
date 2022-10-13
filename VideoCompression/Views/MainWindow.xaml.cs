using System.Windows;
using System.Windows.Input;
using VideoCompression.Common;

namespace VideoCompression.Views;
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        Loaded += Window_Loaded;
    }

    private void Window_Loaded(object sender, RoutedEventArgs e)
    {
        HeadOperBind();
    }

    private void HeadOperBind()
    {
        if (DataContext is IHeadOper vm)
        {
            vm.Close += () => { this.Close(); };
            vm.Min += () => { this.WindowState = WindowState.Minimized; };
            vm.Move += () => { this.DragMove(); };
        }
    }
}
