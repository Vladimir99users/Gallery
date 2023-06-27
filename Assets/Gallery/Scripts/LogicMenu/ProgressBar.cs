using System;
using UnityEngine.UI;

public abstract class  ProgressBar
{
    private Slider _progressBar;

    public float SliderValue 
    {
        get 
        {
            return _progressBar.value;
        }
        set
        {
            float data = Math.Clamp(value,_progressBar.minValue,_progressBar.maxValue);
            _progressBar.value = data;
        }
    }

    public ProgressBar(Slider progressBar)
    {
        _progressBar = progressBar;
    }
}
