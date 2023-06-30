using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;

public class ControllerImageClick : Controller
{
    private UnityAction<Configuration> _callback;
    public override void CallbackLastClick(UnityAction<Configuration> callback)
    {
        _callback = callback;
    }
    public override void OnPointerClick(PointerEventData eventData)
    {  
        base.OnPointerClick(eventData);
        
        GameObject selected = eventData.pointerClick.gameObject;

        if(selected.TryGetComponent<Configuration>(out Configuration config))
        {
            if(config.IsReady)
            {
                _callback?.Invoke(config);
            }
        }
    }
}
