using ToDoListFT.MVVM.View;

namespace ToDoListFT
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NewTaskView();
        }
    }
}
