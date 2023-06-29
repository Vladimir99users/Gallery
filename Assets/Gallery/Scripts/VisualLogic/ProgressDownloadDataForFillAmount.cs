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

    public override void SetVisualData(float newValue)
    {
        SetDataInText(newValue);
        SetDataProgressBar(newValue);
    }
    public override void SetError(string error)
    {
        _textForDisplayDataLoading.text = error;
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