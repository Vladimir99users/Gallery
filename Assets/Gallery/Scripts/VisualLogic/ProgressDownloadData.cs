public abstract class ProgressDownloadData
{
    public abstract void SetVisualData(float newValue);
    public abstract void LoadIsSucces();
    public virtual void SetError(string error)
    {
        UnityEngine.Debug.LogError($"Error in load data: {error}");
    }
}
