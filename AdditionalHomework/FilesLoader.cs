using AdditionalHomework.Properties;
using System.Linq;
using System.Windows.Forms;

namespace AdditionalHomework
{
    // Context
    internal class FilesLoader
    {
        private readonly Loader _loader;

        public FilesLoader(Loader desiredLoader)
        {
            _loader = desiredLoader;
        }

        public void LoadDataInBox()
        {
            _loader.Load();
        }
    }

    // Strategy
    internal abstract class Loader
    {
        public abstract void Load();

        protected static bool IsValidFileFormat(string filePath)
        {
            filePath = filePath.ToLower();
            string[] validExtension = { ".txt", ".rtf", ".xml" };
            return validExtension.Any(filePath.Contains);
        }
    }

    // Concrete Strategy A
    internal class DragDropLoader : Loader
    {
        private readonly RichTextBox _desiredBox;
        private readonly DragEventArgs _dragEvent;

        public DragDropLoader(RichTextBox desiredBox, DragEventArgs dragEvent)
        {
            _desiredBox = desiredBox;
            _dragEvent = dragEvent;
        }

        public override void Load()
        {
            var filePath = GetDroppedFilePath(_dragEvent);
            if (filePath != null && IsValidFileFormat(filePath))
            {
                _desiredBox.LoadFile(filePath, RichTextBoxStreamType.PlainText);
            }
            else
            {
                MessageBox.Show(Resources.Invalid_format_warning,
                    Resources.Invalid_format_title, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private static string GetDroppedFilePath(DragEventArgs dragEvent)
        {
            string filePath = null;
            var data = dragEvent.Data.GetData(DataFormats.FileDrop);
            if (data is string[] filePaths && filePaths.Length > 0)
            {
                filePath = filePaths.FirstOrDefault();
            }

            return filePath;
        }
    }

    internal class ButtonLoader : Loader
    {
        private readonly RichTextBox _desiredBox;
        private readonly OpenFileDialog _openDialog;

        public ButtonLoader(RichTextBox desiredBox, OpenFileDialog openDialog)
        {
            _desiredBox = desiredBox;
            _openDialog = openDialog;
        }

        public override void Load()
        {
            var filePath = GetChosenFilePath(_openDialog);
            if (filePath != null && string.IsNullOrWhiteSpace(filePath))
            {
            }
            else if (filePath != null && IsValidFileFormat(filePath))
            {
                _desiredBox.LoadFile(filePath, RichTextBoxStreamType.PlainText);
            }
            else
            {
                MessageBox.Show(Resources.Invalid_format_warning,
                    Resources.Invalid_format_title, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private static string GetChosenFilePath(OpenFileDialog openDialog)
        {
            var dialogRes = openDialog.ShowDialog();
            var filePath = dialogRes switch
            {
                DialogResult.OK => openDialog.FileName,
                DialogResult.Cancel => string.Empty,
                _ => null
            };

            return filePath;
        }
    }
}