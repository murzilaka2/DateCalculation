namespace WinFormsApp1
{
    partial class Form1
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
            textBox1 = new TextBox();
            label1 = new Label();
            resultLabel = new Label();
            CalculateButton = new Button();
            groupBox1 = new GroupBox();
            MinuteRadioButton = new RadioButton();
            HourRadioButton = new RadioButton();
            DayRadioButton = new RadioButton();
            MonthRadioButton = new RadioButton();
            YearRadioButton = new RadioButton();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(90, 31);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(129, 23);
            textBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 34);
            label1.Name = "label1";
            label1.Size = new Size(66, 15);
            label1.TabIndex = 1;
            label1.Text = "Enter date: ";
            // 
            // resultLabel
            // 
            resultLabel.AutoSize = true;
            resultLabel.Location = new Point(25, 9);
            resultLabel.Name = "resultLabel";
            resultLabel.Size = new Size(0, 15);
            resultLabel.TabIndex = 2;
            // 
            // CalculateButton
            // 
            CalculateButton.Location = new Point(18, 227);
            CalculateButton.Name = "CalculateButton";
            CalculateButton.Size = new Size(201, 23);
            CalculateButton.TabIndex = 3;
            CalculateButton.Text = "Calculate";
            CalculateButton.UseVisualStyleBackColor = true;
            CalculateButton.Click += CalculateButton_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(MinuteRadioButton);
            groupBox1.Controls.Add(HourRadioButton);
            groupBox1.Controls.Add(DayRadioButton);
            groupBox1.Controls.Add(MonthRadioButton);
            groupBox1.Controls.Add(YearRadioButton);
            groupBox1.Location = new Point(19, 60);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 155);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Select period";
            // 
            // MinuteRadioButton
            // 
            MinuteRadioButton.AutoSize = true;
            MinuteRadioButton.Location = new Point(6, 122);
            MinuteRadioButton.Name = "MinuteRadioButton";
            MinuteRadioButton.Size = new Size(63, 19);
            MinuteRadioButton.TabIndex = 4;
            MinuteRadioButton.Text = "Minute";
            MinuteRadioButton.UseVisualStyleBackColor = true;
            // 
            // HourRadioButton
            // 
            HourRadioButton.AutoSize = true;
            HourRadioButton.Location = new Point(6, 97);
            HourRadioButton.Name = "HourRadioButton";
            HourRadioButton.Size = new Size(52, 19);
            HourRadioButton.TabIndex = 3;
            HourRadioButton.Text = "Hour";
            HourRadioButton.UseVisualStyleBackColor = true;
            // 
            // DayRadioButton
            // 
            DayRadioButton.AutoSize = true;
            DayRadioButton.Location = new Point(6, 72);
            DayRadioButton.Name = "DayRadioButton";
            DayRadioButton.Size = new Size(45, 19);
            DayRadioButton.TabIndex = 2;
            DayRadioButton.Text = "Day";
            DayRadioButton.UseVisualStyleBackColor = true;
            // 
            // MonthRadioButton
            // 
            MonthRadioButton.AutoSize = true;
            MonthRadioButton.Location = new Point(6, 47);
            MonthRadioButton.Name = "MonthRadioButton";
            MonthRadioButton.Size = new Size(61, 19);
            MonthRadioButton.TabIndex = 1;
            MonthRadioButton.Text = "Month";
            MonthRadioButton.UseVisualStyleBackColor = true;
            // 
            // YearRadioButton
            // 
            YearRadioButton.AutoSize = true;
            YearRadioButton.Checked = true;
            YearRadioButton.Location = new Point(6, 22);
            YearRadioButton.Name = "YearRadioButton";
            YearRadioButton.Size = new Size(47, 19);
            YearRadioButton.TabIndex = 0;
            YearRadioButton.TabStop = true;
            YearRadioButton.Text = "Year";
            YearRadioButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(233, 262);
            Controls.Add(groupBox1);
            Controls.Add(CalculateButton);
            Controls.Add(resultLabel);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label label1;
        private Label resultLabel;
        private Button CalculateButton;
        private GroupBox groupBox1;
        private RadioButton MinuteRadioButton;
        private RadioButton HourRadioButton;
        private RadioButton DayRadioButton;
        private RadioButton MonthRadioButton;
        private RadioButton YearRadioButton;
    }
}