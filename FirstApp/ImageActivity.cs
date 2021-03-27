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
    [Activity(Label = "ImageActivity")]
    public class ImageActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.car_image_layout);
            var imageView = FindViewById<ImageView>(Resource.Id.onlyCarImageView);
            var imageId = Intent.GetIntExtra("imageId", 0);
            imageView.SetImageResource(imageId);
        }
    }
}