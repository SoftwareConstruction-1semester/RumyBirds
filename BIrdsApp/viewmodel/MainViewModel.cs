using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using BIrdsApp.Annotations;
using BIrdsApp.Model;

namespace BIrdsApp.viewmodel
{
    class MainViewModel : INotifyPropertyChanged
    {
        private BirdModel _birdOne;
        private BirdModel _birdTwo;

        public MainViewModel()
        {
            _birdOne = new BirdModel();
            _birdOne.Species = "Red Lory";
            _birdOne.Color = "Red";
            _birdOne.Origin = "Indonesia";
            _birdOne.Size = 31;

            _birdTwo = new BirdModel();
            _birdTwo.Species = "gossy l";
            _birdTwo.Color = "Green mostly";
            _birdTwo.Origin = "China";
            _birdTwo.Size = 700;
        }

        public BirdModel BirdOne
        {
            get { return _birdOne; }
            set { _birdOne = value; }
        }

        public BirdModel BirdTwo
        {
            get { return _birdTwo; }
            set { _birdTwo = value; }
        }
        


        #region implementation of notifyprop....
        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }
}
