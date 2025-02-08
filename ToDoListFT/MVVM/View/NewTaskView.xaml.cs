using ToDoListFT.MVVM.Model;
using ToDoListFT.MVVM.ViewModel;

namespace ToDoListFT.MVVM.View;

public partial class NewTaskView : ContentPage
{
	public NewTaskView()
	{
		InitializeComponent();
	}

    private void AddTaskClicked(object sender, EventArgs e)
    {
		var vm = BindingContext as NewTaskViewModel;

		var task = new MyTask
		{
            Title = vm.Title,
            Description = vm.Description
        };
		vm.Tasks.Add(task);
        Navigation.PopAsync();
    }
}