using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class Configuration : MonoBehaviour
{
   [SerializeField] private Image _viewDataImage;
   [SerializeField] private Image _fillAmountImage;
   [SerializeField] private TextMeshProUGUI _textLoadData;

   public Image ViewDataImage {get => _viewDataImage; }
   public Image FillAmountImage {get => _fillAmountImage; }
   public TextMeshProUGUI TextLoadData {get => _textLoadData; }

   public bool IsReady;
}
