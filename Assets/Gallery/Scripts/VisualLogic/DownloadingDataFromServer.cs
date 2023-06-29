using System.Collections;
using UnityEngine;
using UnityEngine.Networking;
public class DownloadingDataFromServer : DownloadData
{
    public override void InitEventData()
    {
        _onError += ErrorDataView;
        _onSucces += SuccesDataView;
    }

    public override void UnInitEventData()
    {
        _onError -= ErrorDataView;
        _onSucces -= SuccesDataView;
    }

    public override IEnumerator DownLoadData(string path)
    {
        using(UnityWebRequest unityWebRequest = UnityWebRequestTexture.GetTexture(path))
        {
           var operation = unityWebRequest.SendWebRequest();
           while(!operation.isDone)
           {
               _downloadDataProgress.SetVisualData(unityWebRequest.downloadProgress);
               yield return null;
           }
       
           
           if(unityWebRequest.result == UnityWebRequest.Result.ConnectionError || 
              unityWebRequest.result == UnityWebRequest.Result.DataProcessingError)
            {
               _onError?.Invoke(unityWebRequest.error);
            } else 
            {
               DownloadHandlerTexture dHTexture = unityWebRequest.downloadHandler as DownloadHandlerTexture;
               _onSucces?.Invoke(dHTexture.texture);
            }
       }
    }
    protected override void ErrorDataView(string error)
    {
        _downloadDataProgress.SetError(error);
    }

    protected override void SuccesDataView(Texture2D data)
    {
        _dataDisplay.GenerateSpriteAndSetSpriteInImage(data);
    }
}

