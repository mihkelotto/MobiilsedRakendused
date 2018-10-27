using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using Android.Content;

namespace FirstApp
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

            var firstTextView = FindViewById<TextView>(Resource.Id.textView1);
            var firstButton = FindViewById<Button>(Resource.Id.button1);

            var number1TextView = FindViewById<EditText>(Resource.Id.editText1);
            var number2TextView = FindViewById<EditText>(Resource.Id.editText2);
            var calculateButton = FindViewById<Button>(Resource.Id.button2);
            var minusButton = FindViewById<Button>(Resource.Id.button3);
            var answerTextView = FindViewById<TextView>(Resource.Id.textView2);
            var toSecondActivity = FindViewById<Button>(Resource.Id.button4);
            var toWebViewActivity = FindViewById<Button>(Resource.Id.button5);
            var toListViewActivity = FindViewById<Button>(Resource.Id.button6);




            firstButton.Click += delegate
            {
                count++;
                firstTextView.Text = count.ToString();
            };

           /* minusButton.Click += delegate
            {

            } */

            calculateButton.Click += delegate
            {
                var num1 = int.Parse(number1TextView.Text);
                var num2 = int.Parse(number2TextView.Text);
                var answer = num1 + num2;
                answerTextView.Text = answer.ToString();


            };

            toSecondActivity.Click += delegate
            {
                var secondActivity = new Intent(this, typeof(SecondActivity));
                secondActivity.PutExtra("MyData", "Hello World!!!!!!!!!!!!");
                StartActivity(secondActivity);
            };

            toWebViewActivity.Click += delegate
            {
                var webViewActivity = new Intent(this, typeof(WebViewActivity));
                StartActivity(webViewActivity);
            };

            toListViewActivity.Click += delegate
            {
                var listViewActivity = new Intent(this, typeof(ListofThingsActivity));
                StartActivity(listViewActivity);
            };


        }
    }
}