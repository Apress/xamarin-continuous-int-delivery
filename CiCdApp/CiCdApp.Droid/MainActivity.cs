using Android.App;
using Android.Content.PM;
using Android.OS;
using HockeyApp.Android;

namespace CiCdApp.Droid
{
    [Activity(Label = "CiCdApp", Icon = "@drawable/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(bundle);

            global::Xamarin.Forms.Forms.Init(this, bundle);

#if ENABLE_TEST_CLOUD
            Xamarin.Forms.Forms.ViewInitialized += (object sender, Xamarin.Forms.ViewInitializedEventArgs e) => {
        if (!string.IsNullOrWhiteSpace(e.View.AutomationId))
        {
            e.NativeView.ContentDescription = e.View.AutomationId;
        }
    };
#endif

            CrashManager.Register(this, "d6e57d97b1bd4b64843fd0423ee54a63");

            LoadApplication(new App());
        }
    }
}