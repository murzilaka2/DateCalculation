namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            if (DateTime.TryParse(textBox1.Text, out DateTime targetData))
            {
                TimeSpan timeLeft = targetData - DateTime.Now;
                if (YearRadioButton.Checked)
                {
                    resultLabel.Text = $"{timeLeft.TotalDays / 365:F2} years left";
                }
                else if (MonthRadioButton.Checked)
                {
                    resultLabel.Text = $"{timeLeft.TotalDays / 30.44:F2} month left";
                }
                else if (DayRadioButton.Checked)
                {
                    resultLabel.Text = $"{timeLeft.TotalDays} days left";
                }
                else if (HourRadioButton.Checked)
                {
                    resultLabel.Text = $"{Math.Round(timeLeft.TotalMinutes, 2)} hours left";
                }
                else
                {
                    resultLabel.Text = $"{Math.Round(timeLeft.TotalSeconds, 2)} seconds left";
                }
            }
            else
            {
                resultLabel.ForeColor = Color.Red;
                resultLabel.Text = "Invalid date format.";
            }
        }
    }
}