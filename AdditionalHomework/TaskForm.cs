using System.Windows.Forms;

namespace AdditionalHomework
{
    public partial class TaskForm : Form
    {
        public TaskForm()
        {
            InitializeComponent();

            var infoBoxes = new InfoBoxes();

            var dataBindCheck = new Binding("Text", infoBoxes, "CheckBoxText",
                true, DataSourceUpdateMode.OnPropertyChanged);
            CheckBox.DataBindings.Add(dataBindCheck);

            var dataBindControl = new Binding("Text", infoBoxes, "ControlBoxText",
                true, DataSourceUpdateMode.OnPropertyChanged);
            ControlBox.DataBindings.Add(dataBindControl);

            var dataBindSimilarity = new Binding("Text", infoBoxes, "SimilarityPercent",
                true, DataSourceUpdateMode.OnPropertyChanged);
            PercentLabel.DataBindings.Add(dataBindSimilarity);
        }
    }
}
