using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;

namespace Bindings
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {

        private int _leftHandSide = 1;
        private int _rightHandSide = 2;
        private int _sum = 3;

        public MainWindow()
        {
            InitializeComponent();
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnNotifyPropertyChanged([CallerMemberName]string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        public int LeftHandSide
        {
            get { return _leftHandSide; }
            set
            {
                if (_leftHandSide == value) { return; }
                _leftHandSide = value;
                OnNotifyPropertyChanged();
                Sum = LeftHandSide + RightHandSide;
            }
        }

        public int RightHandSide
        {
            get { return _rightHandSide; }
            set
            {
                if (_rightHandSide == value) { return; }
                _rightHandSide = value;
                OnNotifyPropertyChanged();
                Sum = LeftHandSide + RightHandSide;
            }
        }

        public int Sum
        {
            get { return _sum; }
            private set
            {
                if (_sum == value) { return; }
                _sum = value;
                OnNotifyPropertyChanged();
            }
        }
    }
}
