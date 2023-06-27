
using UnityEngine;
using UnityEngine.UI;

namespace Gallery.Menus
{

    public class GameMenu : Menu
    {
        [Header("UI interface")]
        [SerializeField] private Button _loadNewScene;
        [SerializeField] private Slider _sliderProgressBar;
        [SerializeField] private Menu _loadMenu;


        private IDownloader _managerScene;
        private ProgressBar _progress;


        private void Start()
        {
            _progress = new ProgressLoadMenu(_sliderProgressBar);
           _managerScene = new ManagmentScene(_progress);


           _loadNewScene.onClick.AddListener( ButtonClick);
        }

        private void OnDisable() 
        {
            _loadNewScene.onClick.RemoveAllListeners();    
        }


        private void ButtonClick()
        {
            this.Close();
            _loadMenu.Open();
            StartCoroutine(_managerScene.DownLoadData(1));
        }


    }

}
