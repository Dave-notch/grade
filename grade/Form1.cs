namespace grade
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkGradeButton_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(scoreTextBox.Text, out double score))
            {
                resultLabel.Text = "Please enter a number from 0 to 100.";
                return;
            }

            if (score < 0 || score > 100)
            {
                resultLabel.Text = "The score must be between 0 and 100.";
                return;
            }

            string grade;

            if (score >= 90)
            {
                grade = "A";
            }
            else if (score >= 80)
            {
                grade = "B";
            }
            else if (score >= 70)
            {
                grade = "C";
            }
            else if (score >= 60)
            {
                grade = "D";
            }
            else
            {
                grade = "F";
            }

            resultLabel.Text = "Your letter grade is: " + grade;
        }
    }
}
