using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdditionalHomework
{
    internal class InfoBoxes : INotifyPropertyChanged
    {
        private string _checkBoxText;
        public string CheckBoxText
        {
            get => _checkBoxText;
            set
            {
                if (_checkBoxText == value) return;
                _checkBoxText = value;
                OnPropertyChanged(CheckBoxText);
            }
        }

        private string _controlBoxText;
        public string ControlBoxText
        {
            get => _controlBoxText;
            set
            {
                if (_controlBoxText == value) return;
                _controlBoxText = value;
                OnPropertyChanged(CheckBoxText);
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string name)
        {
            var handler = PropertyChanged;
            handler?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
