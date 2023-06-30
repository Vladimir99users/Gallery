
using UnityEngine;
using UnityEngine.UI;

namespace Gallery.Menus
{

    public class GameMenu : Menu
    {
        [Header("UI interface")]

        // ТУТ VIEW надо убрать!
        [SerializeField] private Button _loadNewSceneBtn;
        [SerializeField] private Menu _loadMenu;

        [SerializeField] private int _idScene;

        private void Start()
        {
           _loadNewSceneBtn.onClick.AddListener( delegate {LoadScene(_idScene); });
        }

        private void OnDisable() 
        {
            _loadNewSceneBtn.onClick.RemoveAllListeners();    
        }


        public override void LoadScene(int id)
        {
            base.LoadScene(id);
            _loadMenu.SetIDNextSceneOnLoad = _idScene;
            _loadMenu.Open();
        }


    }

}
