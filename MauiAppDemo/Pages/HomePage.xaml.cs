using MauiAppDemo.ViewModels;

namespace MauiAppDemo.Pages;

public partial class HomePage : ContentPage
{
    private HomeViewModel _viewModel;

    public HomePage()
	{
		InitializeComponent();
	}

    public HomePage(HomeViewModel viewModel)
    {

        InitializeComponent();

        _viewModel = viewModel;
        BindingContext = viewModel;

    }

    protected async override void OnAppearing()
    {
        base.OnAppearing();

        await _viewModel.UpgradeHomeViewModel();

        // Simulaci�n de una tarea asincr�nica para cargar datos
        // await Task.Delay(1000); // Simulaci�n de un retraso

        // Aqu� puedes actualizar el ViewModel con datos obtenidos asincr�nicamente
        //_viewModel.Message = "Datos cargados exitosamente!";
    }

}