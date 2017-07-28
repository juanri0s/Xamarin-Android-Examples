    // (MainLauncher = true) makes the splash screen the first screen that is launched
    // (No History = true) removes the Activity from BackStack when user navigates away from the Activity

    [Activity(Label = "AndroidSplashScreenExample", MainLauncher = true, NoHistory = true)]

    public class AndroidSplashScreenExample : Activity
    {

		protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            
            StartActivity(typeof(Place the activity you want to load up after the splash screen in here));

            // Finishes the activity once user has left it
            Finish();
        }
    }