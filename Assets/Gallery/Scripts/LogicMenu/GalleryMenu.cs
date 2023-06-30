using UnityEngine;
using UnityEngine.UI;

namespace Gallery.Menus
{
    public class GalleryMenu : Menu
    {
        [Header("UI interface")]
        [SerializeField] private Slider _sliderProgressBar;
        [SerializeField] private LoadMenu _loadMenu;

        [SerializeField] private int _idScene;

        private DownLoadDataManager _managerScene;
        private ProgressBar _progress;


        private void Start()
        {
            _progress = new ProgressLoadMenu(_sliderProgressBar);
           _managerScene = new ManagmentScene(_progress);
        }
        public override void InteractionAfterOpeningMenu()
        {           
            this.Close();
            _loadMenu.SetIDNextSceneOnLoad = _idScene;
            _loadMenu.Open();
            _loadMenu.InteractionAfterOpeningMenu();
        }

    }
}
