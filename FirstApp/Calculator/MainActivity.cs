using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;

namespace Calculator
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            var count = 0;

            var a = 1;
            var b = 2;

            var firstTextView = FindViewById<TextView>(Resource.Id.textView1);
            var firstButton = FindViewById<Button>(Resource.Id.button2);
            var secondButton = FindViewById<Button>(Resource.Id.button3);

            firstButton.Click += delegate
            {
                
            };
           // var plus = firstButton + secondButton; ;
            //firstTextView.Text =
        }
    }
}