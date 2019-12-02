using System.ComponentModel;

namespace AdditionalHomework
{
    internal class InfoBoxes : INotifyPropertyChanged
    {
        private string _firstBoxText;

        public string FirstBoxText
        {
            get => _firstBoxText;
            set
            {
                if (FirstBoxText == value) return;
                _firstBoxText = value;
                OnPropertyChanged(FirstBoxText);
            }
        }

        private string _secondBoxText;

        public string SecondBoxText
        {
            get => _secondBoxText;
            set
            {
                if (SecondBoxText == value) return;
                _secondBoxText = value;
                OnPropertyChanged(SecondBoxText);
            }
        }

        public string SimilarityPercent => SimilarityEvaluator
            .GetPercent(FirstBoxText, SecondBoxText);

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string name)
        {
            var handler = PropertyChanged;
            handler?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}