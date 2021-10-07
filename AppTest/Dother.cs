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

namespace AppTest
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme")]
    public class Dother : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_second);
            Button buttonBACK = FindViewById<Button>(Resource.Id.buttonBACK);
            EditText editTextBACK = FindViewById<EditText>(Resource.Id.editTextBACK);
            editTextBACK.Text = Intent.GetStringExtra("info");
            buttonBACK.Click += delegate
            {
                Intent intent = new Intent(this, typeof(MainActivity));
                intent.PutExtra("infoBack", editTextBACK.Text.ToString());
                StartActivity(intent);
            };
        }
    }
}