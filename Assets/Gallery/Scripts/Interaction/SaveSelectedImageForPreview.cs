using UnityEngine;
using UnityEngine.Events;

public class SaveSelectedImageForPreview : MonoBehaviour
{
    [SerializeField] private Sprite _sprite;
    public Sprite Sprite {get => _sprite;}
    [SerializeField] private Configuration _lastClickForImage;
    [SerializeField] private Gallery.Menus.Menu _loadMenu;

    public UnityAction<Configuration> OnClickForImage;


    private const int ID_PREVIEW_SCENE = 2;

    private void Start()
    {
        DontDestroyOnLoad(this.gameObject);
    }


    private void OnEnable()
    {
        OnClickForImage += SetLastClickForImage;
    }

    private void OnDisable() 
    {
        OnClickForImage -= SetLastClickForImage;
    }

    private void SetLastClickForImage(Configuration config)
    {
        _lastClickForImage = config;

        _sprite = _lastClickForImage.ViewDataImage.sprite;

        _loadMenu.SetIDNextSceneOnLoad = ID_PREVIEW_SCENE;
        _loadMenu.InteractionAfterOpeningMenu();
    }

}
