namespace WindowsFormsApp4
{
    partial class MainUI
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
            this.label1 = new System.Windows.Forms.Label();
            this.equationComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.equationLabel = new System.Windows.Forms.Label();
            this.firstTextBox = new System.Windows.Forms.TextBox();
            this.firstLabel = new System.Windows.Forms.Label();
            this.secondLabel = new System.Windows.Forms.Label();
            this.secondTextBox = new System.Windows.Forms.TextBox();
            this.perYearLabel = new System.Windows.Forms.Label();
            this.thirdLabel = new System.Windows.Forms.Label();
            this.thirdTextBox = new System.Windows.Forms.TextBox();
            this.yearComboBox = new System.Windows.Forms.ComboBox();
            this.clearButton = new System.Windows.Forms.Button();
            this.calculateButton = new System.Windows.Forms.Button();
            this.answerTextBox = new System.Windows.Forms.TextBox();
            this.perYearLabel2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Solve for:";
            // 
            // equationComboBox
            // 
            this.equationComboBox.FormattingEnabled = true;
            this.equationComboBox.Location = new System.Drawing.Point(86, 32);
            this.equationComboBox.Name = "equationComboBox";
            this.equationComboBox.Size = new System.Drawing.Size(207, 21);
            this.equationComboBox.TabIndex = 0;
            this.equationComboBox.SelectedIndexChanged += new System.EventHandler(this.equationComboBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(105, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Where:";
            // 
            // equationLabel
            // 
            this.equationLabel.AutoSize = true;
            this.equationLabel.Location = new System.Drawing.Point(144, 66);
            this.equationLabel.Name = "equationLabel";
            this.equationLabel.Size = new System.Drawing.Size(0, 13);
            this.equationLabel.TabIndex = 0;
            // 
            // firstTextBox
            // 
            this.firstTextBox.Location = new System.Drawing.Point(86, 92);
            this.firstTextBox.Name = "firstTextBox";
            this.firstTextBox.Size = new System.Drawing.Size(153, 20);
            this.firstTextBox.TabIndex = 1;
            // 
            // firstLabel
            // 
            this.firstLabel.AutoSize = true;
            this.firstLabel.Location = new System.Drawing.Point(10, 92);
            this.firstLabel.Name = "firstLabel";
            this.firstLabel.Size = new System.Drawing.Size(22, 13);
            this.firstLabel.TabIndex = 0;
            this.firstLabel.Text = "-----";
            // 
            // secondLabel
            // 
            this.secondLabel.AutoSize = true;
            this.secondLabel.Location = new System.Drawing.Point(10, 124);
            this.secondLabel.Name = "secondLabel";
            this.secondLabel.Size = new System.Drawing.Size(22, 13);
            this.secondLabel.TabIndex = 0;
            this.secondLabel.Text = "-----";
            // 
            // secondTextBox
            // 
            this.secondTextBox.Location = new System.Drawing.Point(86, 125);
            this.secondTextBox.Name = "secondTextBox";
            this.secondTextBox.Size = new System.Drawing.Size(153, 20);
            this.secondTextBox.TabIndex = 2;
            // 
            // perYearLabel
            // 
            this.perYearLabel.AutoSize = true;
            this.perYearLabel.Location = new System.Drawing.Point(21, 137);
            this.perYearLabel.Name = "perYearLabel";
            this.perYearLabel.Size = new System.Drawing.Size(22, 13);
            this.perYearLabel.TabIndex = 0;
            this.perYearLabel.Text = "-----";
            // 
            // thirdLabel
            // 
            this.thirdLabel.AutoSize = true;
            this.thirdLabel.Location = new System.Drawing.Point(24, 164);
            this.thirdLabel.Name = "thirdLabel";
            this.thirdLabel.Size = new System.Drawing.Size(22, 13);
            this.thirdLabel.TabIndex = 0;
            this.thirdLabel.Text = "-----";
            // 
            // thirdTextBox
            // 
            this.thirdTextBox.Location = new System.Drawing.Point(86, 160);
            this.thirdTextBox.Name = "thirdTextBox";
            this.thirdTextBox.Size = new System.Drawing.Size(153, 20);
            this.thirdTextBox.TabIndex = 3;
            // 
            // yearComboBox
            // 
            this.yearComboBox.FormattingEnabled = true;
            this.yearComboBox.Location = new System.Drawing.Point(126, 186);
            this.yearComboBox.Name = "yearComboBox";
            this.yearComboBox.Size = new System.Drawing.Size(113, 21);
            this.yearComboBox.TabIndex = 4;
            this.yearComboBox.VisibleChanged += new System.EventHandler(this.equationComboBox_SelectedIndexChanged);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(54, 243);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 3;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(218, 243);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(75, 23);
            this.calculateButton.TabIndex = 3;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // answerTextBox
            // 
            this.answerTextBox.Location = new System.Drawing.Point(77, 285);
            this.answerTextBox.Multiline = true;
            this.answerTextBox.Name = "answerTextBox";
            this.answerTextBox.Size = new System.Drawing.Size(191, 50);
            this.answerTextBox.TabIndex = 5;
            // 
            // perYearLabel2
            // 
            this.perYearLabel2.AutoSize = true;
            this.perYearLabel2.Location = new System.Drawing.Point(35, 177);
            this.perYearLabel2.Name = "perYearLabel2";
            this.perYearLabel2.Size = new System.Drawing.Size(22, 13);
            this.perYearLabel2.TabIndex = 0;
            this.perYearLabel2.Text = "-----";
            // 
            // MainUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 389);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.thirdTextBox);
            this.Controls.Add(this.secondTextBox);
            this.Controls.Add(this.answerTextBox);
            this.Controls.Add(this.firstTextBox);
            this.Controls.Add(this.yearComboBox);
            this.Controls.Add(this.equationComboBox);
            this.Controls.Add(this.secondLabel);
            this.Controls.Add(this.equationLabel);
            this.Controls.Add(this.firstLabel);
            this.Controls.Add(this.thirdLabel);
            this.Controls.Add(this.perYearLabel);
            this.Controls.Add(this.perYearLabel2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MainUI";
            this.Text = "Simple Interest Calculator";
            this.Load += new System.EventHandler(this.MainUI_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox equationComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label equationLabel;
        private System.Windows.Forms.TextBox firstTextBox;
        private System.Windows.Forms.Label firstLabel;
        private System.Windows.Forms.Label secondLabel;
        private System.Windows.Forms.TextBox secondTextBox;
        private System.Windows.Forms.Label perYearLabel;
        private System.Windows.Forms.Label thirdLabel;
        private System.Windows.Forms.TextBox thirdTextBox;
        private System.Windows.Forms.ComboBox yearComboBox;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.TextBox answerTextBox;
        private System.Windows.Forms.Label perYearLabel2;
    }
}

