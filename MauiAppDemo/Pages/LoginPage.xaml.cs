using System;
using Microsoft.Maui.Controls;

namespace MauiAppDemo.Pages
{
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private async void OnLoginButtonClicked(object sender, EventArgs e)
        {
            string username = UsernameEntry.Text;
            string password = PasswordEntry.Text;

            // L�gica de autenticaci�n (ejemplo b�sico)
            if (username == "usuario" && password == "contrase�a")
            {
                // Redirigir a la p�gina principal si el login es exitoso
                Application.Current.MainPage = new AppShell(); // O AppShell si usas Shell
            }
            else
            {
                await DisplayAlert("Error", "Credenciales incorrectas. Int�ntalo de nuevo.", "OK");
            }
        }
    }
}