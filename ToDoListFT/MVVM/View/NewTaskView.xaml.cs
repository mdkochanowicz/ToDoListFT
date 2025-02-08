using ToDoListFT.MVVM.Model;
using ToDoListFT.MVVM.ViewModel;

namespace ToDoListFT.MVVM.View;

public partial class NewTaskView : ContentPage
{
    public NewTaskView()
    {
        InitializeComponent();
    }

    private async void AddTaskClicked(object sender, EventArgs e)
    {
        var vm = BindingContext as NewTaskViewModel;

        if (string.IsNullOrWhiteSpace(vm.Title))
        {
            await DisplayAlert("Validation Error", "Task title is required.", "OK");
            return;
        }

        var task = new MyTask
        {
            Title = vm.Title,
            Description = vm.Description
        };
        vm.Tasks.Add(task);
        await Navigation.PopAsync();
    }
}
