using Android.App;
using Android.OS;
using Android.Runtime;
using Android.Widget;
using AndroidX.AppCompat.App;

namespace AppTickets
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        EditText txtUsuario;
        EditText txtClave;
        Button btnIngresar;
        Button btnRegistrar;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);
            txtUsuario = FindViewById<EditText>(Resource.Id.txtUsuario);
            txtClave = FindViewById<EditText>(Resource.Id.txtClave);
            btnIngresar = FindViewById<Button>(Resource.Id.btnIngreso);
            btnRegistrar = FindViewById<Button>(Resource.Id.btnRegistar);

            btnIngresar.Click += BtnIngresar_Click;
            btnRegistrar.Click += BtnRegistrar_Click;
        }

        private void BtnRegistrar_Click(object sender, System.EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void BtnIngresar_Click(object sender, System.EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}