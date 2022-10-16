using Prism.Mvvm;
using System.Collections.ObjectModel;

namespace VideoCompression.ViewModels;

public class FileListViewModel : BindableBase
{
    private ObservableCollection<FileData> fileDatas;
    public ObservableCollection<FileData> FileDatas
    {
        get { return fileDatas; }
        set { fileDatas = value; RaisePropertyChanged(); }
    }
    public FileListViewModel()
    {
        FileDatas = new ObservableCollection<FileData>()
        {
            new FileData()
            {
                Name = "真茶真柠檬",
                Status = "加载完成",
                Size = "100M",
                Duration = "00:00:60",
                Resolution = "1780*720",
                OutResolution = "1780*720",
                OutSize = "100KB-10MB",
                Format = "MP4",
                OutFormat = "MP4",
            },
            new FileData()
            {
                Name = "开个好虎头",
                Status = "加载完成",
                Size = "100M",
                Duration = "00:00:60",
                Resolution = "1780*720",
                OutResolution = "1780*720",
                OutSize = "100KB-10MB",
                Format = "MP4",
                OutFormat = "MP4",
            },
            new FileData()
            {
                Name = "开个好虎头",
                Status = "加载完成",
                Size = "100M",
                Duration = "00:00:60",
                Resolution = "1780*720",
                OutResolution = "1780*720",
                OutSize = "100KB-10MB",
                Format = "MP4",
                OutFormat = "MP4",
            },
            new FileData()
            {
                Name = "开个好虎头",
                Status = "加载完成",
                Size = "100M",
                Duration = "00:00:60",
                Resolution = "1780*720",
                OutResolution = "1780*720",
                OutSize = "100KB-10MB",
                Format = "MP4",
                OutFormat = "MP4",
            },
            new FileData()
            {
                Name = "开个好虎头",
                Status = "加载完成",
                Size = "100M",
                Duration = "00:00:60",
                Resolution = "1780*720",
                OutResolution = "1780*720",
                OutSize = "100KB-10MB",
                Format = "MP4",
                OutFormat = "MP4",
            },
            new FileData()
            {
                Name = "开个好虎头",
                Status = "加载完成",
                Size = "100M",
                Duration = "00:00:60",
                Resolution = "1780*720",
                OutResolution = "1780*720",
                OutSize = "100KB-10MB",
                Format = "MP4",
                OutFormat = "MP4",
            },
        };
    }
}

public class FileData
{
    public string Name { get; set; }
    public string Duration { get; set; }
    public string Resolution { get; set; }
    public string OutResolution { get; set; }
    public string Size { get; set; }
    public string OutSize { get; set; }
    public string Format { get; set; }
    public string OutFormat { get; set; }
    public string Status { get; set; }

}