using System;
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

        private void ClearFirstExprButton_Click(object sender, EventArgs e)
        {
            FirstBox.Text = string.Empty;
        }

        private void ClearSecondExprButton_Click(object sender, EventArgs e)
        {
            SecondBox.Text = string.Empty;
        }

        private void TaskForm_Load(object sender, EventArgs e)
        {
            FirstBox.AllowDrop = true;
            FirstBox.DragDrop += FirstBox_DragDrop;

            SecondBox.AllowDrop = true;
            SecondBox.DragDrop += SecondBox_DragDrop;
        }

        private void FirstBox_DragDrop(object sender, DragEventArgs e)
        {
            var fileLoader = new FilesLoader(new DragDropLoader(FirstBox, e));
            fileLoader.LoadDataInBox();
        }

        private void SecondBox_DragDrop(object sender, DragEventArgs e)
        {
            var fileLoader = new FilesLoader(new DragDropLoader(SecondBox, e));
            fileLoader.LoadDataInBox();
        }

        private void LoadFirstExprButton_Click(object sender, EventArgs e)
        {
            var fileLoader = new FilesLoader(new ButtonLoader(FirstBox, OpenFileDialog));
            fileLoader.LoadDataInBox();
        }

        private void LoadSecondExprButton_Click(object sender, EventArgs e)
        {
            var fileLoader = new FilesLoader(new ButtonLoader(SecondBox, OpenFileDialog));
            fileLoader.LoadDataInBox();
        }
    }
}