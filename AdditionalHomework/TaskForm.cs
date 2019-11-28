using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

            var dataBindControl = new Binding("Text", infoBoxes, "CheckBoxText",
                true, DataSourceUpdateMode.OnPropertyChanged);
            ControlBox.DataBindings.Add(dataBindControl);

        }
    }
}
