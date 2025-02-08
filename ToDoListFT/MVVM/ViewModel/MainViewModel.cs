using PropertyChanged;
using System.Collections.ObjectModel;
using System.Text.Json;
using ToDoListFT.MVVM.Model;
using Microsoft.Maui.Storage;

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

        public void AddTask(MyTask task)
        {
            Tasks.Add(task);
            DoneCounter();
            SaveData();
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

        public void LoadData()
        {
            var tasksJson = Preferences.Get("Tasks", string.Empty);
            if (!string.IsNullOrEmpty(tasksJson))
            {
                var tasks = JsonSerializer.Deserialize<ObservableCollection<MyTask>>(tasksJson);
                Tasks.Clear();
                foreach (var task in tasks)
                {
                    Tasks.Add(task);
                }
            }
        }

        public void DeleteTask(MyTask task)
        {
            Tasks.Remove(task);
            DoneCounter();
            SaveData();
        }
    }
}

