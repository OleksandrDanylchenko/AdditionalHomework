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
            this.SecondBox = new System.Windows.Forms.RichTextBox();
            this.FirstBox = new System.Windows.Forms.RichTextBox();
            this.CheckLabel = new System.Windows.Forms.Label();
            this.ControlLabel = new System.Windows.Forms.Label();
            this.SimilarityLabel = new System.Windows.Forms.Label();
            this.PercentLabel = new System.Windows.Forms.Label();
            this.ClearFirstExprButton = new System.Windows.Forms.Button();
            this.LoadFirstExprButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.ClearSecondExprButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SecondBox
            // 
            this.SecondBox.BackColor = System.Drawing.SystemColors.ControlLight;
            resources.ApplyResources(this.SecondBox, "SecondBox");
            this.SecondBox.Name = "SecondBox";
            // 
            // FirstBox
            // 
            this.FirstBox.BackColor = System.Drawing.SystemColors.ControlLight;
            resources.ApplyResources(this.FirstBox, "FirstBox");
            this.FirstBox.Name = "FirstBox";
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
            this.PercentLabel.UseCompatibleTextRendering = true;
            // 
            // ClearFirstExprButton
            // 
            resources.ApplyResources(this.ClearFirstExprButton, "ClearFirstExprButton");
            this.ClearFirstExprButton.Name = "ClearFirstExprButton";
            this.ClearFirstExprButton.UseVisualStyleBackColor = true;
            this.ClearFirstExprButton.Click += new System.EventHandler(this.ClearFirstExprButton_Click);
            // 
            // LoadFirstExprButton
            // 
            resources.ApplyResources(this.LoadFirstExprButton, "LoadFirstExprButton");
            this.LoadFirstExprButton.Name = "LoadFirstExprButton";
            this.LoadFirstExprButton.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // ClearSecondExprButton
            // 
            resources.ApplyResources(this.ClearSecondExprButton, "ClearSecondExprButton");
            this.ClearSecondExprButton.Name = "ClearSecondExprButton";
            this.ClearSecondExprButton.UseVisualStyleBackColor = true;
            this.ClearSecondExprButton.Click += new System.EventHandler(this.ClearSecondExprButton_Click);
            // 
            // TaskForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ClearSecondExprButton);
            this.Controls.Add(this.LoadFirstExprButton);
            this.Controls.Add(this.ClearFirstExprButton);
            this.Controls.Add(this.PercentLabel);
            this.Controls.Add(this.SimilarityLabel);
            this.Controls.Add(this.ControlLabel);
            this.Controls.Add(this.CheckLabel);
            this.Controls.Add(this.FirstBox);
            this.Controls.Add(this.SecondBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "TaskForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox SecondBox;
        private System.Windows.Forms.RichTextBox FirstBox;
        private System.Windows.Forms.Label CheckLabel;
        private System.Windows.Forms.Label ControlLabel;
        private System.Windows.Forms.Label SimilarityLabel;
        private System.Windows.Forms.Label PercentLabel;
        private System.Windows.Forms.Button ClearFirstExprButton;
        private System.Windows.Forms.Button LoadFirstExprButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button ClearSecondExprButton;
    }
}

