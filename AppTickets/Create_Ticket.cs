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

namespace AppTickets
{
    [Activity(Label = "Create_Ticket")]

    public class Create_Ticket : Activity
    {

        EditText txtNombreTicket;        
        EditText txtOrigen;
        EditText txtDestino;
        EditText txtValor;
        Button btnCrearTicket;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Crear_Ticket);
            txtNombreTicket = FindViewById<EditText>(Resource.Id.txtNombreTicket);
            txtOrigen = FindViewById<EditText> (Resource.Id.txtOrigen);
            txtDestino = FindViewById<EditText>(Resource.Id.txtDestino);
            txtValor = FindViewById<EditText>(Resource.Id.txtValor);
            btnCrearTicket = FindViewById<Button>(Resource.Id.btnCrearTicket);

            btnCrearTicket.Click += BtnCrearTicket_Click;

        }

        private void BtnCrearTicket_Click(object sender, EventArgs e)
        {
            try 
            {
                if (!string.IsNullOrEmpty(txtNombreTicket.Text.Trim()))
                {
                    new Auxiliar().GuardarTicket(new CrearTicket()
                    {
                        Id = 0,
                        NombreTicket = txtNombreTicket.Text.Trim(),
                        OrigenTicket = txtOrigen.Text.Trim(),
                        DestinoTicket = txtDestino.Text.Trim(),
                        ValorTicket = double.Parse(txtValor.Text.Trim())
                    });
                    Toast.MakeText(this, "Registro Guardado", ToastLength.Long).Show();
                    txtNombreTicket.Text = "";
                    txtOrigen.Text = "";
                    txtDestino.Text = "";
                    txtValor.Text = "";
                }
                else 
                {
                    Toast.MakeText(this, "Ingrese los campos requeridos", ToastLength.Long).Show();
                }

            }
            catch (System.Exception ex)
            {
                Toast.MakeText(this, ex.ToString(), ToastLength.Short).Show();
            }
        }
    }
}