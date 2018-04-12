using SendApp.Droid;
using Xamarin.Forms;

[assembly: Dependency(typeof(CloseApp))]
namespace SendApp.Droid
{
    class CloseApp :ICloseApplication
    {
        public void CloseApplication()
        {
            var context = MainActivity.Instance;
            context.FinishAffinity();
        }
    }
}
