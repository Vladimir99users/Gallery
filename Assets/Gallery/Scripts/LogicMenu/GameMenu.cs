
using UnityEngine;
using UnityEngine.UI;

namespace Gallery.Menus
{

    public class GameMenu : Menu
    {
        [Header("UI interface")]

        // ТУТ VIEW надо убрать!
        [SerializeField] private Button _loadNewScene;
        [SerializeField] private Slider _sliderProgressBar;
        [SerializeField] private Menu _loadMenu;


        private DownLoadDataManager _managerScene;
        private ProgressBar _progress;


        private void Start()
        {
            _progress = new ProgressLoadMenu(_sliderProgressBar);
           _managerScene = new ManagmentScene(_progress);


           _loadNewScene.onClick.AddListener( delegate {LoadScene(1); });
        }

        private void OnDisable() 
        {
            _loadNewScene.onClick.RemoveAllListeners();    
        }


        public override void LoadScene(int id)
        {
            base.LoadScene(id);

            _loadMenu.Open();
            StartCoroutine(_managerScene.DownLoadData(id));
        }


    }

}
