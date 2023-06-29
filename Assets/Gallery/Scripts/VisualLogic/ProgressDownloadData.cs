public abstract class ProgressDownloadData
{
    public abstract void SetVisualData(float newValue);
    public virtual void SetError(string error)
    {
        UnityEngine.Debug.LogError($"Error in load data: {error}");
    }
}
