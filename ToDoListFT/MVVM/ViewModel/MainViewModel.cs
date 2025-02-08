using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoListFT.MVVM.Model;

namespace ToDoListFT.MVVM.ViewModel
{
    public class MainViewModel
    {
        public ObservableCollection<MyTask> Tasks { get; set; }

        public int DoneCount { get; private set; }
        public int UndoneCount { get; private set; }

        public MainViewModel()
        {
            FillData();
        }

        private void FillData()
        {
            Tasks = new ObservableCollection<MyTask>
            {
                new MyTask
                {   Title = "Task 1",
                    Description = "Description 1",
                    IsCompleted = false
                },
                new MyTask
                {   Title = "Task 2",
                    Description = "Description 2",
                    IsCompleted = false
                },
                new MyTask
                {   Title = "Task 3",
                    Description = "Description 3",
                    IsCompleted = false
                }
            };

            DoneCounter();
        }

        public void DoneCounter()
        {
            DoneCount = Tasks.Count(t => t.IsCompleted);
            UndoneCount = Tasks.Count(t => !t.IsCompleted);
        }
    }
}
