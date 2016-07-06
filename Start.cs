using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Android;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace XHangman1
{
    [Activity(Label = "Start", MainLauncher = true, Icon = "@drawable/Icon")]
    public class Start : Activity
    {

        // private Spinner spinner; 
        private Button btnStart;
        //Spinner spinner;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.StartScreen);

            var Example = new string[]
            {
                "Andy", "Bill","Charlie"
            };
            btnStart = FindViewById<Button>(Resource.Id.btnStart);
            btnStart.Click += onBtnStartClcik;
           var  spinner = FindViewById<Spinner>(Resource.Id.spinner1);

            spinner.Adapter = new ArrayAdapter<string>(this, Android.Resource.Layout.SimpleSpinnerDropDownItem, Example);

        }

        private void onBtnStartClcik(object sender, EventArgs e)
        {
            StartActivity(typeof(MainActivity));
        }

        private void SpinnerSetup()
        {

            //spinner.ItemSelected += new EventHandler<AdapterView.ItemSelectedEventArgs>(spinner_ItemSelected);
            //var adapter = ArrayAdapter.CreateFromResource(this, Resource.Array.player, Android.Resource.Layout.SimpleSpinnerItem);

            //adapter.SetDropDownViewResource(Android.Resource.Layout.SimpleSpinnerDropDownItem);
            //spinner.Adapter = adapter;

        }
        private void spinner_ItemSelected(object sender, AdapterView.ItemSelectedEventArgs e)
        {

            Spinner spinner = (Spinner)sender;
            
            string toast = string.Format("Playing As {0}", spinner.GetItemAtPosition(e.Position));
            Toast.MakeText(this, toast, ToastLength.Long).Show();
        }

        //private void onBtnStartClick(object sender, EventArgs e)
        //{

        //    StartActivity(typeof(MainActivity));
        //}

        
    }
}