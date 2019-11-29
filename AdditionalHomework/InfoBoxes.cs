using System.ComponentModel;

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
                if (CheckBoxText == value) return;
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
                if (ControlBoxText == value) return;
                _controlBoxText = value;
                OnPropertyChanged(ControlBoxText);
            }
        }

        public string SimilarityPercent => SimilarityEvaluator.GetPercent(CheckBoxText, ControlBoxText);

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string name)
        {
            var handler = PropertyChanged;
            handler?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
