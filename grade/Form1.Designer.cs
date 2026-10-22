namespace grade
{
    partial class Form1
    {
        private Label titleLabel;
        private Label scoreLabel;
        private TextBox scoreTextBox;
        private Button checkGradeButton;
        private Label resultLabel;
        private TableLayoutPanel mainLayout;

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
            titleLabel = new Label();
            scoreLabel = new Label();
            scoreTextBox = new TextBox();
            checkGradeButton = new Button();
            resultLabel = new Label();
            mainLayout = new TableLayoutPanel();
            mainLayout.SuspendLayout();
            SuspendLayout();
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            mainLayout.SetColumnSpan(titleLabel, 3);
            titleLabel.Dock = DockStyle.Fill;
            titleLabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            titleLabel.Location = new Point(73, 25);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(805, 70);
            titleLabel.TabIndex = 0;
            titleLabel.Text = "Simple Grade Checker";
            titleLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // scoreLabel
            // 
            scoreLabel.Anchor = AnchorStyles.Right;
            scoreLabel.AutoSize = true;
            scoreLabel.Location = new Point(77, 106);
            scoreLabel.Name = "scoreLabel";
            scoreLabel.Size = new Size(192, 32);
            scoreLabel.TabIndex = 1;
            scoreLabel.Text = "Enter your score:";
            // 
            // scoreTextBox
            // 
            scoreTextBox.Anchor = AnchorStyles.Left;
            scoreTextBox.Location = new Point(275, 103);
            scoreTextBox.Name = "scoreTextBox";
            scoreTextBox.Size = new Size(100, 39);
            scoreTextBox.TabIndex = 2;
            // 
            // checkGradeButton
            // 
            checkGradeButton.Anchor = AnchorStyles.None;
            checkGradeButton.Location = new Point(389, 160);
            checkGradeButton.Name = "checkGradeButton";
            checkGradeButton.Size = new Size(170, 35);
            checkGradeButton.TabIndex = 3;
            checkGradeButton.Text = "Check Grade";
            checkGradeButton.UseVisualStyleBackColor = true;
            checkGradeButton.Click += checkGradeButton_Click;
            // 
            // resultLabel
            // 
            resultLabel.AutoSize = true;
            mainLayout.SetColumnSpan(resultLabel, 3);
            resultLabel.Dock = DockStyle.Fill;
            resultLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            resultLabel.Location = new Point(73, 205);
            resultLabel.Name = "resultLabel";
            resultLabel.Size = new Size(805, 120);
            resultLabel.TabIndex = 4;
            resultLabel.Text = "Your grade will appear here.";
            resultLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // mainLayout
            // 
            mainLayout.ColumnCount = 3;
            mainLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            mainLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            mainLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            mainLayout.Controls.Add(titleLabel, 0, 0);
            mainLayout.Controls.Add(scoreLabel, 0, 1);
            mainLayout.Controls.Add(scoreTextBox, 1, 1);
            mainLayout.Controls.Add(checkGradeButton, 1, 2);
            mainLayout.Controls.Add(resultLabel, 0, 3);
            mainLayout.Dock = DockStyle.Fill;
            mainLayout.Location = new Point(0, 0);
            mainLayout.Name = "mainLayout";
            mainLayout.Padding = new Padding(70, 25, 70, 25);
            mainLayout.RowCount = 4;
            mainLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 70F));
            mainLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 55F));
            mainLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 55F));
            mainLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            mainLayout.Size = new Size(951, 350);
            mainLayout.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(951, 350);
            Controls.Add(mainLayout);
            MinimumSize = new Size(500, 300);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Grade Checker";
            mainLayout.ResumeLayout(false);
            mainLayout.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
    }
}
