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
            = new ObservableCollection<WorkerControlViewModel>() { new WorkerControlViewModel("Jacek") };
        public string OutputText { get; set; }
        public string InputText { get; set; }
        public ICommand SwapTextCommand { get; set; }

        public WorkersPageViewModel()
        {
            //OutputText = "1234";
            SwapTextCommand = new RelayCommand(TextCommand);
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        private void TextCommand()
        {
            OutputText = InputText;
            OnPropertyChanged(nameof(OutputText));
        }
    }
}
