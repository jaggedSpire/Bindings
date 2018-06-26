using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;

namespace Bindings
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private SumData _sumData;

        public MainWindow()
        {
            InitializeComponent();
            _sumData = new SumData();
            DataContext = _sumData;
        }

    }
}
