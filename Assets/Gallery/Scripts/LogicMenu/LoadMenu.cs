using UnityEngine;
using UnityEngine.UI;

namespace Gallery.Menus
{

    public class LoadMenu : Menu
    {
        [SerializeField] private Slider _sliderProgressBar;

        
        private DownLoadDataManager _managerScene;
        private ProgressBar _progress;

        private void Start()
        {
            _progress = new ProgressLoadMenu(_sliderProgressBar);
           _managerScene = new ManagmentScene(_progress);
        }



        public override void Open()
        {
            base.Open();
            Opened?.Invoke();
            LoadScene(SetIDNextSceneOnLoad);
        }

        public override void LoadScene(int id)
        {           
            StartCoroutine(_managerScene.DownLoadData(id));
        }

    }

}