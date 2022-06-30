using System.ComponentModel;
using System.Windows.Input;
using Prism.Commands;

namespace MvvmCounter
{
    public class CounterViewModel : INotifyPropertyChanged
    {
        private readonly ICountSaver _countSaver;

        private int _count;
        public int Count
        {
            get => _count;
            set
            {
                _count = value;
                OnPropertyChanged(nameof(Count));
            }
        }

        public ICommand UpCommand { get; set; }
        public ICommand SaveCommand { get; set; }

        public CounterViewModel()
        {
            Count = 0;
            UpCommand = new DelegateCommand(ExecuteUp);
            SaveCommand = new DelegateCommand(ExecuteSave);
            _countSaver = new FileCountSaver();
        }

        private void ExecuteUp()
        {
            Count += 1;
        }

        private void ExecuteSave()
        {
            _countSaver?.Save(Count);
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
