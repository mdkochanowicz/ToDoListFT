using System.Collections.ObjectModel;
using ToDoListFT.MVVM.Model;

namespace ToDoListFT.MVVM.ViewModel
{
    public class NewTaskViewModel
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public ObservableCollection<MyTask> Tasks { get; set; }
        public MainViewModel MainViewModel { get; set; }
    }
}
