using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WorkersProject.Core
{
    public class WorkersPageViewModel : MainBase
    {
        public ObservableCollection<WorkerControlViewModel> WorkersListView { get; set; }
            = new ObservableCollection<WorkerControlViewModel>() 
            { 
                new WorkerControlViewModel("Jacek", "Nowak", "Developer", 33),
                new WorkerControlViewModel("Adam", "Kowal", "Tester", 21),
                new WorkerControlViewModel("Kamil", "Nowak", "Grafik", 22),
            };
        public string NewWorkerName { get; set; }
        public string NewWorkerSurname { get; set; }
        public string NewWorkerProfession { get; set; }
        public int NewWorkerAge { get; set; }
        public ICommand AddWorkerCommand { get; set; }

        public WorkersPageViewModel()
        {
            //OutputText = "1234";
            AddWorkerCommand = new RelayCommand(AddWorkerMethod);
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        private void AddWorkerMethod()
        {
            var newWorker = new WorkerControlViewModel(NewWorkerName, NewWorkerSurname, NewWorkerProfession, NewWorkerAge);
            WorkersListView.Add(newWorker);
            //OnPropertyChanged(nameof(OutputText));
        }
    }
}
