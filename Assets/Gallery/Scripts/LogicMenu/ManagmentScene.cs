using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Gallery.Menus
{

    public class ManagmentScene : DownLoadDataManager
    {
        public ManagmentScene(ProgressBar progressBar) : base(progressBar)
        {

        }

        public override IEnumerator DownLoadData(int id)
        {
            yield return new WaitForSeconds(2f);
            AsyncOperation operation = SceneManager.LoadSceneAsync(id);

            while (!operation.isDone)
            {
                float progress = operation.progress / 0.9f;
                _progressBar.SliderValue = progress;
                yield return null;
            }
        }
    }
}
