using UnityEngine;
using UnityEngine.UI;

public class PreviewImage: MonoBehaviour
{
    [SerializeField] private Image previewImage;
    [SerializeField] private SaveSelectedImageForPreview _saveSelected;

    private void Awake() 
    {
        _saveSelected = FindFirstObjectByType<SaveSelectedImageForPreview>();
        SetSprite();
    }

    private void SetSprite()
    {
        previewImage.sprite = _saveSelected.Sprite;
    }
}