using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using ToDoListFT.MVVM.Model;

namespace ToDoListFT.MVVM.ViewModel
{
    [AddINotifyPropertyChangedInterface]
    public class MainViewModel
    {
        public ObservableCollection<MyTask> Tasks { get; set; }

        public int DoneCount { get; private set; }
        public int UndoneCount { get; private set; }

        public MainViewModel()
        {
            Tasks = new ObservableCollection<MyTask>();
            LoadData();
            DoneCounter();
        }

        public void DoneCounter()
        {
            DoneCount = Tasks.Count(t => t.IsCompleted);
            UndoneCount = Tasks.Count(t => !t.IsCompleted);
        }
        public void SaveData()
        {
            var tasksJson = JsonSerializer.Serialize(Tasks);
            Preferences.Set("Tasks", tasksJson);
        }

        public void AddTask(MyTask task)
        {
            Tasks.Add(task);
            DoneCounter();
            SaveData();
        }

        public void LoadData()
        {
            var tasksJson = Preferences.Get("Tasks", string.Empty);
            if (!string.IsNullOrEmpty(tasksJson))
            {
                var tasks = JsonSerializer.Deserialize<ObservableCollection<MyTask>>(tasksJson);
                foreach (var task in tasks)
                {
                    Tasks.Add(task);
                }
            }
        }

    }
}
