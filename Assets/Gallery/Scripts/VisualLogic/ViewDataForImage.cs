using UnityEngine;
using UnityEngine.UI;
public class ViewDataForImage : DisplayData
{
    private Configuration _config;
    private Image _viewImage;
    public ViewDataForImage(Configuration confi)
    {
        _viewImage = confi.ViewDataImage;
        _config = confi;
    }
    
    public override void GenerateSpriteAndSetSpriteInImage(Texture2D data)
    {
        _config.IsReady = true;
        Sprite sprite = Sprite.Create(data, new Rect(0,0,data.width,data.height),new Vector2(0.5f,0.5f));
        SetDataImage(sprite);
    }

    protected override void SetDataImage(Sprite newImage)
    {
        _viewImage.sprite = newImage;
    }
}
