using MauiAppDemo.ViewModels;

namespace MauiAppDemo.Pages 
{
    public partial class EmployeerList : ContentPage
    {
        private EmployerListViewModel _viewModel;

        public EmployeerList()
        {
            InitializeComponent();
        }

        public EmployeerList(EmployerListViewModel viewModel)
        {
            InitializeComponent();

            _viewModel = viewModel;
            BindingContext = viewModel;

            // Cargar los primeros empleados cuando la p�gina aparezca
            LoadEmployees();

        }

        // Cargar los empleados iniciales
        private async void LoadEmployees()
        {
            await _viewModel.LoadEmployeesAsync();
        }

        // Evento que se ejecuta cuando un �tem aparece en la pantalla
        private async void OnItemAppearing(object sender, ItemVisibilityEventArgs e)
        {
            // Verificar si el �ltimo �tem visible es el �ltimo �tem de la lista
            var lastItem = _viewModel.EmployeList[_viewModel.EmployeList.Count - 1];
            if (e.Item == lastItem)
            {
                // Cargar m�s empleados
                await _viewModel.LoadEmployeesAsync();
            }
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();
           
        }
    }


}

