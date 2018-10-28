using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using Android.Content;

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

            var number1TextView = FindViewById<EditText>(Resource.Id.editText1);
            var number2TextView = FindViewById<EditText>(Resource.Id.editText2);
            var calculateButton = FindViewById<Button>(Resource.Id.button1);
            var resetButton = FindViewById<Button>(Resource.Id.button2);
            var plusButton = FindViewById<Button>(Resource.Id.button3);
            var minusButton = FindViewById<Button>(Resource.Id.button4);
            var answerTextView = FindViewById<TextView>(Resource.Id.textView2);

            minusButton.Click += delegate
            {

            };

            minusButton.Click += delegate
            {

            };

            calculateButton.Click += delegate
            {
                var num1 = long.Parse(number1TextView.Text);
                var num2 = long.Parse(number2TextView.Text);
                var answer = num1 + num2;
                string ansText = "Vastus: ";

                answerTextView.Text = ansText.ToString() + answer.ToString();
            };

            resetButton.Click += delegate
            {
                var intent = new Intent(this, typeof(MainActivity));
                intent.SetFlags(ActivityFlags.ClearTop);
                StartActivity(intent);
            };
        }
    }
}