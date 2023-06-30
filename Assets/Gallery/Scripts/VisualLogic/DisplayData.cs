using UnityEngine;

public abstract class DisplayData
{
    public bool IsReady = true;
    public DisplayData()
    {

    }

    public abstract void GenerateSpriteAndSetSpriteInImage(Texture2D data);
    protected abstract void SetDataImage(Sprite newImage);
}
