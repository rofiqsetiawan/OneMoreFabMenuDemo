// Created by rofiqsetiawan@gmail.com

using Android.App;
using Android.OS;
using Android.Support.Design.Widget;
using Android.Support.V7.App;
using Android.Util;
using Android.Views;
using Android.Widget;
using DekoServidoni.Omfm;
using R = OneMoreFabMenuDemo.Resource;
using Toolbar = Android.Support.V7.Widget.Toolbar;

namespace OneMoreFabMenuDemo
{
    [Activity(Label = "OneMoreFabMenuDemo", MainLauncher = true, Icon = "@mipmap/ic_launcher", Theme = "@style/AppTheme.NoActionBar")]
	public class MainActivity : AppCompatActivity /*, OneMoreFabMenu.IOptionsClick*/
    {
        private OneMoreFabMenu _fab;

        protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);
			SetContentView(R.Layout.activity_main);
			SetSupportActionBar(FindViewById<Toolbar>(R.Id.toolbar));

		    _fab = FindViewById<OneMoreFabMenu>(R.Id.fab);

            // if you implement OneMoreFabMenu.IOptionsClick in your activity
            //_fab.SetOptionsClick(this);


            // Set Listener
            //_fab.SetOptionsClick(new OptionsClick(
            //    optionId => {
            //        Log.Debug("SetListener", $"Click on {optionId}");
            //        WhenOptionClicked(optionId);
            //    }
            //));

            
            // Event Handler
            _fab.OptionClick += (s, e) =>
            {
                Log.Debug("EventHandler", $"Click on #{e.OptionId}");
                WhenOptionClicked(e.OptionId);
            };
            

            // Btn test
            FindViewById<Button>(R.Id.btn_test).Click += (s, e) =>
            {
                Snackbar.Make(((View)s), "Hello from Indonesia", Snackbar.LengthShort).Show();
            };
        }


		public void OnOptionClick(int optionId)
		{
		    Log.Debug("OneMoreFabMenu.IOptionsClick impl", $"Click on #{optionId}");
            WhenOptionClicked(optionId);
        }


        private void WhenOptionClicked(int optionId)
        {
            var text = "";

            switch (optionId)
            {
                case R.Id.option1:
                    text = "Option 1 clicked!";
                    break;

                case R.Id.option2:
                    text = "Option 2 clicked!";
                    break;

                case R.Id.option3:
                    text = "Option 3 clicked!";
                    break;

                case R.Id.option4:
                    text = "Option 4 clicked!";
                    break;
            }

            if (string.IsNullOrEmpty(text))
                return;

            var fragment = SupportFragmentManager.FindFragmentById(R.Id.fragment);
            Snackbar.Make(fragment.View, text, Snackbar.LengthShort)
                .SetAction("Done", view => Toast.MakeText(this, "Okay", ToastLength.Short).Show())
                .Show();
        }



    }
}

