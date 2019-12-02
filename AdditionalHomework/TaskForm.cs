using System.Windows.Forms;

namespace AdditionalHomework
{
    public partial class TaskForm : Form
    {
        public TaskForm()
        {
            InitializeComponent();

            var infoBoxes = new InfoBoxes();

            var firstExprBind = new Binding("Text", infoBoxes, "FirstBoxText",
                true, DataSourceUpdateMode.OnPropertyChanged);
            FirstBox.DataBindings.Add(firstExprBind);

            var secondExprBind = new Binding("Text", infoBoxes, "SecondBoxText",
                true, DataSourceUpdateMode.OnPropertyChanged);
            SecondBox.DataBindings.Add(secondExprBind);

            var similarityBind = new Binding("Text", infoBoxes, "SimilarityPercent",
                true, DataSourceUpdateMode.OnPropertyChanged);
            PercentLabel.DataBindings.Add(similarityBind);
        }

        private void ClearFirstExprButton_Click(object sender, System.EventArgs e)
        {
            FirstBox.Text = string.Empty;
        }

        private void ClearSecondExprButton_Click(object sender, System.EventArgs e)
        {
            SecondBox.Text = string.Empty;
        }
    }
}
