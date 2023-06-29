using TMPro;

public class ProgressDownloadDataForFillAmount : ProgressDownloadData
{
    private TextMeshProUGUI _textForDisplayDataLoading;
    private UnityEngine.UI.Image _imageForFillAmount;


    public ProgressDownloadDataForFillAmount(TextMeshProUGUI text,UnityEngine.UI.Image image )
    {
        _textForDisplayDataLoading = text;
        _imageForFillAmount = image;
    }
    public override void LoadIsSucces()
    {
        _textForDisplayDataLoading.gameObject.SetActive(false);
        _imageForFillAmount.gameObject.SetActive(false);
    }
    public override void SetError(string error)
    {
        _textForDisplayDataLoading.text = error;
    }
    public override void SetVisualData(float newValue)
    {
        SetDataInText(newValue);
        SetDataProgressBar(newValue);
    }


    private void SetDataInText(float newValue)
    {
       _textForDisplayDataLoading.text = $"Load: {(newValue * 100).ToString("N0")}%";
    }

    private void SetDataProgressBar(float newValue)
    {
       _imageForFillAmount.fillAmount = newValue;
    }


    
}