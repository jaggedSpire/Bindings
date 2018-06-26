using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Bindings
{
    /// <summary>
    /// It's some data, geddit? haha
    /// model for summing properties
    /// </summary>
    class SumData : INotifyPropertyChanged
    {
        private int _leftHandSide = 1;
        private int _rightHandSide = 2;
        private int _sum = 3;

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
