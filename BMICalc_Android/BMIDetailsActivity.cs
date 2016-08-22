using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace BMICalc_Android
{
    [Activity(Label = "BMIDetailsActivity")]
    public class BMIDetailsActivity : Activity
    {
        TextView bmiDetailTextView;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.BMIDetails);

            float bmi = Intent.Extras.GetFloat("bmi_value");

            bmiDetailTextView = FindViewById<TextView>(BMICalc_Android.Resource.Id.bmiDetailTextView);

            EvaluateBMI(bmi);
        }

        void EvaluateBMI(float bmi)
        {
            string result = "";

            if (bmi <= 16)
                result = "very low";
            else if (bmi < 18.5)
                result = "low";
            else if (bmi < 25)
                result = "normal";
            else if (bmi < 30)
                result = "high";
            else
                result = "too high";

            bmiDetailTextView.Text = result;            
        }
    }
}