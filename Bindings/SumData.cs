using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Bindings
{
    /// <summary>
    /// It's some data, geddit? haha
    /// model for summing properties
    /// </summary>
    public class SumData : INotifyPropertyChanged
    {
        private int _leftHandSide;
        private int _rightHandSide;

        public event PropertyChangedEventHandler PropertyChanged;


        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public int LeftHandSide
        {
            get => _leftHandSide;
            set
            {
                if (value == _leftHandSide)
                {
                    return;
                }

                _leftHandSide = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(Sum));
            }
        }

        public int RightHandSide
        {
            get => _rightHandSide;
            set
            {
                if (value == _rightHandSide)
                {
                    return;
                }

                _rightHandSide = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(Sum));
            }
        }

        public int Sum => LeftHandSide + RightHandSide;
    }

}
