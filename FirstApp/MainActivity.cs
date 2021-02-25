using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using Android.Content;
using Xamarin.Essentials;

namespace FirstApp
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            var textView = FindViewById<TextView>(Resource.Id.textView1);
            var button = FindViewById<Button>(Resource.Id.button1);
            var counter = 0;

            button.Click += delegate
            {
                counter += 1;
                textView.Text = counter.ToString();
            };

            var calculatorButton = FindViewById<Button>(Resource.Id.calculatorButton);

            calculatorButton.Click += delegate
            {
                Intent intent = new Intent(this, typeof(CalculatorActivity));
                StartActivity(intent);
            };

            var webButton = FindViewById<Button>(Resource.Id.webButton);

            webButton.Click += delegate
            {
                Intent intent = new Intent(this, typeof(WebActivity));
                intent.PutExtra(Constants.AddressKey, Constants.DefaultUrlToLoad);
                StartActivity(intent);
            };

            var essentialsButton = FindViewById<Button>(Resource.Id.essentialsButton);

            essentialsButton.Click += delegate
            {
                Intent intent = new Intent(this, typeof(EssentialsActivity));
                StartActivity(intent);
            };

            var listlistViewButton = FindViewById<Button>(Resource.Id.listViewButton);

            listlistViewButton.Click += delegate
            {
                Intent intent = new Intent(this, typeof(SampleListActivity));
                StartActivity(intent);
            };

        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}