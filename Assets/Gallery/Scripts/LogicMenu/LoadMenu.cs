
namespace Gallery.Menus
{

    public class LoadMenu : Menu
    {
        public override void Open()
        {
            base.Open();
            Opened?.Invoke();
        }
    }

}