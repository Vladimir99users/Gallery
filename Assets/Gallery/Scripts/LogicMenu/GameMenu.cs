
using UnityEngine;
using UnityEngine.UI;

namespace Gallery.Menus
{

    public class GameMenu : Menu
    {
        [Header("UI interface")]
        [SerializeField] private Button _loadNewSceneBtn;
        [SerializeField] private LoadMenu _loadMenu;

        [SerializeField] private int _idScene;

        private void Start()
        {
           _loadNewSceneBtn.onClick.AddListener( delegate {InteractionAfterOpeningMenu(); });
        }

        private void OnDisable() 
        {
            _loadNewSceneBtn.onClick.RemoveAllListeners();    
        }


        public override void InteractionAfterOpeningMenu()
        {
            this.Close();
            _loadMenu.Open();
            _loadMenu.SetIDNextSceneOnLoad = 1;
            _loadMenu.InteractionAfterOpeningMenu();
        }

    }

}
