using UnityEngine;
using System.Collections;
using System;


public abstract class DownloadData : MonoBehaviour, IDownloader
{
    protected Action<string> _onError;
    protected Action<Texture2D> _onSucces;

    protected DisplayData _dataDisplay;
    protected ProgressDownloadData _downloadDataProgress;

    public void SetDysplay(DisplayData dataDisplay,ProgressDownloadData dataProgress)
    {
        _dataDisplay = dataDisplay;
        _downloadDataProgress = dataProgress;
    }

    public abstract IEnumerator DownLoadData(string path);

    public abstract void InitEventData();
    public abstract void UnInitEventData();
    protected abstract void ErrorDataView(string error);
    protected abstract void SuccesDataView(Texture2D data);

}