using System.Collections;
using System;
using UnityEngine;
using UnityEngine.UI;
using  Gallery.URLData;
using UnityEngine.Networking;
using TMPro;

public class TestDownloadData : MonoBehaviour
{
    [SerializeField] private Image _image;
    [SerializeField] private Image _slider;
    [SerializeField] private TextMeshProUGUI _text;
    private void Start ()
    {
        GetTexture();
    }

    private void GetTexture()
    {
        string url = URLConfigurate.URL;

        Action<string> onError = (string data) => 
        {
            Error(data);
        };

        Action<Texture2D> onSucces = (Texture2D data) => 
        {
            Succes(data);
        };

        StartCoroutine(GetTextureUWR(url,onError,onSucces));
    }

    private IEnumerator GetTextureUWR(string url, Action<string> onError, Action<Texture2D> onSucces)
    {
        using(UnityWebRequest unityWebRequest = UnityWebRequestTexture.GetTexture(url))
        {
            var operation = unityWebRequest.SendWebRequest();

            while(!operation.isDone)
            {
                _text.text = $"Load: {(unityWebRequest.downloadProgress * 100).ToString("N0")}%";
                _slider.fillAmount = unityWebRequest.downloadProgress;

                yield return null;
            }
        
            
            if(unityWebRequest.result == UnityWebRequest.Result.ConnectionError || 
               unityWebRequest.result == UnityWebRequest.Result.DataProcessingError)
            {
                onError(unityWebRequest.error);
            } else 
            {
                DownloadHandlerTexture dHTexture = unityWebRequest.downloadHandler as DownloadHandlerTexture;
                onSucces(dHTexture.texture);
            }


        }
    }

    private void Succes(Texture2D data)
    {
        Debug.Log("Succes");
        _slider.gameObject.SetActive(false);
        Sprite sprite = Sprite.Create(data, new Rect(0,0,data.width,data.height),new Vector2(0.5f,0.5f));
        _image.sprite = sprite;
    }

    private void Error(string data)
    {
        Debug.Log("Succes");
    }
}
