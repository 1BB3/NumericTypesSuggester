namespace NumericTypesSuggester
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            LabelMinValue = new Label();
            LabelMaxValue = new Label();
            TextBoxMinValue = new TextBox();
            textBox1 = new TextBox();
            CheckBoxIsIntegralOnly = new CheckBox();
            CheckBoxMustBePrecise = new CheckBox();
            LabelSuggestedType = new Label();
            LabelSuggestedTypeValue = new Label();
            SuspendLayout();
            // 
            // LabelMinValue
            // 
            LabelMinValue.AutoSize = true;
            LabelMinValue.Font = new Font("Segoe UI", 16F);
            LabelMinValue.Location = new Point(166, 89);
            LabelMinValue.Name = "LabelMinValue";
            LabelMinValue.Size = new Size(221, 59);
            LabelMinValue.TabIndex = 0;
            LabelMinValue.Text = "Min Value:";
            // 
            // LabelMaxValue
            // 
            LabelMaxValue.AutoSize = true;
            LabelMaxValue.Font = new Font("Segoe UI", 16F);
            LabelMaxValue.Location = new Point(158, 177);
            LabelMaxValue.Name = "LabelMaxValue";
            LabelMaxValue.Size = new Size(229, 59);
            LabelMaxValue.TabIndex = 1;
            LabelMaxValue.Text = "Max Value:";
            // 
            // TextBoxMinValue
            // 
            TextBoxMinValue.Font = new Font("Segoe UI", 16F);
            TextBoxMinValue.Location = new Point(407, 84);
            TextBoxMinValue.Name = "TextBoxMinValue";
            TextBoxMinValue.ScrollBars = ScrollBars.Vertical;
            TextBoxMinValue.Size = new Size(1024, 64);
            TextBoxMinValue.TabIndex = 2;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 16F);
            textBox1.Location = new Point(407, 172);
            textBox1.Name = "textBox1";
            textBox1.ScrollBars = ScrollBars.Vertical;
            textBox1.Size = new Size(1024, 64);
            textBox1.TabIndex = 3;
            // 
            // CheckBoxIsIntegralOnly
            // 
            CheckBoxIsIntegralOnly.AutoSize = true;
            CheckBoxIsIntegralOnly.CheckAlign = ContentAlignment.MiddleRight;
            CheckBoxIsIntegralOnly.Font = new Font("Segoe UI", 16F);
            CheckBoxIsIntegralOnly.Location = new Point(121, 263);
            CheckBoxIsIntegralOnly.Name = "CheckBoxIsIntegralOnly";
            CheckBoxIsIntegralOnly.Size = new Size(312, 63);
            CheckBoxIsIntegralOnly.TabIndex = 4;
            CheckBoxIsIntegralOnly.Text = "Integral only?";
            CheckBoxIsIntegralOnly.UseVisualStyleBackColor = true;
            // 
            // CheckBoxMustBePrecise
            // 
            CheckBoxMustBePrecise.AutoSize = true;
            CheckBoxMustBePrecise.CheckAlign = ContentAlignment.MiddleRight;
            CheckBoxMustBePrecise.Font = new Font("Segoe UI", 16F);
            CheckBoxMustBePrecise.Location = new Point(58, 332);
            CheckBoxMustBePrecise.Name = "CheckBoxMustBePrecise";
            CheckBoxMustBePrecise.Size = new Size(375, 63);
            CheckBoxMustBePrecise.TabIndex = 5;
            CheckBoxMustBePrecise.Text = "Must be precise?";
            CheckBoxMustBePrecise.UseVisualStyleBackColor = true;
            // 
            // LabelSuggestedType
            // 
            LabelSuggestedType.AutoSize = true;
            LabelSuggestedType.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            LabelSuggestedType.Location = new Point(53, 461);
            LabelSuggestedType.Name = "LabelSuggestedType";
            LabelSuggestedType.Size = new Size(358, 59);
            LabelSuggestedType.TabIndex = 6;
            LabelSuggestedType.Text = "Suggested Type:";
            // 
            // LabelSuggestedTypeValue
            // 
            LabelSuggestedTypeValue.AutoSize = true;
            LabelSuggestedTypeValue.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            LabelSuggestedTypeValue.Location = new Point(407, 461);
            LabelSuggestedTypeValue.Name = "LabelSuggestedTypeValue";
            LabelSuggestedTypeValue.Size = new Size(362, 59);
            LabelSuggestedTypeValue.TabIndex = 7;
            LabelSuggestedTypeValue.Text = "not enough data";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1508, 680);
            Controls.Add(LabelSuggestedTypeValue);
            Controls.Add(LabelSuggestedType);
            Controls.Add(CheckBoxMustBePrecise);
            Controls.Add(CheckBoxIsIntegralOnly);
            Controls.Add(textBox1);
            Controls.Add(TextBoxMinValue);
            Controls.Add(LabelMaxValue);
            Controls.Add(LabelMinValue);
            Name = "MainForm";
            Text = "C# numeric types";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LabelMinValue;
        private Label LabelMaxValue;
        private TextBox TextBoxMinValue;
        private TextBox textBox1;
        private CheckBox CheckBoxIsIntegralOnly;
        private CheckBox CheckBoxMustBePrecise;
        private Label LabelSuggestedType;
        private Label LabelSuggestedTypeValue;
    }
}
