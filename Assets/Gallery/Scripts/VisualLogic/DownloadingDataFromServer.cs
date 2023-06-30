using System.Collections;
using UnityEngine;
using UnityEngine.Networking;
public class DownloadingDataFromServer : DownloadData
{
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
               ErrorDataView(unityWebRequest.error);
            } else 
            {
               DownloadHandlerTexture dHTexture = unityWebRequest.downloadHandler as DownloadHandlerTexture;
               SuccesDataView(dHTexture.texture);
            }
       }
    }
    protected override void ErrorDataView(string error)
    {
        _dataDisplay.IsReady = false;
        _downloadDataProgress.SetError(error);
        OnError?.Invoke(error);
    }

    protected override void SuccesDataView(Texture2D data)
    {
        _dataDisplay.IsReady = true;
        _dataDisplay.GenerateSpriteAndSetSpriteInImage(data);
        OnSucces?.Invoke();
    }
}

