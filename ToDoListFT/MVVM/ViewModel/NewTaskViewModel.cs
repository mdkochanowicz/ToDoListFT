using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoListFT.MVVM.Model;

namespace ToDoListFT.MVVM.ViewModel
{
    public class NewTaskViewModel
    {
        public string Task { get; set; }
        public ObservableCollection<MyTask> Tasks { get; set; }
    }
}
