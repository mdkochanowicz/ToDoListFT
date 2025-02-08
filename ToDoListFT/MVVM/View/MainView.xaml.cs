using ToDoListFT.MVVM.Model;
using ToDoListFT.MVVM.ViewModel;

namespace ToDoListFT.MVVM.View;

public partial class MainView : ContentPage
{
    private MainViewModel mainViewModel;

    public MainView()
    {
        InitializeComponent();
        mainViewModel = new MainViewModel();
        BindingContext = mainViewModel;
    }

    private void checkBox_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {
        mainViewModel.DoneCounter();
        mainViewModel.SaveData();
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        var taskView = new NewTaskView
        {
            BindingContext = new NewTaskViewModel
            {
                Tasks = mainViewModel.Tasks,
                MainViewModel = mainViewModel
            }
        };

        Navigation.PushAsync(taskView);
    }

    private void DeleteTaskClicked(object sender, EventArgs e)
    {
        var button = sender as Button;
        var task = button.CommandParameter as MyTask;
        mainViewModel.DeleteTask(task);
    }
}

