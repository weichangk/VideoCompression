using FFMpegNetWrapper;
using Microsoft.Win32;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions;
using System;
using System.Threading.Tasks;
using VideoCompression.Views;

namespace VideoCompression.ViewModels;

public class FileManageViewModel : BindableBase
{
    readonly IRegionManager regionManager;

    public DelegateCommand OpenFileCommand { get; private set; }

    public FileManageViewModel(IRegionManager regionManager)
    {
        this.regionManager = regionManager;

        Configure();
        //var result = Instances.Instance.Finish(@"./FFMPEG/bin/ffprobe.exe", "-version");
    }

    private void Configure()
    {
        //regionManager.RegisterViewWithRegion("FileListRegion", typeof(FileListView));
        OpenFileCommand = new DelegateCommand(OpenFile);
    }

    private void OpenFile()
    {
        OpenFileDialog dlg = new()
        {
            DefaultExt = ".txt",
            Filter = "All Files|*.*"
        };
        bool result = (bool)dlg.ShowDialog();
        if (result == true)
        {
            string filename = dlg.FileName;
            LoadFileAsync(filename);
        }
    }

    private void LoadFileAsync(string filename)
    {
        var fileAnalysis =  FFProbe.Analyse(filename);
    }
}