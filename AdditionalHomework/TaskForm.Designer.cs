namespace AdditionalHomework
{
    partial class TaskForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TaskForm));
            this.ControlBox = new System.Windows.Forms.RichTextBox();
            this.CheckBox = new System.Windows.Forms.RichTextBox();
            this.CheckLabel = new System.Windows.Forms.Label();
            this.ControlLabel = new System.Windows.Forms.Label();
            this.SimilarityLabel = new System.Windows.Forms.Label();
            this.PercentLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ControlBox
            // 
            resources.ApplyResources(this.ControlBox, "ControlBox");
            this.ControlBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ControlBox.Name = "ControlBox";
            // 
            // CheckBox
            // 
            resources.ApplyResources(this.CheckBox, "CheckBox");
            this.CheckBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.CheckBox.Name = "CheckBox";
            // 
            // CheckLabel
            // 
            resources.ApplyResources(this.CheckLabel, "CheckLabel");
            this.CheckLabel.Name = "CheckLabel";
            // 
            // ControlLabel
            // 
            resources.ApplyResources(this.ControlLabel, "ControlLabel");
            this.ControlLabel.Name = "ControlLabel";
            // 
            // SimilarityLabel
            // 
            resources.ApplyResources(this.SimilarityLabel, "SimilarityLabel");
            this.SimilarityLabel.Name = "SimilarityLabel";
            // 
            // PercentLabel
            // 
            resources.ApplyResources(this.PercentLabel, "PercentLabel");
            this.PercentLabel.Name = "PercentLabel";
            // 
            // TaskForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PercentLabel);
            this.Controls.Add(this.SimilarityLabel);
            this.Controls.Add(this.ControlLabel);
            this.Controls.Add(this.CheckLabel);
            this.Controls.Add(this.CheckBox);
            this.Controls.Add(this.ControlBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "TaskForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox ControlBox;
        private System.Windows.Forms.RichTextBox CheckBox;
        private System.Windows.Forms.Label CheckLabel;
        private System.Windows.Forms.Label ControlLabel;
        private System.Windows.Forms.Label SimilarityLabel;
        private System.Windows.Forms.Label PercentLabel;
    }
}

