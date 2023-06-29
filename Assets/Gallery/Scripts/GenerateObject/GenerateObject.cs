using UnityEngine;
using Gallery.URLData;

public class GenerateObject : MonoBehaviour
{
    [SerializeField] private Configuration _prefabs;
    [SerializeField] private Transform _parentTransform;

    [Space]
    [SerializeField] private int _countObject = 66;
    [SerializeField] private SaveSelectedImageForPreview _previewImage;

    private DisplayData display;
    private ProgressDownloadData progress;

    private void Start() 
    {
        Generate();
    }

    private void Generate()
    {
        for (int count = 1; count <= _countObject; count++)
        {
            DownloadData data = new DownloadingDataFromServer();


            Configuration config = Instantiate(_prefabs, _parentTransform);

            Controller controller = config.gameObject.GetComponent<Controller>();

            controller.CallbackLastClick(_previewImage.OnClickForImage);

            config.gameObject.name = $"Image {count}";

            VisualDataConfiguration(config);

            data.SetDisplayAndProgressData(display,progress);
            
            string url = GetPath(count);

            StartCoroutine(data.DownLoadData(url));
        }
    }

    private void VisualDataConfiguration(Configuration conf) 
    {
        display = new ViewDataForImage(conf.ViewDataImage);
        progress = new ProgressDownloadDataForFillAmount(conf.TextLoadData, conf.FillAmountImage);
    }

    private string GetPath(int id)
    {
        return URLConfigurate.URL + $"{id}" + URLConfigurate.FormateData;
    }
}
