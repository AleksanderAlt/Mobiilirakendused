using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FirstApp
{
    [Activity(Label = "CalculatorActivity")]
    public class CalculatorActivity : Activity
    {
        EditText _number1;
        EditText _number2;
        TextView _answer;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.calcularor_layout);

            _number1 = FindViewById<EditText>(Resource.Id.number1);
            _number2 = FindViewById<EditText>(Resource.Id.number2);
            _answer = FindViewById<TextView>(Resource.Id.answer);
            var calculateButton = FindViewById<Button>(Resource.Id.calculate);

            calculateButton.Click += CalculateButtonClick;
        }
        private void CalculateButtonClick(object sender, EventArgs e)
        {
            _answer.Text = (int.Parse(_number1.Text) + int.Parse(_number2.Text)).ToString();
        }
    }
}