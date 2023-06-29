using System.Collections;

namespace Gallery.Menus
{
    public abstract class DownLoadDataManager
    {
        protected ProgressBar _progressBar;

        public DownLoadDataManager(ProgressBar progressBar)
        {
            _progressBar = progressBar;
        }
        public abstract IEnumerator DownLoadData(int id);
    }
}
