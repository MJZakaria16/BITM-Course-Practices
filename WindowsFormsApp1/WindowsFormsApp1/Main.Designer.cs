namespace WindowsFormsApp1
{
    partial class Main
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
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.mothersNameTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.fathersNameTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.showAllInformationButton = new System.Windows.Forms.Button();
            this.addressButton = new System.Windows.Forms.Button();
            this.parentsNameButton = new System.Windows.Forms.Button();
            this.nameButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.infoListView = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label7 = new System.Windows.Forms.Label();
            this.removeAllButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name";
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(99, 83);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(264, 20);
            this.firstNameTextBox.TabIndex = 0;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(99, 119);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(264, 20);
            this.lastNameTextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Last Name";
            // 
            // mothersNameTextBox
            // 
            this.mothersNameTextBox.Location = new System.Drawing.Point(99, 194);
            this.mothersNameTextBox.Name = "mothersNameTextBox";
            this.mothersNameTextBox.Size = new System.Drawing.Size(264, 20);
            this.mothersNameTextBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Mothers Name";
            // 
            // fathersNameTextBox
            // 
            this.fathersNameTextBox.Location = new System.Drawing.Point(99, 158);
            this.fathersNameTextBox.Name = "fathersNameTextBox";
            this.fathersNameTextBox.Size = new System.Drawing.Size(264, 20);
            this.fathersNameTextBox.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Fathers Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 238);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Address";
            // 
            // addressTextBox
            // 
            this.addressTextBox.Location = new System.Drawing.Point(99, 235);
            this.addressTextBox.Multiline = true;
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(264, 61);
            this.addressTextBox.TabIndex = 4;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(99, 313);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 5;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // showAllInformationButton
            // 
            this.showAllInformationButton.Location = new System.Drawing.Point(180, 313);
            this.showAllInformationButton.Name = "showAllInformationButton";
            this.showAllInformationButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.showAllInformationButton.Size = new System.Drawing.Size(183, 23);
            this.showAllInformationButton.TabIndex = 6;
            this.showAllInformationButton.Text = "Show All Information";
            this.showAllInformationButton.UseVisualStyleBackColor = true;
            this.showAllInformationButton.Click += new System.EventHandler(this.showAllInformationButton_Click);
            // 
            // addressButton
            // 
            this.addressButton.Location = new System.Drawing.Point(288, 342);
            this.addressButton.Name = "addressButton";
            this.addressButton.Size = new System.Drawing.Size(75, 23);
            this.addressButton.TabIndex = 9;
            this.addressButton.Text = "Address";
            this.addressButton.UseVisualStyleBackColor = true;
            this.addressButton.Click += new System.EventHandler(this.addressButton_Click);
            // 
            // parentsNameButton
            // 
            this.parentsNameButton.Location = new System.Drawing.Point(180, 342);
            this.parentsNameButton.Name = "parentsNameButton";
            this.parentsNameButton.Size = new System.Drawing.Size(102, 23);
            this.parentsNameButton.TabIndex = 8;
            this.parentsNameButton.Text = "Parent\'s Name";
            this.parentsNameButton.UseVisualStyleBackColor = true;
            this.parentsNameButton.Click += new System.EventHandler(this.parentsNameButton_Click);
            // 
            // nameButton
            // 
            this.nameButton.Location = new System.Drawing.Point(99, 342);
            this.nameButton.Name = "nameButton";
            this.nameButton.Size = new System.Drawing.Size(75, 23);
            this.nameButton.TabIndex = 7;
            this.nameButton.Text = "Name";
            this.nameButton.UseVisualStyleBackColor = true;
            this.nameButton.Click += new System.EventHandler(this.nameButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(126, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(213, 26);
            this.label6.TabIndex = 10;
            this.label6.Text = "Personal Information";
            // 
            // infoListView
            // 
            this.infoListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.infoListView.GridLines = true;
            this.infoListView.HideSelection = false;
            this.infoListView.Location = new System.Drawing.Point(393, 83);
            this.infoListView.Name = "infoListView";
            this.infoListView.Size = new System.Drawing.Size(395, 213);
            this.infoListView.TabIndex = 11;
            this.infoListView.UseCompatibleStateImageBehavior = false;
            this.infoListView.View = System.Windows.Forms.View.Details;
            this.infoListView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.infoListView_MouseDoubleClick);
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Name";
            this.columnHeader2.Width = 76;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Fathers Name";
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Mothers Name";
            this.columnHeader4.Width = 110;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Address";
            this.columnHeader5.Width = 150;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(502, 40);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(159, 25);
            this.label7.TabIndex = 12;
            this.label7.Text = "Information List";
            // 
            // removeAllButton
            // 
            this.removeAllButton.Location = new System.Drawing.Point(507, 313);
            this.removeAllButton.Name = "removeAllButton";
            this.removeAllButton.Size = new System.Drawing.Size(75, 23);
            this.removeAllButton.TabIndex = 13;
            this.removeAllButton.Text = "Remove All";
            this.removeAllButton.UseVisualStyleBackColor = true;
            this.removeAllButton.Click += new System.EventHandler(this.removeAllButton_Click);
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(605, 313);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(75, 23);
            this.removeButton.TabIndex = 13;
            this.removeButton.Text = "Remove";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.removeAllButton);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.infoListView);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.nameButton);
            this.Controls.Add(this.parentsNameButton);
            this.Controls.Add(this.addressButton);
            this.Controls.Add(this.showAllInformationButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.mothersNameTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.fathersNameTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(this.label1);
            this.HelpButton = true;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Personal Information App";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox mothersNameTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox fathersNameTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button showAllInformationButton;
        private System.Windows.Forms.Button addressButton;
        private System.Windows.Forms.Button parentsNameButton;
        private System.Windows.Forms.Button nameButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListView infoListView;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button removeAllButton;
        private System.Windows.Forms.Button removeButton;
    }
}

