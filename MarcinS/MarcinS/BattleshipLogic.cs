using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarcinS
{
    public class BattleshipLogic: INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        ObservableCollection<int> _PlayerOne = new ObservableCollection<int>
        { };
        ObservableCollection<int> _PlayerTwo = new ObservableCollection<int>
        { };


        protected virtual void OnPropertyChanged(string propertyName)
        {
            var handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }

        public ObservableCollection<int> PlayerOne
        {
            get
            {
                return _PlayerOne;
            }
            set
            {
                _PlayerOne = value;
                OnPropertyChanged("PersonId");
            }
        }

        public ObservableCollection<int> PlayerTwo
        {
            get
            {
                return _PlayerTwo;
            }
            set
            {
                _PlayerTwo = value;
                OnPropertyChanged("PersonId");
            }
        }

        public BattleshipLogic(int[] nPlayerOne, int[] nPlayerTwo)
        {
            foreach (int _person in nPlayerOne)
            {
                _PlayerOne.Add(_person);
            }

            foreach (int _person in nPlayerTwo)
            {
                _PlayerTwo.Add(_person);
            }

        }

    }
}
