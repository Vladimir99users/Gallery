using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;
public abstract class Controller : MonoBehaviour, IPointerClickHandler
{
    public abstract void CallbackLastClick(UnityAction<Configuration> callback);
    public virtual void OnPointerClick(PointerEventData eventData)
    {  
       
    }
}
