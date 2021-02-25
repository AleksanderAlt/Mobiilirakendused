using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using FirstApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FirstApp
{
    [Activity(Label = "SampleListActivity")]
    public class SampleListActivity : Activity //ListActivity
    {
        List<Car> items;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.simplelist_layout);

            var listView = FindViewById<ListView>(Resource.Id.listView1);

            items = new List<Car> {
                new Car {Manufacturer = "Ford", Model = "Focus", KW = 100, Image = Resource.Drawable.ford },
                new Car {Manufacturer = "Ford", Model = "Galaxy", KW = 130, Image = Resource.Drawable.ford },
                new Car {Manufacturer = "Ford", Model = "Fiesta", KW = 50, Image = Resource.Drawable.ford },
                new Car {Manufacturer = "Ford", Model = "Mustang", KW = 200, Image = Resource.Drawable.ford },
                new Car {Manufacturer = "Ford", Model = "GT", KW = 250, Image = Resource.Drawable.ford },
                new Car {Manufacturer = "Ford", Model = "Escape", KW = 140, Image = Resource.Drawable.ford },
                new Car {Manufacturer = "Ford", Model = "Transit", KW = 90, Image = Resource.Drawable.ford },
                new Car {Manufacturer = "Ford", Model = "Super Dudy", KW = 160, Image = Resource.Drawable.ford },
                new Car {Manufacturer = "Ford", Model = "Mondeo", KW = 105, Image = Resource.Drawable.ford },
                new Car {Manufacturer = "Ford", Model = "Puma", KW = 92, Image = Resource.Drawable.ford },
                new Car {Manufacturer = "Ford", Model = "Ranger", KW = 115, Image = Resource.Drawable.ford },
                new Car {Manufacturer = "Nissan", Model = "X-trail", KW = 200  },
                new Car {Manufacturer = "Lada", Model = "Vesta", KW = 10  },
                new Car {Manufacturer = "VolksWagen", Model = "Golf", KW = 77, Image = Resource.Drawable.volkswagen },
                new Car {Manufacturer = "VolksWagen", Model = "Jetta", KW = 87, Image = Resource.Drawable.volkswagen },
                new Car {Manufacturer = "VolksWagen", Model = "Tiguan", KW = 134, Image = Resource.Drawable.volkswagen },
                new Car {Manufacturer = "VolksWagen", Model = "Passat", KW = 120, Image = Resource.Drawable.volkswagen }
            };
            listView.Adapter = new CarAdapter(this, items);

            listView.ItemClick += delegate (object sender, AdapterView.ItemClickEventArgs args)
            {
                var car = items[args.Position].Manufacturer;
                Toast.MakeText(this, car, ToastLength.Long).Show(); // Show picture if click on Manufacturer
            };
        }
    }
}