using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace BMICalc_Android
{
    [Activity(Label = "BMICalc_Android", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        EditText weightEditText, heightEditText;
        TextView bmiTextView;
        Button calculateButton, bmiDetailsButton;
        float bmi = 20.0f;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            // Get our button from the layout resource,
            // and attach an event to it
            weightEditText = FindViewById<EditText>(BMICalc_Android.Resource.Id.weightEditText);
            heightEditText = FindViewById<EditText>(BMICalc_Android.Resource.Id.heightEditText);
            bmiTextView = FindViewById<TextView>(BMICalc_Android.Resource.Id.bmiTextView);
            calculateButton = FindViewById<Button>(BMICalc_Android.Resource.Id.calculateButton);
            bmiDetailsButton = FindViewById<Button>(BMICalc_Android.Resource.Id.showDetailsButton);

            calculateButton.Click += CalculateButton_Click;

            bmiDetailsButton.Click += BmiDetailsButton_Click;
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            float height = float.Parse(heightEditText.Text);
            float weight = float.Parse(weightEditText.Text);

            bmi = (weight / (height * height));
            bmiTextView.Text = bmi.ToString();
        }

        private void BmiDetailsButton_Click(object sender, EventArgs e)
        {
            var intent = new Intent(this, typeof(BMIDetailsActivity));
            StartActivity(intent);
        }
    }
}

