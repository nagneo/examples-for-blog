using System.Windows.Controls;

namespace MvvmCounter
{
    /// <summary>
    /// CounterView.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class CounterView : UserControl
    {
        public CounterView()
        {
            InitializeComponent();
            DataContext = new CounterViewModel();
        }
    }
}
