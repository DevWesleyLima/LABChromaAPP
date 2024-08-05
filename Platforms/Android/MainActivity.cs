using Android.App;
using Android.Content.PM;
using Android.OS;
using static AndroidX.Core.SplashScreen.SplashScreen;


namespace LABChromaAI.App
{
    [Activity(Theme = "@style/Theme.LoadScreen", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode | ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize | ConfigChanges.Density)]
   
    public class MainActivity : MauiAppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            var splash = InstallSplashScreen(this);
            base.OnCreate(savedInstanceState);
        }
    }
}
