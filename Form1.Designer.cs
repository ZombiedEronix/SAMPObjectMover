namespace SampObjectMove
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.ButtonConvert = new System.Windows.Forms.Button();
            this.CenterX = new System.Windows.Forms.TextBox();
            this.CenterY = new System.Windows.Forms.TextBox();
            this.CenterZ = new System.Windows.Forms.TextBox();
            this.LabelCenterX = new System.Windows.Forms.Label();
            this.LabelCenterY = new System.Windows.Forms.Label();
            this.LabelCenterZ = new System.Windows.Forms.Label();
            this.ConvertButton = new System.Windows.Forms.Button();
            this.CodeText = new System.Windows.Forms.RichTextBox();
            this.CenterXBox = new System.Windows.Forms.TextBox();
            this.CenterXLabel = new System.Windows.Forms.Label();
            this.CenterYLabel = new System.Windows.Forms.Label();
            this.CenterYBox = new System.Windows.Forms.TextBox();
            this.CenterZLabel = new System.Windows.Forms.Label();
            this.CenterZBox = new System.Windows.Forms.TextBox();
            this.ObjectTypeBox = new System.Windows.Forms.ComboBox();
            this.ObjType = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ButtonConvert
            // 
            this.ButtonConvert.Location = new System.Drawing.Point(0, 0);
            this.ButtonConvert.Name = "ButtonConvert";
            this.ButtonConvert.Size = new System.Drawing.Size(75, 23);
            this.ButtonConvert.TabIndex = 6;
            this.ButtonConvert.UseVisualStyleBackColor = true;
            this.ButtonConvert.Click += new System.EventHandler(this.button1_Click);
            // 
            // CenterX
            // 
            this.CenterX.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.CenterX.Location = new System.Drawing.Point(0, 0);
            this.CenterX.Name = "CenterX";
            this.CenterX.Size = new System.Drawing.Size(100, 20);
            this.CenterX.TabIndex = 5;
            // 
            // CenterY
            // 
            this.CenterY.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.CenterY.Location = new System.Drawing.Point(0, 0);
            this.CenterY.Name = "CenterY";
            this.CenterY.Size = new System.Drawing.Size(100, 20);
            this.CenterY.TabIndex = 4;
            // 
            // CenterZ
            // 
            this.CenterZ.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.CenterZ.Location = new System.Drawing.Point(0, 0);
            this.CenterZ.Name = "CenterZ";
            this.CenterZ.Size = new System.Drawing.Size(100, 20);
            this.CenterZ.TabIndex = 3;
            // 
            // LabelCenterX
            // 
            this.LabelCenterX.Location = new System.Drawing.Point(0, 0);
            this.LabelCenterX.Name = "LabelCenterX";
            this.LabelCenterX.Size = new System.Drawing.Size(100, 23);
            this.LabelCenterX.TabIndex = 2;
            // 
            // LabelCenterY
            // 
            this.LabelCenterY.Location = new System.Drawing.Point(0, 0);
            this.LabelCenterY.Name = "LabelCenterY";
            this.LabelCenterY.Size = new System.Drawing.Size(100, 23);
            this.LabelCenterY.TabIndex = 1;
            // 
            // LabelCenterZ
            // 
            this.LabelCenterZ.Location = new System.Drawing.Point(0, 0);
            this.LabelCenterZ.Name = "LabelCenterZ";
            this.LabelCenterZ.Size = new System.Drawing.Size(100, 23);
            this.LabelCenterZ.TabIndex = 0;
            // 
            // ConvertButton
            // 
            this.ConvertButton.Location = new System.Drawing.Point(12, 434);
            this.ConvertButton.Name = "ConvertButton";
            this.ConvertButton.Size = new System.Drawing.Size(100, 23);
            this.ConvertButton.TabIndex = 8;
            this.ConvertButton.Text = "Convert";
            this.ConvertButton.UseVisualStyleBackColor = true;
            this.ConvertButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // CodeText
            // 
            this.CodeText.Location = new System.Drawing.Point(118, 36);
            this.CodeText.Name = "CodeText";
            this.CodeText.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth;
            this.CodeText.Size = new System.Drawing.Size(824, 421);
            this.CodeText.TabIndex = 9;
            this.CodeText.Text = "CreateDynamicObject(2000, -3853.51465, -2164.15625, -0.08196, 0.00000, 0.00000, 0" +
    ".00000, DM_WORLD, 12);";
            // 
            // CenterXBox
            // 
            this.CenterXBox.Location = new System.Drawing.Point(12, 52);
            this.CenterXBox.Name = "CenterXBox";
            this.CenterXBox.Size = new System.Drawing.Size(100, 20);
            this.CenterXBox.TabIndex = 10;
            this.CenterXBox.Text = "0.0";
            // 
            // CenterXLabel
            // 
            this.CenterXLabel.AutoSize = true;
            this.CenterXLabel.Location = new System.Drawing.Point(12, 36);
            this.CenterXLabel.Name = "CenterXLabel";
            this.CenterXLabel.Size = new System.Drawing.Size(45, 13);
            this.CenterXLabel.TabIndex = 11;
            this.CenterXLabel.Text = "CenterX";
            // 
            // CenterYLabel
            // 
            this.CenterYLabel.AutoSize = true;
            this.CenterYLabel.Location = new System.Drawing.Point(12, 75);
            this.CenterYLabel.Name = "CenterYLabel";
            this.CenterYLabel.Size = new System.Drawing.Size(45, 13);
            this.CenterYLabel.TabIndex = 13;
            this.CenterYLabel.Text = "CenterY";
            // 
            // CenterYBox
            // 
            this.CenterYBox.Location = new System.Drawing.Point(12, 91);
            this.CenterYBox.Name = "CenterYBox";
            this.CenterYBox.Size = new System.Drawing.Size(100, 20);
            this.CenterYBox.TabIndex = 12;
            this.CenterYBox.Text = "0.0";
            // 
            // CenterZLabel
            // 
            this.CenterZLabel.AutoSize = true;
            this.CenterZLabel.Location = new System.Drawing.Point(12, 114);
            this.CenterZLabel.Name = "CenterZLabel";
            this.CenterZLabel.Size = new System.Drawing.Size(45, 13);
            this.CenterZLabel.TabIndex = 15;
            this.CenterZLabel.Text = "CenterZ";
            // 
            // CenterZBox
            // 
            this.CenterZBox.Location = new System.Drawing.Point(12, 130);
            this.CenterZBox.Name = "CenterZBox";
            this.CenterZBox.Size = new System.Drawing.Size(100, 20);
            this.CenterZBox.TabIndex = 14;
            this.CenterZBox.Text = "0.0";
            // 
            // ObjectTypeBox
            // 
            this.ObjectTypeBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ObjectTypeBox.FormattingEnabled = true;
            this.ObjectTypeBox.ImeMode = System.Windows.Forms.ImeMode.Close;
            this.ObjectTypeBox.Items.AddRange(new object[] {
            "CreateObject",
            "CreateDynamicObject"});
            this.ObjectTypeBox.Location = new System.Drawing.Point(12, 169);
            this.ObjectTypeBox.Name = "ObjectTypeBox";
            this.ObjectTypeBox.Size = new System.Drawing.Size(100, 21);
            this.ObjectTypeBox.TabIndex = 16;
            // 
            // ObjType
            // 
            this.ObjType.AutoSize = true;
            this.ObjType.Location = new System.Drawing.Point(12, 153);
            this.ObjType.Name = "ObjType";
            this.ObjType.Size = new System.Drawing.Size(65, 13);
            this.ObjType.TabIndex = 17;
            this.ObjType.Text = "Object Type";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(954, 469);
            this.Controls.Add(this.ObjType);
            this.Controls.Add(this.ObjectTypeBox);
            this.Controls.Add(this.CenterZLabel);
            this.Controls.Add(this.CenterZBox);
            this.Controls.Add(this.CenterYLabel);
            this.Controls.Add(this.CenterYBox);
            this.Controls.Add(this.CenterXLabel);
            this.Controls.Add(this.CenterXBox);
            this.Controls.Add(this.CodeText);
            this.Controls.Add(this.ConvertButton);
            this.Controls.Add(this.LabelCenterZ);
            this.Controls.Add(this.LabelCenterY);
            this.Controls.Add(this.LabelCenterX);
            this.Controls.Add(this.CenterZ);
            this.Controls.Add(this.CenterY);
            this.Controls.Add(this.CenterX);
            this.Controls.Add(this.ButtonConvert);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "S.A.M.PObjectMover 0.1 | By ZombiedEronix";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button ButtonConvert;
        private System.Windows.Forms.TextBox CenterX;
        private System.Windows.Forms.TextBox CenterY;
        private System.Windows.Forms.TextBox CenterZ;
        private System.Windows.Forms.Label LabelCenterX;
        private System.Windows.Forms.Label LabelCenterY;
        private System.Windows.Forms.Label LabelCenterZ;
        private System.Windows.Forms.Button ConvertButton;
        private System.Windows.Forms.RichTextBox CodeText;
        private System.Windows.Forms.TextBox CenterXBox;
        private System.Windows.Forms.Label CenterXLabel;
        private System.Windows.Forms.Label CenterYLabel;
        private System.Windows.Forms.TextBox CenterYBox;
        private System.Windows.Forms.Label CenterZLabel;
        private System.Windows.Forms.TextBox CenterZBox;
        private System.Windows.Forms.ComboBox ObjectTypeBox;
        private System.Windows.Forms.Label ObjType;
    }
}

