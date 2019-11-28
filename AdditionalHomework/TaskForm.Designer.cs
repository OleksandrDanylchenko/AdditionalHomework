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
            this.PercentBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ControlBox
            // 
            this.ControlBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ControlBox.Font = new System.Drawing.Font("HP Simplified", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ControlBox.Location = new System.Drawing.Point(523, 91);
            this.ControlBox.Name = "ControlBox";
            this.ControlBox.Size = new System.Drawing.Size(515, 592);
            this.ControlBox.TabIndex = 0;
            this.ControlBox.Text = "";
            // 
            // CheckBox
            // 
            this.CheckBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.CheckBox.Font = new System.Drawing.Font("HP Simplified", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckBox.Location = new System.Drawing.Point(26, 91);
            this.CheckBox.Name = "CheckBox";
            this.CheckBox.Size = new System.Drawing.Size(477, 592);
            this.CheckBox.TabIndex = 1;
            this.CheckBox.Text = "";
            // 
            // CheckLabel
            // 
            this.CheckLabel.AutoSize = true;
            this.CheckLabel.Font = new System.Drawing.Font("HP Simplified", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckLabel.Location = new System.Drawing.Point(12, 9);
            this.CheckLabel.Name = "CheckLabel";
            this.CheckLabel.Size = new System.Drawing.Size(491, 79);
            this.CheckLabel.TabIndex = 2;
            this.CheckLabel.Text = "Check expression:";
            // 
            // ControlLabel
            // 
            this.ControlLabel.AutoSize = true;
            this.ControlLabel.Font = new System.Drawing.Font("HP Simplified", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ControlLabel.Location = new System.Drawing.Point(509, 9);
            this.ControlLabel.Name = "ControlLabel";
            this.ControlLabel.Size = new System.Drawing.Size(529, 79);
            this.ControlLabel.TabIndex = 3;
            this.ControlLabel.Text = "Control expression:";
            // 
            // SimilarityLabel
            // 
            this.SimilarityLabel.AutoSize = true;
            this.SimilarityLabel.Font = new System.Drawing.Font("HP Simplified", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SimilarityLabel.Location = new System.Drawing.Point(12, 711);
            this.SimilarityLabel.Name = "SimilarityLabel";
            this.SimilarityLabel.Size = new System.Drawing.Size(420, 79);
            this.SimilarityLabel.TabIndex = 4;
            this.SimilarityLabel.Text = "Similarity rate:";
            // 
            // PercentBox
            // 
            this.PercentBox.BackColor = System.Drawing.SystemColors.Menu;
            this.PercentBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PercentBox.Enabled = false;
            this.PercentBox.Font = new System.Drawing.Font("HP Simplified", 39F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PercentBox.Location = new System.Drawing.Point(428, 702);
            this.PercentBox.MaxLength = 6;
            this.PercentBox.Name = "PercentBox";
            this.PercentBox.ReadOnly = true;
            this.PercentBox.Size = new System.Drawing.Size(610, 86);
            this.PercentBox.TabIndex = 5;
            // 
            // TaskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1063, 807);
            this.Controls.Add(this.PercentBox);
            this.Controls.Add(this.SimilarityLabel);
            this.Controls.Add(this.ControlLabel);
            this.Controls.Add(this.CheckLabel);
            this.Controls.Add(this.CheckBox);
            this.Controls.Add(this.ControlBox);
            this.Font = new System.Drawing.Font("SF Mono", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "TaskForm";
            this.Text = "LevenshteinTask";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox ControlBox;
        private System.Windows.Forms.RichTextBox CheckBox;
        private System.Windows.Forms.Label CheckLabel;
        private System.Windows.Forms.Label ControlLabel;
        private System.Windows.Forms.Label SimilarityLabel;
        private System.Windows.Forms.TextBox PercentBox;
    }
}

