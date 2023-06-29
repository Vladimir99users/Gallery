using UnityEngine;
using UnityEngine.UI;
public class ViewDataForImage : DisplayData
{

    private Image _viewImage;
    public ViewDataForImage(Image image)
    {
        _viewImage = image;
    }
    
    public override void GenerateSpriteAndSetSpriteInImage(Texture2D data)
    {
        Sprite sprite = Sprite.Create(data, new Rect(0,0,data.width,data.height),new Vector2(0.5f,0.5f));
        SetDataImage(sprite);
    }

    protected override void SetDataImage(Sprite newImage)
    {
        _viewImage.sprite = newImage;
    }
}


/*


     //protected abstract void SetDataInText(float newValue);
    //protected abstract void SetDataProgressBar(float newValue);

    //protected override void SetDataInText(float newValue)
    //{
    //    _textProgressData.text = $"Load: {(newValue).ToString("N0")}%";
    //}
//
    //protected override void SetDataProgressBar(float newValue)
    //{
    //    _progressBar.fillAmount = newValue;
    //}

*/