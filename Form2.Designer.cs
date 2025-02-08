namespace SampObjectMove
{
    partial class ResultForm
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
            this.ResultFormBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // ResultFormBox
            // 
            this.ResultFormBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ResultFormBox.Location = new System.Drawing.Point(13, 13);
            this.ResultFormBox.Name = "ResultFormBox";
            this.ResultFormBox.ReadOnly = true;
            this.ResultFormBox.Size = new System.Drawing.Size(693, 425);
            this.ResultFormBox.TabIndex = 0;
            this.ResultFormBox.Text = "copy";
            // 
            // ResultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 450);
            this.Controls.Add(this.ResultFormBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ResultForm";
            this.Text = "Результат :3";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox ResultFormBox;
    }
}