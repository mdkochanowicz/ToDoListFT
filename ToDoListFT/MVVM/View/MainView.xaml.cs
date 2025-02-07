using ToDoListFT.MVVM.ViewModel;

namespace ToDoListFT.MVVM.View;

public partial class MainView : ContentPage
{
	public MainView()
	{
		InitializeComponent();
        BindingContext = new MainViewModel();
    }
}