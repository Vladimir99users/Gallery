using UnityEngine;

public abstract class DisplayData
{
    public DisplayData()
    {

    }

    public abstract void GenerateSpriteAndSetSpriteInImage(Texture2D data);
    protected abstract void SetDataImage(Sprite newImage);
}
