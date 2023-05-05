namespace BPMTap
{
    partial class SettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            timeoutNumeric = new NumericUpDown();
            tapCalcNumeric = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)timeoutNumeric).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tapCalcNumeric).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 25);
            label1.Name = "label1";
            label1.Size = new Size(147, 21);
            label1.TabIndex = 0;
            label1.Text = "Seconds to Timeout";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 84);
            label2.Name = "label2";
            label2.Size = new Size(131, 21);
            label2.TabIndex = 2;
            label2.Text = "Taps used for calc";
            // 
            // button1
            // 
            button1.Location = new Point(12, 135);
            button1.Name = "button1";
            button1.Size = new Size(275, 23);
            button1.TabIndex = 4;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // timeoutNumeric
            // 
            timeoutNumeric.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            timeoutNumeric.Location = new Point(167, 23);
            timeoutNumeric.Name = "timeoutNumeric";
            timeoutNumeric.Size = new Size(120, 29);
            timeoutNumeric.TabIndex = 5;
            timeoutNumeric.TextAlign = HorizontalAlignment.Right;
            // 
            // tapCalcNumeric
            // 
            tapCalcNumeric.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tapCalcNumeric.Location = new Point(167, 84);
            tapCalcNumeric.Name = "tapCalcNumeric";
            tapCalcNumeric.Size = new Size(120, 29);
            tapCalcNumeric.TabIndex = 6;
            tapCalcNumeric.TextAlign = HorizontalAlignment.Right;
            // 
            // SettingsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(299, 170);
            Controls.Add(tapCalcNumeric);
            Controls.Add(timeoutNumeric);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "SettingsForm";
            Text = "BPMTap Settings";
            ((System.ComponentModel.ISupportInitialize)timeoutNumeric).EndInit();
            ((System.ComponentModel.ISupportInitialize)tapCalcNumeric).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button button1;
        private NumericUpDown timeoutNumeric;
        private NumericUpDown tapCalcNumeric;
    }
}