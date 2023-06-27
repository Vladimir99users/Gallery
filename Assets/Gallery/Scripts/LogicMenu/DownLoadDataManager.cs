using System.Collections;

namespace Gallery.Menus
{
    public abstract class DownLoadDataManager: IDownloader
    {
        protected ProgressBar _progressBar;

        public DownLoadDataManager(ProgressBar progressBar)
        {
            _progressBar = progressBar;
        }
        public virtual IEnumerator DownLoadData(int id)
        {
            yield return null;
        }
    }
}
