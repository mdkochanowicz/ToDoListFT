using ToDoListFT.MVVM.ViewModel;

namespace ToDoListFT.MVVM.View;

public partial class MainView : ContentPage
{
	private MainViewModel mainViewModel = new MainViewModel();
    public MainView()
	{
		InitializeComponent();
        BindingContext = mainViewModel;
    }

    private void checkBox_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {
        mainViewModel.DoneCounter();
    }

    private void Button_Clicked(object sender, EventArgs e)
    {

    }
}