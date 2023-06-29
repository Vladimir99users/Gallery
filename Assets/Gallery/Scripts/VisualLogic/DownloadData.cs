using UnityEngine;
using System.Collections;
using UnityEngine.Events;


public abstract class DownloadData : IDownloader
{
    public UnityAction<string> OnError;
    public UnityAction OnSucces;

    protected DisplayData _dataDisplay;
    protected ProgressDownloadData _downloadDataProgress;

    public void SetDisplayAndProgressData(DisplayData dataDisplay,ProgressDownloadData dataProgress)
    {
        _dataDisplay = dataDisplay;
        _downloadDataProgress = dataProgress;

        OnSucces += _downloadDataProgress.LoadIsSucces;
    }

    public abstract IEnumerator DownLoadData(string path);

    protected abstract void ErrorDataView(string error);
    protected abstract void SuccesDataView(Texture2D data);

}