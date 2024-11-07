
using Front.Infrastructure.ClientApi;
using MauiAppDemo.ViewModels;


namespace MauiAppDemo.Pages
{
    public partial class LoginPage : ContentPage
    {
        private readonly ITokenServiceClient _tokenServiceClient;

        public LoginPage()
        {
            InitializeComponent();
        }


        public LoginPage(LoginViewModel viewModel)
        {
            
            BindingContext = viewModel;

        }

        /*
        public LoginPage(ITokenServiceClient tokenServiceClient)
        {
            _tokenServiceClient = tokenServiceClient;
        }
        */

        /*
        private async void OnLoginButtonClicked(object sender, EventArgs e)
        {


            // L�gica de autenticaci�n (ejemplo b�sico)
            if (UserName == "usuario" && Password == "contrase�a")
            {

                // Guardar token
                Preferences.Set("nombre_usuario", "Juan");

                // Redirigir a la p�gina principal si el login es exitoso
                Application.Current.MainPage = new AppShell(); // O AppShell si usas Shell
            }
            else
            {
                await DisplayAlert("Error", "Credenciales incorrectas. Int�ntalo de nuevo.", "OK");
            }
        }

        */
    }
}