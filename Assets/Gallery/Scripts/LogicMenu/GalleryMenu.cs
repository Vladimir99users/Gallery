using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Gallery.Menus
{
    public class GalleryMenu : Menu
    {
        [Header("UI interface")]
        [SerializeField] private Button _loadNewScene;
        [SerializeField] private Slider _sliderProgressBar;
        [SerializeField] private Menu _loadMenu;


        private DownLoadDataManager _managerScene;
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


        protected override void ButtonClick()
        {
            base.ButtonClick();
            
            _loadMenu.Open();
            StartCoroutine(_managerScene.DownLoadData(3));
        }

    }
}
