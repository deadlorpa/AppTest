using Android.App;
using Android.OS;
using Android.Runtime;
using AndroidX.AppCompat.App;
using Android.Widget;
using Android.Content;

namespace AppTest
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_main);
            Button buttonGO = FindViewById<Button>(Resource.Id.buttonGO);
            EditText editTextGO = FindViewById<EditText>(Resource.Id.editTextGO);
            buttonGO.Click += delegate
            {
                Intent intent = new Intent(this, typeof(Dother));
                intent.PutExtra("info", editTextGO.Text.ToString());
                StartActivity(intent);
            };
            editTextGO.Text = Intent.GetStringExtra("infoBack");
        }

    }
}