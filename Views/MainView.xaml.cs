using Microsoft.Maui.Graphics.Text;
using OperacionesBasicas.ViewModels;

namespace OperacionesBasicas.Views;

public partial class MainView : ContentPage
{
	private OperacionesViewModel ViewModel;
	public MainView()
	{
        InitializeComponent();
        ViewModel = new OperacionesViewModel();
        this.BindingContext = ViewModel;
    }



}