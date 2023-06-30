using UnityEngine;
using UnityEngine.Events;

namespace Gallery.Menus 
{
    [RequireComponent(typeof(CanvasGroup))]
    public abstract class Menu : MonoBehaviour
    {
        [SerializeField] private bool _closeOnAwake = true;
        public UnityEvent Opened;
        public UnityEvent Closed;
        protected bool IsOpen => _canvasGroup.interactable;
        private CanvasGroup _canvasGroup;

        public int SetIDNextSceneOnLoad {get; set;}

        private void Awake()
        {
            OnAwake();

            if (_closeOnAwake)
            {
                Close();
            }
        }

        public virtual void Open()
        {
            _canvasGroup.interactable = true;
            _canvasGroup.blocksRaycasts = true;
            _canvasGroup.alpha = 1;
        }
        public virtual void Close()
        {
            _canvasGroup.interactable = false;
            _canvasGroup.blocksRaycasts = false;
            _canvasGroup.alpha = 0;
        }

        protected virtual void OnAwake()
        {
            _canvasGroup = GetComponent<CanvasGroup>();
        }

        public virtual void LoadScene(int id)
        {
            this.Close();
        }

    }
}